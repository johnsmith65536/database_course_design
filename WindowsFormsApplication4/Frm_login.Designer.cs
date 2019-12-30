namespace WindowsFormsApplication4
{
	partial class Frm_login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
			this.txt_user = new System.Windows.Forms.TextBox();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.lbl_user = new System.Windows.Forms.Label();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.btn_login = new System.Windows.Forms.Button();
			this.cbx_login = new System.Windows.Forms.ComboBox();
			this.lbl_type = new System.Windows.Forms.Label();
			this.lbl_code = new System.Windows.Forms.Label();
			this.pcb_code = new System.Windows.Forms.PictureBox();
			this.txt_code = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_code)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(150, 63);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(109, 21);
			this.txt_user.TabIndex = 1;
			this.txt_user.Text = "160001";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(150, 108);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(109, 21);
			this.txt_pwd.TabIndex = 2;
			this.txt_pwd.Text = "admin";
			// 
			// lbl_user
			// 
			this.lbl_user.AutoSize = true;
			this.lbl_user.BackColor = System.Drawing.Color.Transparent;
			this.lbl_user.Location = new System.Drawing.Point(93, 66);
			this.lbl_user.Name = "lbl_user";
			this.lbl_user.Size = new System.Drawing.Size(29, 12);
			this.lbl_user.TabIndex = 2;
			this.lbl_user.Text = "工号";
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(93, 111);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(29, 12);
			this.lbl_pwd.TabIndex = 3;
			this.lbl_pwd.Text = "密码";
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(150, 176);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 23);
			this.btn_login.TabIndex = 4;
			this.btn_login.Text = "登录(&L)";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// cbx_login
			// 
			this.cbx_login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_login.FormattingEnabled = true;
			this.cbx_login.Location = new System.Drawing.Point(150, 23);
			this.cbx_login.Name = "cbx_login";
			this.cbx_login.Size = new System.Drawing.Size(109, 20);
			this.cbx_login.TabIndex = 0;
			this.cbx_login.SelectedIndexChanged += new System.EventHandler(this.cbx_login_SelectedIndexChanged);
			// 
			// lbl_type
			// 
			this.lbl_type.AutoSize = true;
			this.lbl_type.BackColor = System.Drawing.Color.Transparent;
			this.lbl_type.Location = new System.Drawing.Point(93, 26);
			this.lbl_type.Name = "lbl_type";
			this.lbl_type.Size = new System.Drawing.Size(29, 12);
			this.lbl_type.TabIndex = 6;
			this.lbl_type.Text = "类型";
			// 
			// lbl_code
			// 
			this.lbl_code.AutoSize = true;
			this.lbl_code.BackColor = System.Drawing.Color.Transparent;
			this.lbl_code.Location = new System.Drawing.Point(93, 154);
			this.lbl_code.Name = "lbl_code";
			this.lbl_code.Size = new System.Drawing.Size(41, 12);
			this.lbl_code.TabIndex = 7;
			this.lbl_code.Text = "验证码";
			// 
			// pcb_code
			// 
			this.pcb_code.Location = new System.Drawing.Point(214, 148);
			this.pcb_code.Name = "pcb_code";
			this.pcb_code.Size = new System.Drawing.Size(45, 20);
			this.pcb_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_code.TabIndex = 8;
			this.pcb_code.TabStop = false;
			// 
			// txt_code
			// 
			this.txt_code.Location = new System.Drawing.Point(150, 147);
			this.txt_code.Name = "txt_code";
			this.txt_code.Size = new System.Drawing.Size(50, 21);
			this.txt_code.TabIndex = 3;
			// 
			// Frm_login
			// 
			this.AcceptButton = this.btn_login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.timg11;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(372, 224);
			this.Controls.Add(this.txt_code);
			this.Controls.Add(this.pcb_code);
			this.Controls.Add(this.lbl_code);
			this.Controls.Add(this.lbl_type);
			this.Controls.Add(this.cbx_login);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_user);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_user);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "银行账户管理系统登录";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_login_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_code)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Button btn_login;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.ComboBox cbx_login;
		private System.Windows.Forms.Label lbl_type;
		private System.Windows.Forms.Label lbl_code;
		private System.Windows.Forms.PictureBox pcb_code;
		public System.Windows.Forms.TextBox txt_code;
	}
}

