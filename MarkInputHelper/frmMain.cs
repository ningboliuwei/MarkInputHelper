using System;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace MarkInputHelper
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
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

		private void Form1_Load(object sender, EventArgs e)
		{
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
			int checkCount = 0;

			if (rdoNoExp.Checked == false && rdoExp.Checked == false)
			{
				MessageBox.Show("请选择是否包含实验成绩", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (chkExp.Checked == false && chkUsual.Checked == false && chkEnd.Checked == false)
			{
				MessageBox.Show("请选择要输入的成绩列", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			#region 得到选中的复选框数量

			if (chkExp.Checked)
			{
				checkCount++;
			}

			if (chkUsual.Checked)
			{
				checkCount++;
			}

			if (chkEnd.Checked)
			{
				checkCount++;
			}

			#endregion

			if (checkCount != gdvMain.ColumnCount)
			{
				MessageBox.Show("选择的成绩列与粘贴的数据列数不一致，请重新选择成绩列或粘贴数据", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("确定输入成绩吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				InputMarks(checkCount);
			}
		}

		private void InputMarks(int columnCount)
		{
			int interval = 100;

			MessageBox.Show("请在点击“确定”按钮之后10秒内点击成绩输入页面上最左列的最上一个输入框，保证此栏获取输入焦点（光标闪），之后不要移动鼠标，并耐心等待输入开始", "注意", MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
			Thread.Sleep(10000);

			for (int i = 0; i < gdvMain.RowCount - 1; i++)
			{
				if (columnCount == 1) //只有一列成绩
				{
					if (chkExp.Checked) //只输入实验成绩
					{
						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入成绩
						GoToNextInput(); //→平时成绩
						GoToNextInput(); //→期末成绩
						GoToNextInput(); //→换行
					}
					else if (chkUsual.Checked) //只输入平时成绩
					{
						if (rdoExp.Checked) //若带实验的平时成绩
						{
							GoToNextInput(); //→平时成绩
						}

						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入成绩

						GoToNextInput(); //→期末成绩
						GoToNextInput(); //→换行
					}
					else if (chkEnd.Checked) //只输入期末成绩
					SendKeys.SendWait("{TAB}");

					{
						if (rdoExp.Checked) //若带实验的期末成绩
						{
							GoToNextInput(); //→平时成绩
						}

						GoToNextInput(); //→期末成绩

						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入成绩

						GoToNextInput(); //换行
					}
				}
				else if (columnCount == 2) //有两列数据
				{
					if (chkExp.Checked && chkUsual.Checked) //实验成绩与平时成绩
					{
						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入实验成绩

						GoToNextInput(); //→平时成绩
						InputData(gdvMain.Rows[i].Cells[1].Value.ToString().Trim()); //输入平时成绩
						GoToNextInput(); //→期末成绩
						GoToNextInput(); //→换行
					}
					else if (chkExp.Checked && chkEnd.Checked) //实验成绩与期末成绩
					{
						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入实验成绩
						GoToNextInput(); //→平时成绩
						GoToNextInput(); //→期末成绩
						InputData(gdvMain.Rows[i].Cells[1].Value.ToString().Trim()); //输入期末成绩
						GoToNextInput(); //→换行
					}
					else if (chkUsual.Checked && chkEnd.Checked) //平时成绩与期末成绩
					{
						if (rdoExp.Checked) //若带实验的期末成绩
						{
							GoToNextInput(); //→平时成绩
						}
						InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入平时成绩
						GoToNextInput(); //→期末成绩
						InputData(gdvMain.Rows[i].Cells[1].Value.ToString().Trim()); //输入期末成绩
						GoToNextInput(); //→换行
					}
				}
				else if (columnCount == 3) //实验成绩、平时成绩与期末成绩
				{
					InputData(gdvMain.Rows[i].Cells[0].Value.ToString().Trim()); //输入实验成绩
					GoToNextInput(); //→平时成绩
					InputData(gdvMain.Rows[i].Cells[1].Value.ToString().Trim()); //输入平时成绩
					GoToNextInput(); //→期末成绩
					InputData(gdvMain.Rows[i].Cells[2].Value.ToString().Trim()); //输入期末成绩
					GoToNextInput(); //→换行
				}
			}
		}

		public void InputData(string data)
		{
			InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A); //全选当前输入框
			InputSimulator.SimulateKeyPress(VirtualKeyCode.DELETE);
			InputSimulator.SimulateTextEntry(data);
			Thread.Sleep(Convert.ToInt32(nudSpeed.Value));
		}

		public void GoToNextInput()
		{
			InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
			Thread.Sleep(Convert.ToInt32(nudSpeed.Value));
		}

		private void rdoNoExp_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoNoExp.Checked)
			{
				chkExp.Enabled = false;
				chkExp.Checked = false;
			}
		}

		private void rdoExp_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoExp.Checked)
			{
				chkExp.Enabled = true;
			}
		}
	}
}