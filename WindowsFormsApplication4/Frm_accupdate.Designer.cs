namespace WindowsFormsApplication4
{
	partial class Frm_accupdate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_accupdate));
			this.txt_name = new System.Windows.Forms.TextBox();
			this.lbl_name = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.btn_picture = new System.Windows.Forms.Button();
			this.txt_phone = new System.Windows.Forms.TextBox();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.txt_idcard = new System.Windows.Forms.TextBox();
			this.lbl_picture = new System.Windows.Forms.Label();
			this.lbl_phone = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.lbl_idcard = new System.Windows.Forms.Label();
			this.txt_bnkcard = new System.Windows.Forms.TextBox();
			this.lbl_bnkcard = new System.Windows.Forms.Label();
			this.pcb_phone = new System.Windows.Forms.PictureBox();
			this.pcb_user = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_phone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(99, 39);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(204, 21);
			this.txt_name.TabIndex = 1;
			this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.BackColor = System.Drawing.Color.Transparent;
			this.lbl_name.Location = new System.Drawing.Point(28, 42);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(29, 12);
			this.lbl_name.TabIndex = 45;
			this.lbl_name.Text = "姓名";
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(228, 253);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(84, 23);
			this.btn_ok.TabIndex = 7;
			this.btn_ok.Text = "确认信息(&O)";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// btn_picture
			// 
			this.btn_picture.Location = new System.Drawing.Point(99, 196);
			this.btn_picture.Name = "btn_picture";
			this.btn_picture.Size = new System.Drawing.Size(88, 23);
			this.btn_picture.TabIndex = 6;
			this.btn_picture.Text = "更新图片...";
			this.btn_picture.UseVisualStyleBackColor = true;
			this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
			// 
			// txt_phone
			// 
			this.txt_phone.Location = new System.Drawing.Point(99, 164);
			this.txt_phone.Name = "txt_phone";
			this.txt_phone.Size = new System.Drawing.Size(204, 21);
			this.txt_phone.TabIndex = 5;
			this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
			this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(99, 128);
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(204, 21);
			this.txt_address.TabIndex = 4;
			// 
			// txt_idcard
			// 
			this.txt_idcard.Location = new System.Drawing.Point(99, 66);
			this.txt_idcard.Name = "txt_idcard";
			this.txt_idcard.Size = new System.Drawing.Size(204, 21);
			this.txt_idcard.TabIndex = 2;
			// 
			// lbl_picture
			// 
			this.lbl_picture.AutoSize = true;
			this.lbl_picture.BackColor = System.Drawing.Color.Transparent;
			this.lbl_picture.Location = new System.Drawing.Point(28, 201);
			this.lbl_picture.Name = "lbl_picture";
			this.lbl_picture.Size = new System.Drawing.Size(53, 12);
			this.lbl_picture.TabIndex = 29;
			this.lbl_picture.Text = "头像信息";
			// 
			// lbl_phone
			// 
			this.lbl_phone.AutoSize = true;
			this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
			this.lbl_phone.Location = new System.Drawing.Point(28, 167);
			this.lbl_phone.Name = "lbl_phone";
			this.lbl_phone.Size = new System.Drawing.Size(53, 12);
			this.lbl_phone.TabIndex = 27;
			this.lbl_phone.Text = "联系方式";
			// 
			// lbl_address
			// 
			this.lbl_address.AutoSize = true;
			this.lbl_address.BackColor = System.Drawing.Color.Transparent;
			this.lbl_address.Location = new System.Drawing.Point(28, 131);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(53, 12);
			this.lbl_address.TabIndex = 26;
			this.lbl_address.Text = "详细地址";
			// 
			// lbl_idcard
			// 
			this.lbl_idcard.AutoSize = true;
			this.lbl_idcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_idcard.Location = new System.Drawing.Point(28, 69);
			this.lbl_idcard.Name = "lbl_idcard";
			this.lbl_idcard.Size = new System.Drawing.Size(65, 12);
			this.lbl_idcard.TabIndex = 24;
			this.lbl_idcard.Text = "身份证号码";
			// 
			// txt_bnkcard
			// 
			this.txt_bnkcard.Location = new System.Drawing.Point(99, 95);
			this.txt_bnkcard.Name = "txt_bnkcard";
			this.txt_bnkcard.Size = new System.Drawing.Size(204, 21);
			this.txt_bnkcard.TabIndex = 3;
			// 
			// lbl_bnkcard
			// 
			this.lbl_bnkcard.AutoSize = true;
			this.lbl_bnkcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bnkcard.Location = new System.Drawing.Point(28, 98);
			this.lbl_bnkcard.Name = "lbl_bnkcard";
			this.lbl_bnkcard.Size = new System.Drawing.Size(53, 12);
			this.lbl_bnkcard.TabIndex = 47;
			this.lbl_bnkcard.Text = "银行卡号";
			// 
			// pcb_phone
			// 
			this.pcb_phone.Image = ((System.Drawing.Image)(resources.GetObject("pcb_phone.Image")));
			this.pcb_phone.Location = new System.Drawing.Point(309, 167);
			this.pcb_phone.Name = "pcb_phone";
			this.pcb_phone.Size = new System.Drawing.Size(15, 15);
			this.pcb_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_phone.TabIndex = 42;
			this.pcb_phone.TabStop = false;
			this.pcb_phone.Visible = false;
			// 
			// pcb_user
			// 
			this.pcb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcb_user.Location = new System.Drawing.Point(373, 39);
			this.pcb_user.Name = "pcb_user";
			this.pcb_user.Size = new System.Drawing.Size(154, 171);
			this.pcb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_user.TabIndex = 38;
			this.pcb_user.TabStop = false;
			// 
			// Frm_accupdate
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(555, 302);
			this.Controls.Add(this.txt_bnkcard);
			this.Controls.Add(this.lbl_bnkcard);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.pcb_phone);
			this.Controls.Add(this.pcb_user);
			this.Controls.Add(this.btn_picture);
			this.Controls.Add(this.txt_phone);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.txt_idcard);
			this.Controls.Add(this.lbl_picture);
			this.Controls.Add(this.lbl_phone);
			this.Controls.Add(this.lbl_address);
			this.Controls.Add(this.lbl_idcard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_accupdate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "信息补充";
			this.Load += new System.EventHandler(this.Frm_accupdate_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_phone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcb_user)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.PictureBox pcb_phone;
		private System.Windows.Forms.Button btn_picture;
		private System.Windows.Forms.Label lbl_picture;
		private System.Windows.Forms.Label lbl_phone;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label lbl_idcard;
		public System.Windows.Forms.TextBox txt_name;
		public System.Windows.Forms.PictureBox pcb_user;
		public System.Windows.Forms.TextBox txt_phone;
		public System.Windows.Forms.TextBox txt_address;
		public System.Windows.Forms.TextBox txt_idcard;
		public System.Windows.Forms.TextBox txt_bnkcard;
		private System.Windows.Forms.Label lbl_bnkcard;


	}
}