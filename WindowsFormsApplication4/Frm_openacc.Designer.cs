namespace WindowsFormsApplication4
{
	partial class Frm_openacc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_openacc));
			this.lbl_idcard = new System.Windows.Forms.Label();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.lbl_phone = new System.Windows.Forms.Label();
			this.lbl_money = new System.Windows.Forms.Label();
			this.lbl_picture = new System.Windows.Forms.Label();
			this.txt_idcard = new System.Windows.Forms.TextBox();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.txt_phone = new System.Windows.Forms.TextBox();
			this.txt_money = new System.Windows.Forms.TextBox();
			this.btn_picture = new System.Windows.Forms.Button();
			this.txt_pwdrep = new System.Windows.Forms.TextBox();
			this.lbl_pwdrep = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.lbl_name = new System.Windows.Forms.Label();
			this.pcb_money = new System.Windows.Forms.PictureBox();
			this.pcb_phone = new System.Windows.Forms.PictureBox();
			this.pcb_pwdrep = new System.Windows.Forms.PictureBox();
			this.pcb_pwd = new System.Windows.Forms.PictureBox();
			this.pcb_idcard = new System.Windows.Forms.PictureBox();
			this.pcb_user = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_money)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_phone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwdrep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_idcard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_idcard
			// 
			this.lbl_idcard.AutoSize = true;
			this.lbl_idcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_idcard.Location = new System.Drawing.Point(44, 84);
			this.lbl_idcard.Name = "lbl_idcard";
			this.lbl_idcard.Size = new System.Drawing.Size(65, 12);
			this.lbl_idcard.TabIndex = 0;
			this.lbl_idcard.Text = "身份证号码";
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(44, 118);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 1;
			this.lbl_pwd.Text = "开户密码";
			// 
			// lbl_address
			// 
			this.lbl_address.AutoSize = true;
			this.lbl_address.BackColor = System.Drawing.Color.Transparent;
			this.lbl_address.Location = new System.Drawing.Point(44, 176);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(53, 12);
			this.lbl_address.TabIndex = 2;
			this.lbl_address.Text = "详细地址";
			// 
			// lbl_phone
			// 
			this.lbl_phone.AutoSize = true;
			this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
			this.lbl_phone.Location = new System.Drawing.Point(44, 212);
			this.lbl_phone.Name = "lbl_phone";
			this.lbl_phone.Size = new System.Drawing.Size(53, 12);
			this.lbl_phone.TabIndex = 3;
			this.lbl_phone.Text = "联系方式";
			// 
			// lbl_money
			// 
			this.lbl_money.AutoSize = true;
			this.lbl_money.BackColor = System.Drawing.Color.Transparent;
			this.lbl_money.Location = new System.Drawing.Point(44, 247);
			this.lbl_money.Name = "lbl_money";
			this.lbl_money.Size = new System.Drawing.Size(53, 12);
			this.lbl_money.TabIndex = 4;
			this.lbl_money.Text = "开户金额";
			// 
			// lbl_picture
			// 
			this.lbl_picture.AutoSize = true;
			this.lbl_picture.BackColor = System.Drawing.Color.Transparent;
			this.lbl_picture.Location = new System.Drawing.Point(44, 279);
			this.lbl_picture.Name = "lbl_picture";
			this.lbl_picture.Size = new System.Drawing.Size(53, 12);
			this.lbl_picture.TabIndex = 5;
			this.lbl_picture.Text = "头像信息";
			// 
			// txt_idcard
			// 
			this.txt_idcard.Location = new System.Drawing.Point(115, 81);
			this.txt_idcard.Name = "txt_idcard";
			this.txt_idcard.Size = new System.Drawing.Size(204, 21);
			this.txt_idcard.TabIndex = 2;
			this.txt_idcard.TextChanged += new System.EventHandler(this.txt_idcard_TextChanged);
			this.txt_idcard.Leave += new System.EventHandler(this.txt_idcard_Leave);
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(115, 115);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(204, 21);
			this.txt_pwd.TabIndex = 3;
			this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
			this.txt_pwd.Leave += new System.EventHandler(this.txt_pwd_Leave);
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(115, 173);
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(204, 21);
			this.txt_address.TabIndex = 5;
			// 
			// txt_phone
			// 
			this.txt_phone.Location = new System.Drawing.Point(115, 209);
			this.txt_phone.Name = "txt_phone";
			this.txt_phone.Size = new System.Drawing.Size(204, 21);
			this.txt_phone.TabIndex = 6;
			this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
			this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
			// 
			// txt_money
			// 
			this.txt_money.Location = new System.Drawing.Point(115, 244);
			this.txt_money.Name = "txt_money";
			this.txt_money.Size = new System.Drawing.Size(204, 21);
			this.txt_money.TabIndex = 7;
			this.txt_money.TextChanged += new System.EventHandler(this.txt_money_TextChanged);
			this.txt_money.Leave += new System.EventHandler(this.txt_money_Leave);
			// 
			// btn_picture
			// 
			this.btn_picture.Location = new System.Drawing.Point(115, 274);
			this.btn_picture.Name = "btn_picture";
			this.btn_picture.Size = new System.Drawing.Size(88, 23);
			this.btn_picture.TabIndex = 8;
			this.btn_picture.Text = "选择图片...";
			this.btn_picture.UseVisualStyleBackColor = true;
			this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
			// 
			// txt_pwdrep
			// 
			this.txt_pwdrep.Location = new System.Drawing.Point(115, 146);
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
			this.lbl_pwdrep.Location = new System.Drawing.Point(44, 149);
			this.lbl_pwdrep.Name = "lbl_pwdrep";
			this.lbl_pwdrep.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwdrep.TabIndex = 12;
			this.lbl_pwdrep.Text = "确认密码";
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(256, 313);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(84, 23);
			this.btn_ok.TabIndex = 9;
			this.btn_ok.Text = "确认开户(&O)";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(115, 54);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(204, 21);
			this.txt_name.TabIndex = 1;
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.BackColor = System.Drawing.Color.Transparent;
			this.lbl_name.Location = new System.Drawing.Point(44, 57);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(29, 12);
			this.lbl_name.TabIndex = 22;
			this.lbl_name.Text = "姓名";
			// 
			// pcb_money
			// 
			this.pcb_money.Image = ((System.Drawing.Image)(resources.GetObject("pcb_money.Image")));
			this.pcb_money.Location = new System.Drawing.Point(325, 247);
			this.pcb_money.Name = "pcb_money";
			this.pcb_money.Size = new System.Drawing.Size(15, 15);
			this.pcb_money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_money.TabIndex = 20;
			this.pcb_money.TabStop = false;
			this.pcb_money.Visible = false;
			// 
			// pcb_phone
			// 
			this.pcb_phone.Image = ((System.Drawing.Image)(resources.GetObject("pcb_phone.Image")));
			this.pcb_phone.Location = new System.Drawing.Point(325, 212);
			this.pcb_phone.Name = "pcb_phone";
			this.pcb_phone.Size = new System.Drawing.Size(15, 15);
			this.pcb_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_phone.TabIndex = 19;
			this.pcb_phone.TabStop = false;
			this.pcb_phone.Visible = false;
			// 
			// pcb_pwdrep
			// 
			this.pcb_pwdrep.Image = ((System.Drawing.Image)(resources.GetObject("pcb_pwdrep.Image")));
			this.pcb_pwdrep.Location = new System.Drawing.Point(325, 149);
			this.pcb_pwdrep.Name = "pcb_pwdrep";
			this.pcb_pwdrep.Size = new System.Drawing.Size(15, 15);
			this.pcb_pwdrep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_pwdrep.TabIndex = 18;
			this.pcb_pwdrep.TabStop = false;
			this.pcb_pwdrep.Visible = false;
			// 
			// pcb_pwd
			// 
			this.pcb_pwd.Image = ((System.Drawing.Image)(resources.GetObject("pcb_pwd.Image")));
			this.pcb_pwd.Location = new System.Drawing.Point(325, 118);
			this.pcb_pwd.Name = "pcb_pwd";
			this.pcb_pwd.Size = new System.Drawing.Size(15, 15);
			this.pcb_pwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_pwd.TabIndex = 17;
			this.pcb_pwd.TabStop = false;
			this.pcb_pwd.Visible = false;
			// 
			// pcb_idcard
			// 
			this.pcb_idcard.Image = ((System.Drawing.Image)(resources.GetObject("pcb_idcard.Image")));
			this.pcb_idcard.Location = new System.Drawing.Point(325, 84);
			this.pcb_idcard.Name = "pcb_idcard";
			this.pcb_idcard.Size = new System.Drawing.Size(15, 15);
			this.pcb_idcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_idcard.TabIndex = 16;
			this.pcb_idcard.TabStop = false;
			this.pcb_idcard.Visible = false;
			// 
			// pcb_user
			// 
			this.pcb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcb_user.Location = new System.Drawing.Point(389, 81);
			this.pcb_user.Name = "pcb_user";
			this.pcb_user.Size = new System.Drawing.Size(154, 171);
			this.pcb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_user.TabIndex = 14;
			this.pcb_user.TabStop = false;
			// 
			// Frm_openacc
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.timg11;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(555, 360);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.pcb_money);
			this.Controls.Add(this.pcb_phone);
			this.Controls.Add(this.pcb_pwdrep);
			this.Controls.Add(this.pcb_pwd);
			this.Controls.Add(this.pcb_idcard);
			this.Controls.Add(this.pcb_user);
			this.Controls.Add(this.txt_pwdrep);
			this.Controls.Add(this.lbl_pwdrep);
			this.Controls.Add(this.btn_picture);
			this.Controls.Add(this.txt_money);
			this.Controls.Add(this.txt_phone);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_idcard);
			this.Controls.Add(this.lbl_picture);
			this.Controls.Add(this.lbl_money);
			this.Controls.Add(this.lbl_phone);
			this.Controls.Add(this.lbl_address);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_idcard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_openacc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "账户开户";
			this.Load += new System.EventHandler(this.Frm_openacc_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_money)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_phone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwdrep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_pwd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_idcard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_idcard;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label lbl_phone;
		private System.Windows.Forms.Label lbl_money;
		private System.Windows.Forms.Label lbl_picture;
		private System.Windows.Forms.TextBox txt_idcard;
		private System.Windows.Forms.TextBox txt_pwd;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.TextBox txt_phone;
		private System.Windows.Forms.TextBox txt_money;
		private System.Windows.Forms.Button btn_picture;
		private System.Windows.Forms.TextBox txt_pwdrep;
		private System.Windows.Forms.Label lbl_pwdrep;
		private System.Windows.Forms.PictureBox pcb_user;
		private System.Windows.Forms.PictureBox pcb_idcard;
		private System.Windows.Forms.PictureBox pcb_pwd;
		private System.Windows.Forms.PictureBox pcb_pwdrep;
		private System.Windows.Forms.PictureBox pcb_phone;
		private System.Windows.Forms.PictureBox pcb_money;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label lbl_name;
	}
}