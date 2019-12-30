namespace WindowsFormsApplication4
{
	partial class Frm_openuser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_openuser));
			this.txt_name = new System.Windows.Forms.TextBox();
			this.lbl_name = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.txt_pwdrep = new System.Windows.Forms.TextBox();
			this.lbl_pwdrep = new System.Windows.Forms.Label();
			this.btn_picture = new System.Windows.Forms.Button();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.lbl_picture = new System.Windows.Forms.Label();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_sex = new System.Windows.Forms.Label();
			this.cbx_sex = new System.Windows.Forms.ComboBox();
			this.pcb_pwdrep = new System.Windows.Forms.PictureBox();
			this.pcb_user = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwdrep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(104, 75);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(204, 21);
			this.txt_name.TabIndex = 1;
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.BackColor = System.Drawing.Color.Transparent;
			this.lbl_name.Location = new System.Drawing.Point(33, 78);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(29, 12);
			this.lbl_name.TabIndex = 45;
			this.lbl_name.Text = "姓名";
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(243, 266);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(86, 23);
			this.btn_ok.TabIndex = 6;
			this.btn_ok.Text = "确认开户(&O)";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// txt_pwdrep
			// 
			this.txt_pwdrep.Location = new System.Drawing.Point(104, 167);
			this.txt_pwdrep.Name = "txt_pwdrep";
			this.txt_pwdrep.PasswordChar = '*';
			this.txt_pwdrep.Size = new System.Drawing.Size(204, 21);
			this.txt_pwdrep.TabIndex = 4;
			this.txt_pwdrep.Leave += new System.EventHandler(this.txt_pwdrep_Leave);
			// 
			// lbl_pwdrep
			// 
			this.lbl_pwdrep.AutoSize = true;
			this.lbl_pwdrep.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwdrep.Location = new System.Drawing.Point(33, 170);
			this.lbl_pwdrep.Name = "lbl_pwdrep";
			this.lbl_pwdrep.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwdrep.TabIndex = 36;
			this.lbl_pwdrep.Text = "确认密码";
			// 
			// btn_picture
			// 
			this.btn_picture.Location = new System.Drawing.Point(104, 205);
			this.btn_picture.Name = "btn_picture";
			this.btn_picture.Size = new System.Drawing.Size(88, 23);
			this.btn_picture.TabIndex = 5;
			this.btn_picture.Text = "选择图片...";
			this.btn_picture.UseVisualStyleBackColor = true;
			this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(104, 136);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(204, 21);
			this.txt_pwd.TabIndex = 3;
			// 
			// lbl_picture
			// 
			this.lbl_picture.AutoSize = true;
			this.lbl_picture.BackColor = System.Drawing.Color.Transparent;
			this.lbl_picture.Location = new System.Drawing.Point(33, 210);
			this.lbl_picture.Name = "lbl_picture";
			this.lbl_picture.Size = new System.Drawing.Size(53, 12);
			this.lbl_picture.TabIndex = 29;
			this.lbl_picture.Text = "头像信息";
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(33, 139);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 25;
			this.lbl_pwd.Text = "登录密码";
			this.lbl_pwd.Click += new System.EventHandler(this.lbl_pwd_Click);
			// 
			// lbl_sex
			// 
			this.lbl_sex.AutoSize = true;
			this.lbl_sex.BackColor = System.Drawing.Color.Transparent;
			this.lbl_sex.Location = new System.Drawing.Point(33, 112);
			this.lbl_sex.Name = "lbl_sex";
			this.lbl_sex.Size = new System.Drawing.Size(29, 12);
			this.lbl_sex.TabIndex = 47;
			this.lbl_sex.Text = "姓名";
			// 
			// cbx_sex
			// 
			this.cbx_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_sex.FormattingEnabled = true;
			this.cbx_sex.Location = new System.Drawing.Point(104, 109);
			this.cbx_sex.Name = "cbx_sex";
			this.cbx_sex.Size = new System.Drawing.Size(53, 20);
			this.cbx_sex.TabIndex = 2;
			// 
			// pcb_pwdrep
			// 
			this.pcb_pwdrep.Image = ((System.Drawing.Image)(resources.GetObject("pcb_pwdrep.Image")));
			this.pcb_pwdrep.Location = new System.Drawing.Point(314, 170);
			this.pcb_pwdrep.Name = "pcb_pwdrep";
			this.pcb_pwdrep.Size = new System.Drawing.Size(15, 15);
			this.pcb_pwdrep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_pwdrep.TabIndex = 41;
			this.pcb_pwdrep.TabStop = false;
			this.pcb_pwdrep.Visible = false;
			// 
			// pcb_user
			// 
			this.pcb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcb_user.Location = new System.Drawing.Point(378, 76);
			this.pcb_user.Name = "pcb_user";
			this.pcb_user.Size = new System.Drawing.Size(154, 171);
			this.pcb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_user.TabIndex = 38;
			this.pcb_user.TabStop = false;
			// 
			// Frm_openuser
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(567, 324);
			this.Controls.Add(this.cbx_sex);
			this.Controls.Add(this.lbl_sex);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.pcb_pwdrep);
			this.Controls.Add(this.pcb_user);
			this.Controls.Add(this.txt_pwdrep);
			this.Controls.Add(this.lbl_pwdrep);
			this.Controls.Add(this.btn_picture);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.lbl_picture);
			this.Controls.Add(this.lbl_pwd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_openuser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "柜员注册";
			this.Load += new System.EventHandler(this.Frm_openuser_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwdrep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.PictureBox pcb_pwdrep;
		private System.Windows.Forms.PictureBox pcb_user;
		private System.Windows.Forms.TextBox txt_pwdrep;
		private System.Windows.Forms.Label lbl_pwdrep;
		private System.Windows.Forms.Button btn_picture;
		private System.Windows.Forms.TextBox txt_pwd;
		private System.Windows.Forms.Label lbl_picture;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_sex;
		private System.Windows.Forms.ComboBox cbx_sex;
	}
}