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
			this.label3 = new System.Windows.Forms.Label();
			this.nudColumnCount = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.rdoRowFirst = new System.Windows.Forms.RadioButton();
			this.rdoColumnFirst = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.nudSpeed = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanelColumns = new System.Windows.Forms.FlowLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudColumnCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
			this.flowLayoutPanelColumns.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(905, 180);
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
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelColumns, 0, 2);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 501);
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
			this.gdvMain.Size = new System.Drawing.Size(905, 195);
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(905, 44);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new System.Drawing.Point(605, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(297, 38);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "清空(&C)";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnInput
			// 
			this.btnInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInput.Location = new System.Drawing.Point(304, 3);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(295, 38);
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
			this.btnPaste.Size = new System.Drawing.Size(295, 38);
			this.btnPaste.TabIndex = 0;
			this.btnPaste.Text = "粘贴(&P)";
			this.btnPaste.UseVisualStyleBackColor = true;
			this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.nudColumnCount);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this.rdoRowFirst);
			this.flowLayoutPanel1.Controls.Add(this.rdoColumnFirst);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.nudSpeed);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 183);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(905, 29);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 24);
			this.label2.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "共";
			// 
			// nudColumnCount
			// 
			this.nudColumnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudColumnCount.Location = new System.Drawing.Point(43, 3);
			this.nudColumnCount.Name = "nudColumnCount";
			this.nudColumnCount.Size = new System.Drawing.Size(60, 31);
			this.nudColumnCount.TabIndex = 10;
			this.nudColumnCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudColumnCount.ValueChanged += new System.EventHandler(this.nudColumnCount_ValueChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(109, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "列";
			// 
			// rdoRowFirst
			// 
			this.rdoRowFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.rdoRowFirst.AutoSize = true;
			this.rdoRowFirst.Checked = true;
			this.rdoRowFirst.Location = new System.Drawing.Point(143, 4);
			this.rdoRowFirst.Name = "rdoRowFirst";
			this.rdoRowFirst.Size = new System.Drawing.Size(107, 28);
			this.rdoRowFirst.TabIndex = 12;
			this.rdoRowFirst.TabStop = true;
			this.rdoRowFirst.Text = "先行后列";
			this.rdoRowFirst.UseVisualStyleBackColor = true;
			// 
			// rdoColumnFirst
			// 
			this.rdoColumnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.rdoColumnFirst.AutoSize = true;
			this.rdoColumnFirst.Location = new System.Drawing.Point(256, 4);
			this.rdoColumnFirst.Name = "rdoColumnFirst";
			this.rdoColumnFirst.Size = new System.Drawing.Size(107, 28);
			this.rdoColumnFirst.TabIndex = 13;
			this.rdoColumnFirst.Text = "先列后行";
			this.rdoColumnFirst.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(369, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(280, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "输入速度（数值越小，速度越快）";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nudSpeed
			// 
			this.nudSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudSpeed.Location = new System.Drawing.Point(655, 3);
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
			this.nudSpeed.Size = new System.Drawing.Size(120, 31);
			this.nudSpeed.TabIndex = 8;
			this.toolTip1.SetToolTip(this.nudSpeed, "若因机器较慢导致输入问题，可尝试调大数值。最小值（默认值）20，最大值1000");
			this.nudSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// flowLayoutPanelColumns
			// 
			this.flowLayoutPanelColumns.Controls.Add(this.label6);
			this.flowLayoutPanelColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelColumns.Location = new System.Drawing.Point(3, 218);
			this.flowLayoutPanelColumns.Name = "flowLayoutPanelColumns";
			this.flowLayoutPanelColumns.Size = new System.Drawing.Size(905, 29);
			this.flowLayoutPanelColumns.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 24);
			this.label6.TabIndex = 0;
			this.label6.Text = "选择需要输入数据的列：";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 501);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmMain";
			this.Text = "成绩输入器#通用版#（V2.0 by bullfrog2000@sina.com）";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudColumnCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
			this.flowLayoutPanelColumns.ResumeLayout(false);
			this.flowLayoutPanelColumns.PerformLayout();
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
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColumns;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudColumnCount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdoRowFirst;
		private System.Windows.Forms.RadioButton rdoColumnFirst;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudSpeed;
		private System.Windows.Forms.Label label6;

	}
}

