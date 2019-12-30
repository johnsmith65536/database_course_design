namespace WindowsFormsApplication4
{
	partial class Frm_main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.管理员菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新柜员注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户开户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.信息查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.信息补充ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户挂失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户明细打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.账户销户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.资金业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.存款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.取款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.转账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.余额查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pcb_user = new System.Windows.Forms.PictureBox();
			this.lbl_username = new System.Windows.Forms.Label();
			this.lbl_jobnum = new System.Windows.Forms.Label();
			this.lbl_sex = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 399);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(629, 26);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(614, 21);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理系统ToolStripMenuItem,
            this.管理员菜单ToolStripMenuItem,
            this.账户业务ToolStripMenuItem,
            this.资金业务ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(629, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 管理系统ToolStripMenuItem
			// 
			this.管理系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换用户ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
			this.管理系统ToolStripMenuItem.Name = "管理系统ToolStripMenuItem";
			this.管理系统ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
			this.管理系统ToolStripMenuItem.Text = "系统管理(&M)";
			// 
			// 切换用户ToolStripMenuItem
			// 
			this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
			this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.切换用户ToolStripMenuItem.Text = "切换用户(&C)";
			this.切换用户ToolStripMenuItem.Click += new System.EventHandler(this.切换用户ToolStripMenuItem_Click);
			// 
			// 退出系统ToolStripMenuItem
			// 
			this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
			this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.退出系统ToolStripMenuItem.Text = "退出系统(&E)";
			this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
			// 
			// 管理员菜单ToolStripMenuItem
			// 
			this.管理员菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新柜员注册ToolStripMenuItem});
			this.管理员菜单ToolStripMenuItem.Name = "管理员菜单ToolStripMenuItem";
			this.管理员菜单ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
			this.管理员菜单ToolStripMenuItem.Text = "管理员(&N)";
			// 
			// 新柜员注册ToolStripMenuItem
			// 
			this.新柜员注册ToolStripMenuItem.Name = "新柜员注册ToolStripMenuItem";
			this.新柜员注册ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.新柜员注册ToolStripMenuItem.Text = "柜员注册(&R)";
			this.新柜员注册ToolStripMenuItem.Click += new System.EventHandler(this.新柜员注册ToolStripMenuItem_Click);
			// 
			// 账户业务ToolStripMenuItem
			// 
			this.账户业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户开户ToolStripMenuItem,
            this.账户信息ToolStripMenuItem,
            this.账户挂失ToolStripMenuItem,
            this.账户明细打印ToolStripMenuItem,
            this.账户销户ToolStripMenuItem});
			this.账户业务ToolStripMenuItem.Name = "账户业务ToolStripMenuItem";
			this.账户业务ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
			this.账户业务ToolStripMenuItem.Text = "账户业务(&A)";
			// 
			// 账户开户ToolStripMenuItem
			// 
			this.账户开户ToolStripMenuItem.Name = "账户开户ToolStripMenuItem";
			this.账户开户ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.账户开户ToolStripMenuItem.Text = "账户开户(&N)";
			this.账户开户ToolStripMenuItem.Click += new System.EventHandler(this.账户开户ToolStripMenuItem_Click);
			// 
			// 账户信息ToolStripMenuItem
			// 
			this.账户信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查看ToolStripMenuItem,
            this.信息补充ToolStripMenuItem});
			this.账户信息ToolStripMenuItem.Name = "账户信息ToolStripMenuItem";
			this.账户信息ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.账户信息ToolStripMenuItem.Text = "账户信息(&I)";
			// 
			// 信息查看ToolStripMenuItem
			// 
			this.信息查看ToolStripMenuItem.Name = "信息查看ToolStripMenuItem";
			this.信息查看ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.信息查看ToolStripMenuItem.Text = "信息查看(&W)";
			this.信息查看ToolStripMenuItem.Click += new System.EventHandler(this.信息查看ToolStripMenuItem_Click);
			// 
			// 信息补充ToolStripMenuItem
			// 
			this.信息补充ToolStripMenuItem.Name = "信息补充ToolStripMenuItem";
			this.信息补充ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.信息补充ToolStripMenuItem.Text = "信息补充(&U)";
			this.信息补充ToolStripMenuItem.Click += new System.EventHandler(this.信息补充ToolStripMenuItem_Click);
			// 
			// 账户挂失ToolStripMenuItem
			// 
			this.账户挂失ToolStripMenuItem.Name = "账户挂失ToolStripMenuItem";
			this.账户挂失ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.账户挂失ToolStripMenuItem.Text = "账户挂失(&F)";
			this.账户挂失ToolStripMenuItem.Click += new System.EventHandler(this.账户挂失ToolStripMenuItem_Click);
			// 
			// 账户明细打印ToolStripMenuItem
			// 
			this.账户明细打印ToolStripMenuItem.Name = "账户明细打印ToolStripMenuItem";
			this.账户明细打印ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.账户明细打印ToolStripMenuItem.Text = "账户明细打印(&T)";
			this.账户明细打印ToolStripMenuItem.Click += new System.EventHandler(this.账户明细打印ToolStripMenuItem_Click);
			// 
			// 账户销户ToolStripMenuItem
			// 
			this.账户销户ToolStripMenuItem.Name = "账户销户ToolStripMenuItem";
			this.账户销户ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.账户销户ToolStripMenuItem.Text = "账户销户(&D)";
			this.账户销户ToolStripMenuItem.Click += new System.EventHandler(this.账户销户ToolStripMenuItem_Click);
			// 
			// 资金业务ToolStripMenuItem
			// 
			this.资金业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.存款ToolStripMenuItem,
            this.取款ToolStripMenuItem,
            this.转账ToolStripMenuItem,
            this.余额查询ToolStripMenuItem});
			this.资金业务ToolStripMenuItem.Name = "资金业务ToolStripMenuItem";
			this.资金业务ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
			this.资金业务ToolStripMenuItem.Text = "资金业务(&Y)";
			// 
			// 存款ToolStripMenuItem
			// 
			this.存款ToolStripMenuItem.Name = "存款ToolStripMenuItem";
			this.存款ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.存款ToolStripMenuItem.Text = "存款业务(&S)";
			this.存款ToolStripMenuItem.Click += new System.EventHandler(this.存款ToolStripMenuItem_Click);
			// 
			// 取款ToolStripMenuItem
			// 
			this.取款ToolStripMenuItem.Name = "取款ToolStripMenuItem";
			this.取款ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.取款ToolStripMenuItem.Text = "取款业务(&T)";
			this.取款ToolStripMenuItem.Click += new System.EventHandler(this.取款ToolStripMenuItem_Click);
			// 
			// 转账ToolStripMenuItem
			// 
			this.转账ToolStripMenuItem.Name = "转账ToolStripMenuItem";
			this.转账ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.转账ToolStripMenuItem.Text = "转账业务(&A)";
			this.转账ToolStripMenuItem.Click += new System.EventHandler(this.转账ToolStripMenuItem_Click);
			// 
			// 余额查询ToolStripMenuItem
			// 
			this.余额查询ToolStripMenuItem.Name = "余额查询ToolStripMenuItem";
			this.余额查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.余额查询ToolStripMenuItem.Text = "余额查询(&B)";
			this.余额查询ToolStripMenuItem.Click += new System.EventHandler(this.余额查询ToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pcb_user
			// 
			this.pcb_user.BackColor = System.Drawing.Color.Transparent;
			this.pcb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcb_user.Location = new System.Drawing.Point(450, 39);
			this.pcb_user.Name = "pcb_user";
			this.pcb_user.Size = new System.Drawing.Size(154, 171);
			this.pcb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_user.TabIndex = 2;
			this.pcb_user.TabStop = false;
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.BackColor = System.Drawing.Color.Transparent;
			this.lbl_username.Location = new System.Drawing.Point(448, 276);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(29, 12);
			this.lbl_username.TabIndex = 3;
			this.lbl_username.Text = "姓名";
			// 
			// lbl_jobnum
			// 
			this.lbl_jobnum.AutoSize = true;
			this.lbl_jobnum.BackColor = System.Drawing.Color.Transparent;
			this.lbl_jobnum.Location = new System.Drawing.Point(448, 245);
			this.lbl_jobnum.Name = "lbl_jobnum";
			this.lbl_jobnum.Size = new System.Drawing.Size(29, 12);
			this.lbl_jobnum.TabIndex = 4;
			this.lbl_jobnum.Text = "工号";
			// 
			// lbl_sex
			// 
			this.lbl_sex.AutoSize = true;
			this.lbl_sex.BackColor = System.Drawing.Color.Transparent;
			this.lbl_sex.Location = new System.Drawing.Point(448, 311);
			this.lbl_sex.Name = "lbl_sex";
			this.lbl_sex.Size = new System.Drawing.Size(29, 12);
			this.lbl_sex.TabIndex = 5;
			this.lbl_sex.Text = "性别";
			// 
			// Frm_main
			// 
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.timg1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(629, 425);
			this.Controls.Add(this.lbl_sex);
			this.Controls.Add(this.lbl_jobnum);
			this.Controls.Add(this.lbl_username);
			this.Controls.Add(this.pcb_user);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Frm_main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "银行账户管理系统";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_main_FormClosed);
			this.Load += new System.EventHandler(this.Frm_main_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 账户业务ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 账户开户ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 账户信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 信息查看ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 信息补充ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 账户销户ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 账户明细打印ToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pcb_user;
		private System.Windows.Forms.Label lbl_username;
		private System.Windows.Forms.Label lbl_jobnum;
		private System.Windows.Forms.Label lbl_sex;
		private System.Windows.Forms.ToolStripMenuItem 账户挂失ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 资金业务ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 存款ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 取款ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 转账ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 余额查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 管理员菜单ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新柜员注册ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 管理系统ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;

	}
}