namespace WindowsFormsApplication4
{
	partial class Frm_takeout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_takeout));
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_bnkcard = new System.Windows.Forms.Label();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_bnkcard = new System.Windows.Forms.TextBox();
			this.lbl_balance = new System.Windows.Forms.Label();
			this.txt_balance = new System.Windows.Forms.TextBox();
			this.lbl_takeout = new System.Windows.Forms.Label();
			this.txt_takeout = new System.Windows.Forms.TextBox();
			this.pcb_takeout = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_takeout)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(106, 125);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 3;
			this.btn_ok.Text = "button1";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_pwd
			// 
			this.lbl_pwd.AutoSize = true;
			this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_pwd.Location = new System.Drawing.Point(38, 82);
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.Size = new System.Drawing.Size(53, 12);
			this.lbl_pwd.TabIndex = 16;
			this.lbl_pwd.Text = "开户密码";
			// 
			// lbl_bnkcard
			// 
			this.lbl_bnkcard.AutoSize = true;
			this.lbl_bnkcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bnkcard.Location = new System.Drawing.Point(38, 51);
			this.lbl_bnkcard.Name = "lbl_bnkcard";
			this.lbl_bnkcard.Size = new System.Drawing.Size(29, 12);
			this.lbl_bnkcard.TabIndex = 15;
			this.lbl_bnkcard.Text = "卡号";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(95, 79);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(133, 21);
			this.txt_pwd.TabIndex = 14;
			// 
			// txt_bnkcard
			// 
			this.txt_bnkcard.Location = new System.Drawing.Point(95, 47);
			this.txt_bnkcard.Name = "txt_bnkcard";
			this.txt_bnkcard.Size = new System.Drawing.Size(133, 21);
			this.txt_bnkcard.TabIndex = 13;
			// 
			// lbl_balance
			// 
			this.lbl_balance.AutoSize = true;
			this.lbl_balance.BackColor = System.Drawing.Color.Transparent;
			this.lbl_balance.Location = new System.Drawing.Point(38, 51);
			this.lbl_balance.Name = "lbl_balance";
			this.lbl_balance.Size = new System.Drawing.Size(53, 12);
			this.lbl_balance.TabIndex = 18;
			this.lbl_balance.Text = "账户余额";
			// 
			// txt_balance
			// 
			this.txt_balance.Enabled = false;
			this.txt_balance.Location = new System.Drawing.Point(95, 48);
			this.txt_balance.Name = "txt_balance";
			this.txt_balance.Size = new System.Drawing.Size(133, 21);
			this.txt_balance.TabIndex = 1;
			this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
			// 
			// lbl_takeout
			// 
			this.lbl_takeout.AutoSize = true;
			this.lbl_takeout.BackColor = System.Drawing.Color.Transparent;
			this.lbl_takeout.Location = new System.Drawing.Point(38, 83);
			this.lbl_takeout.Name = "lbl_takeout";
			this.lbl_takeout.Size = new System.Drawing.Size(53, 12);
			this.lbl_takeout.TabIndex = 20;
			this.lbl_takeout.Text = "取出金额";
			// 
			// txt_takeout
			// 
			this.txt_takeout.Location = new System.Drawing.Point(95, 80);
			this.txt_takeout.Name = "txt_takeout";
			this.txt_takeout.Size = new System.Drawing.Size(133, 21);
			this.txt_takeout.TabIndex = 2;
			this.txt_takeout.Leave += new System.EventHandler(this.txt_takeout_Leave);
			// 
			// pcb_takeout
			// 
			this.pcb_takeout.Image = ((System.Drawing.Image)(resources.GetObject("pcb_takeout.Image")));
			this.pcb_takeout.Location = new System.Drawing.Point(234, 83);
			this.pcb_takeout.Name = "pcb_takeout";
			this.pcb_takeout.Size = new System.Drawing.Size(15, 15);
			this.pcb_takeout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_takeout.TabIndex = 22;
			this.pcb_takeout.TabStop = false;
			this.pcb_takeout.Visible = false;
			// 
			// Frm_takeout
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(298, 185);
			this.Controls.Add(this.pcb_takeout);
			this.Controls.Add(this.lbl_takeout);
			this.Controls.Add(this.txt_takeout);
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
			this.Name = "Frm_takeout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "现金取出";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_takeout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lbl_pwd;
		private System.Windows.Forms.Label lbl_bnkcard;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_bnkcard;
		private System.Windows.Forms.Label lbl_balance;
		public System.Windows.Forms.TextBox txt_balance;
		private System.Windows.Forms.Label lbl_takeout;
		public System.Windows.Forms.TextBox txt_takeout;
		private System.Windows.Forms.PictureBox pcb_takeout;
	}
}