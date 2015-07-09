namespace MarkInputHelper
{
	partial class frmMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gdvMain = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnInput = new System.Windows.Forms.Button();
			this.btnPaste = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.rdoNoExp = new System.Windows.Forms.RadioButton();
			this.rdoExp = new System.Windows.Forms.RadioButton();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.chkExp = new System.Windows.Forms.CheckBox();
			this.chkUsual = new System.Windows.Forms.CheckBox();
			this.chkEnd = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nudSpeed = new System.Windows.Forms.NumericUpDown();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(835, 180);
			this.label1.TabIndex = 3;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.gdvMain, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 501);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// gdvMain
			// 
			this.gdvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdvMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gdvMain.Location = new System.Drawing.Point(3, 253);
			this.gdvMain.Name = "gdvMain";
			this.gdvMain.ReadOnly = true;
			this.gdvMain.RowTemplate.Height = 24;
			this.gdvMain.Size = new System.Drawing.Size(835, 195);
			this.gdvMain.TabIndex = 6;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnInput, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnPaste, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 454);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(835, 44);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new System.Drawing.Point(559, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(273, 38);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "清空(&C)";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnInput
			// 
			this.btnInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInput.Location = new System.Drawing.Point(281, 3);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(272, 38);
			this.btnInput.TabIndex = 1;
			this.btnInput.Text = "输入(&I)";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// btnPaste
			// 
			this.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPaste.Location = new System.Drawing.Point(3, 3);
			this.btnPaste.Name = "btnPaste";
			this.btnPaste.Size = new System.Drawing.Size(272, 38);
			this.btnPaste.TabIndex = 0;
			this.btnPaste.Text = "粘贴(&P)";
			this.btnPaste.UseVisualStyleBackColor = true;
			this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.rdoNoExp);
			this.flowLayoutPanel1.Controls.Add(this.rdoExp);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 183);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 29);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "是否包含实验成绩：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rdoNoExp
			// 
			this.rdoNoExp.AutoSize = true;
			this.rdoNoExp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rdoNoExp.Location = new System.Drawing.Point(125, 3);
			this.rdoNoExp.Name = "rdoNoExp";
			this.rdoNoExp.Size = new System.Drawing.Size(98, 21);
			this.rdoNoExp.TabIndex = 0;
			this.rdoNoExp.TabStop = true;
			this.rdoNoExp.Text = "不含实验成绩";
			this.rdoNoExp.UseVisualStyleBackColor = true;
			this.rdoNoExp.CheckedChanged += new System.EventHandler(this.rdoNoExp_CheckedChanged);
			// 
			// rdoExp
			// 
			this.rdoExp.AutoSize = true;
			this.rdoExp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rdoExp.Location = new System.Drawing.Point(229, 3);
			this.rdoExp.Name = "rdoExp";
			this.rdoExp.Size = new System.Drawing.Size(86, 21);
			this.rdoExp.TabIndex = 1;
			this.rdoExp.TabStop = true;
			this.rdoExp.Text = "含实验成绩";
			this.rdoExp.UseVisualStyleBackColor = true;
			this.rdoExp.CheckedChanged += new System.EventHandler(this.rdoExp_CheckedChanged);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label3);
			this.flowLayoutPanel2.Controls.Add(this.chkExp);
			this.flowLayoutPanel2.Controls.Add(this.chkUsual);
			this.flowLayoutPanel2.Controls.Add(this.chkEnd);
			this.flowLayoutPanel2.Controls.Add(this.label4);
			this.flowLayoutPanel2.Controls.Add(this.nudSpeed);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 218);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(835, 29);
			this.flowLayoutPanel2.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 27);
			this.label3.TabIndex = 5;
			this.label3.Text = "要输入的成绩项（可多选）：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkExp
			// 
			this.chkExp.AutoSize = true;
			this.chkExp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkExp.Location = new System.Drawing.Point(173, 3);
			this.chkExp.Name = "chkExp";
			this.chkExp.Size = new System.Drawing.Size(75, 21);
			this.chkExp.TabIndex = 1;
			this.chkExp.Text = "实验成绩";
			this.chkExp.UseVisualStyleBackColor = true;
			// 
			// chkUsual
			// 
			this.chkUsual.AutoSize = true;
			this.chkUsual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkUsual.Location = new System.Drawing.Point(254, 3);
			this.chkUsual.Name = "chkUsual";
			this.chkUsual.Size = new System.Drawing.Size(75, 21);
			this.chkUsual.TabIndex = 2;
			this.chkUsual.Text = "平时成绩";
			this.chkUsual.UseVisualStyleBackColor = true;
			// 
			// chkEnd
			// 
			this.chkEnd.AutoSize = true;
			this.chkEnd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkEnd.Location = new System.Drawing.Point(335, 3);
			this.chkEnd.Name = "chkEnd";
			this.chkEnd.Size = new System.Drawing.Size(75, 21);
			this.chkEnd.TabIndex = 3;
			this.chkEnd.Text = "期末成绩";
			this.chkEnd.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(416, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 27);
			this.label4.TabIndex = 6;
			this.label4.Text = "输入速度（数值越小，速度越快）";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nudSpeed
			// 
			this.nudSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nudSpeed.Location = new System.Drawing.Point(610, 3);
			this.nudSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudSpeed.Name = "nudSpeed";
			this.nudSpeed.Size = new System.Drawing.Size(120, 23);
			this.nudSpeed.TabIndex = 4;
			this.toolTip1.SetToolTip(this.nudSpeed, "若因机器较慢导致输入问题，可尝试调大数值。最小值（默认值）20，最大值1000");
			this.nudSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 501);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmMain";
			this.Text = "成绩输入器（V1.2 by bullfrog2000@sina.com）";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView gdvMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnPaste;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.RadioButton rdoNoExp;
		private System.Windows.Forms.RadioButton rdoExp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.CheckBox chkExp;
		private System.Windows.Forms.CheckBox chkUsual;
		private System.Windows.Forms.CheckBox chkEnd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudSpeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip toolTip1;

	}
}

