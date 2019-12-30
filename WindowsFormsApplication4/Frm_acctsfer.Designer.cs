namespace WindowsFormsApplication4
{
	partial class Frm_acctsfer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_acctsfer));
			this.lbl_takeout = new System.Windows.Forms.Label();
			this.txt_takeout = new System.Windows.Forms.TextBox();
			this.lbl_balance = new System.Windows.Forms.Label();
			this.txt_balance = new System.Windows.Forms.TextBox();
			this.lbl_pwd = new System.Windows.Forms.Label();
			this.lbl_fromcard = new System.Windows.Forms.Label();
			this.txt_pwd = new System.Windows.Forms.TextBox();
			this.txt_fromcard = new System.Windows.Forms.TextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_tocard = new System.Windows.Forms.Label();
			this.txt_tocard = new System.Windows.Forms.TextBox();
			this.pcb_takeout = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_takeout)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_takeout
			// 
			this.lbl_takeout.AutoSize = true;
			this.lbl_takeout.BackColor = System.Drawing.Color.Transparent;
			this.lbl_takeout.Location = new System.Drawing.Point(37, 153);
			this.lbl_takeout.Name = "lbl_takeout";
			this.lbl_takeout.Size = new System.Drawing.Size(53, 12);
			this.lbl_takeout.TabIndex = 31;
			this.lbl_takeout.Text = "转账金额";
			// 
			// txt_takeout
			// 
			this.txt_takeout.Location = new System.Drawing.Point(94, 150);
			this.txt_takeout.Name = "txt_takeout";
			this.txt_takeout.Size = new System.Drawing.Size(133, 21);
			this.txt_takeout.TabIndex = 4;
			this.txt_takeout.Leave += new System.EventHandler(this.txt_takeout_Leave);
			// 
			// lbl_balance
			// 
			this.lbl_balance.AutoSize = true;
			this.lbl_balance.BackColor = System.Drawing.Color.Transparent;
			this.lbl_balance.Location = new System.Drawing.Point(37, 83);
			this.lbl_balance.Name = "lbl_balance";
			this.lbl_balance.Size = new System.Drawing.Size(53, 12);
			this.lbl_balance.TabIndex = 29;
			this.lbl_balance.Text = "账户余额";
			// 
			// txt_balance
			// 
			this.txt_balance.Enabled = false;
			this.txt_balance.Location = new System.Drawing.Point(94, 80);
			this.txt_balance.Name = "txt_balance";
			this.txt_balance.Size = new System.Drawing.Size(133, 21);
			this.txt_balance.TabIndex = 28;
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
			// lbl_fromcard
			// 
			this.lbl_fromcard.AutoSize = true;
			this.lbl_fromcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_fromcard.Location = new System.Drawing.Point(37, 84);
			this.lbl_fromcard.Name = "lbl_fromcard";
			this.lbl_fromcard.Size = new System.Drawing.Size(53, 12);
			this.lbl_fromcard.TabIndex = 26;
			this.lbl_fromcard.Text = "转出卡号";
			// 
			// txt_pwd
			// 
			this.txt_pwd.Location = new System.Drawing.Point(94, 112);
			this.txt_pwd.Name = "txt_pwd";
			this.txt_pwd.PasswordChar = '*';
			this.txt_pwd.Size = new System.Drawing.Size(133, 21);
			this.txt_pwd.TabIndex = 2;
			// 
			// txt_fromcard
			// 
			this.txt_fromcard.Location = new System.Drawing.Point(94, 80);
			this.txt_fromcard.Name = "txt_fromcard";
			this.txt_fromcard.Size = new System.Drawing.Size(133, 21);
			this.txt_fromcard.TabIndex = 1;
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(106, 200);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 5;
			this.btn_ok.Text = "button1";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// lbl_tocard
			// 
			this.lbl_tocard.AutoSize = true;
			this.lbl_tocard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tocard.Location = new System.Drawing.Point(37, 115);
			this.lbl_tocard.Name = "lbl_tocard";
			this.lbl_tocard.Size = new System.Drawing.Size(53, 12);
			this.lbl_tocard.TabIndex = 34;
			this.lbl_tocard.Text = "转入卡号";
			// 
			// txt_tocard
			// 
			this.txt_tocard.Location = new System.Drawing.Point(94, 112);
			this.txt_tocard.Name = "txt_tocard";
			this.txt_tocard.Size = new System.Drawing.Size(133, 21);
			this.txt_tocard.TabIndex = 3;
			// 
			// pcb_takeout
			// 
			this.pcb_takeout.Image = ((System.Drawing.Image)(resources.GetObject("pcb_takeout.Image")));
			this.pcb_takeout.Location = new System.Drawing.Point(233, 153);
			this.pcb_takeout.Name = "pcb_takeout";
			this.pcb_takeout.Size = new System.Drawing.Size(15, 15);
			this.pcb_takeout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_takeout.TabIndex = 32;
			this.pcb_takeout.TabStop = false;
			this.pcb_takeout.Visible = false;
			// 
			// Frm_acctsfer
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_tocard);
			this.Controls.Add(this.txt_tocard);
			this.Controls.Add(this.pcb_takeout);
			this.Controls.Add(this.lbl_takeout);
			this.Controls.Add(this.txt_takeout);
			this.Controls.Add(this.lbl_balance);
			this.Controls.Add(this.txt_balance);
			this.Controls.Add(this.lbl_pwd);
			this.Controls.Add(this.lbl_fromcard);
			this.Controls.Add(this.txt_pwd);
			this.Controls.Add(this.txt_fromcard);
			this.Controls.Add(this.btn_ok);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_acctsfer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "转账";
			this.Load += new System.EventHandler(this.Frm_acctsfer_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_takeout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txt_takeout;
		public System.Windows.Forms.TextBox txt_balance;
		public System.Windows.Forms.TextBox txt_pwd;
		public System.Windows.Forms.TextBox txt_fromcard;
		public System.Windows.Forms.TextBox txt_tocard;
		public System.Windows.Forms.PictureBox pcb_takeout;
		public System.Windows.Forms.Label lbl_takeout;
		public System.Windows.Forms.Label lbl_balance;
		public System.Windows.Forms.Label lbl_pwd;
		public System.Windows.Forms.Label lbl_fromcard;
		public System.Windows.Forms.Button btn_ok;
		public System.Windows.Forms.Label lbl_tocard;
	}
}