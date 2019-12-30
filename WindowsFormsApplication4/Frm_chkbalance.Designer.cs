namespace WindowsFormsApplication4
{
	partial class Frm_chkbalance
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_chkbalance));
			this.lbl_balance = new System.Windows.Forms.Label();
			this.txt_balance = new System.Windows.Forms.TextBox();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_bnkcard = new System.Windows.Forms.Label();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_bnkcard = new System.Windows.Forms.TextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_balance
			// 
			this.lbl_balance.AutoSize = true;
			this.lbl_balance.BackColor = System.Drawing.Color.Transparent;
			this.lbl_balance.Location = new System.Drawing.Point(37, 84);
			this.lbl_balance.Name = "lbl_balance";
			this.lbl_balance.Size = new System.Drawing.Size(53, 12);
			this.lbl_balance.TabIndex = 29;
			this.lbl_balance.Text = "账户余额";
			// 
			// txt_balance
			// 
			this.txt_balance.Enabled = false;
			this.txt_balance.Location = new System.Drawing.Point(94, 81);
			this.txt_balance.Name = "txt_balance";
			this.txt_balance.Size = new System.Drawing.Size(133, 21);
			this.txt_balance.TabIndex = 0;
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(37, 115);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 27;
			this.lbl_pwd.Text = "开户密码";
			// 
			// lbl_bnkcard
			// 
			this.lbl_bnkcard.AutoSize = true;
			this.lbl_bnkcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bnkcard.Location = new System.Drawing.Point(37, 84);
			this.lbl_bnkcard.Name = "lbl_bnkcard";
			this.lbl_bnkcard.Size = new System.Drawing.Size(29, 12);
			this.lbl_bnkcard.TabIndex = 26;
			this.lbl_bnkcard.Text = "卡号";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(94, 112);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(133, 21);
			this.txt_pwd.TabIndex = 1;
			// 
			// txt_bnkcard
			// 
			this.txt_bnkcard.Location = new System.Drawing.Point(94, 80);
			this.txt_bnkcard.Name = "txt_bnkcard";
			this.txt_bnkcard.Size = new System.Drawing.Size(133, 21);
			this.txt_bnkcard.TabIndex = 24;
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(105, 158);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "button1";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// Frm_chkbalance
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.timg11;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(283, 238);
			this.Controls.Add(this.lbl_balance);
			this.Controls.Add(this.txt_balance);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_bnkcard);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_bnkcard);
			this.Controls.Add(this.btn_ok);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_chkbalance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "余额查询";
			this.Load += new System.EventHandler(this.Frm_chkbalance_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_balance;
		public System.Windows.Forms.TextBox txt_balance;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_bnkcard;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_bnkcard;
		private System.Windows.Forms.Button btn_ok;
	}
}