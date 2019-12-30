namespace WindowsFormsApplication4
{
	partial class Frm_cardinfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cardinfo));
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_bnkcard = new System.Windows.Forms.Label();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_bnkcard = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(104, 160);
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
			this.lbl_pwd.Location = new System.Drawing.Point(47, 125);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 17;
			this.lbl_pwd.Text = "开户密码";
			// 
			// lbl_bnkcard
			// 
			this.lbl_bnkcard.AutoSize = true;
			this.lbl_bnkcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bnkcard.Location = new System.Drawing.Point(47, 80);
			this.lbl_bnkcard.Name = "lbl_bnkcard";
			this.lbl_bnkcard.Size = new System.Drawing.Size(29, 12);
			this.lbl_bnkcard.TabIndex = 16;
			this.lbl_bnkcard.Text = "卡号";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(104, 122);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(133, 21);
			this.txt_pwd.TabIndex = 2;
			// 
			// txt_bnkcard
			// 
			this.txt_bnkcard.Location = new System.Drawing.Point(104, 77);
			this.txt_bnkcard.Name = "txt_bnkcard";
			this.txt_bnkcard.Size = new System.Drawing.Size(133, 21);
			this.txt_bnkcard.TabIndex = 1;
			// 
			// Frm_cardinfo
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_bnkcard);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_bnkcard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_cardinfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "账号信息";
			this.Load += new System.EventHandler(this.Frm_cardinfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_bnkcard;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_bnkcard;
	}
}