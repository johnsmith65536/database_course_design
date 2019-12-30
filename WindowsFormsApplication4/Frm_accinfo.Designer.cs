namespace WindowsFormsApplication4
{
	partial class Frm_accinfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_accinfo));
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_idcard = new System.Windows.Forms.Label();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_idcard = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(106, 122);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 3;
			this.btn_ok.Text = "确认(&O)";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(49, 87);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 12;
			this.lbl_pwd.Text = "开户密码";
			// 
			// lbl_idcard
			// 
			this.lbl_idcard.AutoSize = true;
			this.lbl_idcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_idcard.Location = new System.Drawing.Point(49, 42);
			this.lbl_idcard.Name = "lbl_idcard";
			this.lbl_idcard.Size = new System.Drawing.Size(53, 12);
			this.lbl_idcard.TabIndex = 11;
			this.lbl_idcard.Text = "身份证号";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(106, 84);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(133, 21);
			this.txt_pwd.TabIndex = 2;
			// 
			// txt_idcard
			// 
			this.txt_idcard.Location = new System.Drawing.Point(106, 39);
			this.txt_idcard.Name = "txt_idcard";
			this.txt_idcard.Size = new System.Drawing.Size(133, 21);
			this.txt_idcard.TabIndex = 1;
			// 
			// Frm_accinfo
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(284, 181);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_idcard);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_idcard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_accinfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "账户信息";
			this.Load += new System.EventHandler(this.Frm_accinfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_idcard;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_idcard;
	}
}