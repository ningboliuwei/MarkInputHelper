using System;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace MarkInputHelper
{
	using WindowsInput.Native;

	public partial class frmMain : Form
	{
		private InputSimulator _inputSimulator = new InputSimulator();
		private int selectedColumnCount;

		private enum InputType
		{
			RowFirst,
			ColumnFirst
		}


		public frmMain()
		{
			InitializeComponent();
		}

		private void GenerateColumnCheckBoxes(int baseNumber, int count)
		{
			for (int i = 0; i < count; i++)
			{
				CheckBox checkBox = new CheckBox();
				checkBox.AutoSize = true;
				checkBox.Text = (baseNumber + i).ToString();
				flowLayoutPanelColumns.Controls.Add(checkBox);
			}
		}

		public void DataGirdViewCellPaste()
		{
			try
			{
				// 获取剪切板的内容，并按行分割
				string pasteText = Clipboard.GetText();

				if (string.IsNullOrEmpty(pasteText))
				{
					return;
				}

				string[] lines = pasteText.Split('\r');


				foreach (string line in lines)
				{
					if (string.IsNullOrEmpty(line.Trim()))
					{
						continue;
					}
					// 按 Tab 分割数据
					string[] vals = line.Split('\t');

					if (gdvMain.Columns.Count == 0)
					{
						for (int i = 0; i < vals.Length; i++)
						{
							gdvMain.Columns.Add("c" + i, Convert.ToChar(Convert.ToInt32('A') + i).ToString());
						}
					}

					gdvMain.Rows.Add(vals);
					gdvMain.Rows[gdvMain.RowCount - 1].HeaderCell.Value = gdvMain.RowCount;
				}

				gdvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				gdvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

				gdvMain.AutoResizeColumns();
				gdvMain.AutoResizeRows();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			GenerateColumnCheckBoxes(1, Convert.ToInt32(nudColumnCount.Value));
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
			{
				DataGirdViewCellPaste();
			}
		}

		private void InitializeDataGridView()
		{
			gdvMain.Rows.Clear();
			gdvMain.Columns.Clear();
		}

		private void btnPaste_Click(object sender, EventArgs e)
		{
			DataGirdViewCellPaste();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			InitializeDataGridView();
		}

		private void btnInput_Click(object sender, EventArgs e)
		{

			selectedColumnCount = 0;
			for (int i = 1; i < flowLayoutPanelColumns.Controls.Count; i++)
			{
				if (((CheckBox)flowLayoutPanelColumns.Controls[i]).Checked)
				{
					selectedColumnCount++;
				}
			}

			if (gdvMain.ColumnCount == 0)
			{
				MessageBox.Show("没有粘贴任何数据。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (selectedColumnCount == 0)
			{
				MessageBox.Show("至少要选择一列用于输入数据。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (gdvMain.ColumnCount != selectedColumnCount)
			{
				MessageBox.Show("选择的列数与数据列数不一致。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!rdoRowFirst.Checked && !rdoColumnFirst.Checked )
			{
				MessageBox.Show("请选择输入方式（先行后列或先列后行）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("确定输入成绩吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (rdoRowFirst.Checked)
				{
					InputMarks(InputType.RowFirst);
				}
				else
				{
					InputMarks(InputType.ColumnFirst);
				}
			}
		}

		private void InputMarks(InputType inputType)
		{
			int columnCount = Convert.ToInt32(nudColumnCount.Value);

			MessageBox.Show("请在点击“确定”按钮之后10秒内点击成绩输入页面上最左列的最上一个输入框，保证此栏获取输入焦点（光标闪），之后不要移动鼠标，并耐心等待输入开始", "注意", MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
			Thread.Sleep(10000);

			if (inputType == InputType.RowFirst)
			{
				for (int i = 0; i < gdvMain.RowCount - 1; i++)
				{
					int currentDataColumnIndex = 0;

					for (int j = 0; j < columnCount; j++)
					{
						if (((CheckBox)flowLayoutPanelColumns.Controls[j + 1]).Checked)
						{
							InputData(gdvMain.Rows[i].Cells[currentDataColumnIndex].Value.ToString());
							//Clipboard.SetText(gdvMain.Rows[i].Cells[currentDataColumnIndex].Value.ToString().Trim());
							//PasteData();
							currentDataColumnIndex++;
						}

						GoToNextInput();
					}
				}
			}
			else
			{
				int currentDataColumnIndex = 0;
				for (int i = 0; i < columnCount; i++)
				{
					if (((CheckBox)flowLayoutPanelColumns.Controls[i + 1]).Checked)
					{
						for (int j = 0; j < gdvMain.RowCount - 1; j++)
						{
							InputData(gdvMain.Rows[j].Cells[currentDataColumnIndex].Value.ToString());
							//Clipboard.SetText(gdvMain.Rows[j].Cells[currentDataColumnIndex].Value.ToString().Trim());
							//PasteData();
							GoToNextInput();
						}
						currentDataColumnIndex++;
					}
					else
					{
						for (int j = 0; j < gdvMain.RowCount - 1; j++)
						{
							GoToNextInput();
						}
					}

					//如果已经输入完毕所有列，提早结束输入
					if (currentDataColumnIndex == selectedColumnCount)
					{
						break;
					}
				}
			}
		}

		public void InputData(string data)
		{
			_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A); //全选当前输入框
			_inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DELETE);
			_inputSimulator.Keyboard.TextEntry(data);
			_inputSimulator.Keyboard.Sleep(Convert.ToInt32(nudSpeed.Value));
		}

		public void PasteData()
		{
			_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A); //全选当前输入框
			_inputSimulator.Keyboard.KeyPress(VirtualKeyCode.DELETE);
			_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
			_inputSimulator.Keyboard.Sleep(Convert.ToInt32(nudSpeed.Value));
		}

		public void GoToNextInput()
		{
			_inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
			_inputSimulator.Keyboard.Sleep(Convert.ToInt32(nudSpeed.Value));
		}

		private void nudColumnCount_ValueChanged(object sender, EventArgs e)
		{
			int differ = Convert.ToInt32(nudColumnCount.Value) - (flowLayoutPanelColumns.Controls.Count - 1);

			if (differ > 0)
			{
				GenerateColumnCheckBoxes(flowLayoutPanelColumns.Controls.Count, differ);
			}
			else
			{
				for (int i = 0; i < Math.Abs(differ); i++)
				{
					flowLayoutPanelColumns.Controls.RemoveAt(flowLayoutPanelColumns.Controls.Count - 1);
				}
			}
		}
	}
}