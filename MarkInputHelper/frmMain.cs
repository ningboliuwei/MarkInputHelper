using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarkInputHelper
{
	public partial class frmMain : Form
	{
		//private bool stopFlag = false;
		//[Flags]
		//private enum MouseEventFlag : uint
		//{
		//	LeftDown = 0x0002,
		//	LeftUp = 0x0004,
		//}

		//[DllImport("user32.dll")]
		//private static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);


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
			if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
			{
				MessageBox.Show("请选择成绩输入模式", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("确定输入成绩吗？", "问题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				InputMarks();
			}
		}

		private void InputMarks()
		{
			int interval = 50;

			MessageBox.Show("请在点击“确定”按钮之后10秒内双击成绩输入页面上平时成绩列的第一个输入框，保证此栏数据高亮，并耐心等待输入开始", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Thread.Sleep(10000);

			//#region 模拟双击鼠标，全选
			//mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
			//mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);

			//mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
			//mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
			//#endregion

			Thread.Sleep(interval);
			for (int i = 0; i < gdvMain.RowCount-1; i++)
			{
				for (int j = 0; j < gdvMain.ColumnCount; j++)
				{
					if (radioButton2.Checked)//只输入期末成绩
					{
						SendKeys.Send("{TAB}");
					}

					SendKeys.Send("{DELETE}");
					Thread.Sleep(interval);
					SendKeys.Send(gdvMain.Rows[i].Cells[j].Value.ToString().Trim());
					Thread.Sleep(interval);
					SendKeys.Send("{TAB}");

					if (radioButton1.Checked)//只输入平时成绩
					{
						SendKeys.Send("{TAB}");
					}


					Thread.Sleep(interval);
				}
			}
		}

		

		
		
	}
}

