namespace WindowsFormsApplication4
{
	partial class Frm_savemoney
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_savemoney));
			this.lbl_bnkcard = new System.Windows.Forms.Label();
			this.lbl_money = new System.Windows.Forms.Label();
			this.txt_bnkcard = new System.Windows.Forms.TextBox();
			this.txt_money = new System.Windows.Forms.TextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.pcb_money = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_money)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_bnkcard
			// 
			this.lbl_bnkcard.AutoSize = true;
			this.lbl_bnkcard.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bnkcard.Location = new System.Drawing.Point(48, 59);
			this.lbl_bnkcard.Name = "lbl_bnkcard";
			this.lbl_bnkcard.Size = new System.Drawing.Size(53, 12);
			this.lbl_bnkcard.TabIndex = 0;
			this.lbl_bnkcard.Text = "银行卡号";
			// 
			// lbl_money
			// 
			this.lbl_money.AutoSize = true;
			this.lbl_money.BackColor = System.Drawing.Color.Transparent;
			this.lbl_money.Location = new System.Drawing.Point(48, 105);
			this.lbl_money.Name = "lbl_money";
			this.lbl_money.Size = new System.Drawing.Size(53, 12);
			this.lbl_money.TabIndex = 1;
			this.lbl_money.Text = "存入金额";
			// 
			// txt_bnkcard
			// 
			this.txt_bnkcard.Location = new System.Drawing.Point(107, 56);
			this.txt_bnkcard.Name = "txt_bnkcard";
			this.txt_bnkcard.Size = new System.Drawing.Size(100, 21);
			this.txt_bnkcard.TabIndex = 1;
			// 
			// txt_money
			// 
			this.txt_money.Location = new System.Drawing.Point(107, 102);
			this.txt_money.Name = "txt_money";
			this.txt_money.Size = new System.Drawing.Size(100, 21);
			this.txt_money.TabIndex = 2;
			this.txt_money.Leave += new System.EventHandler(this.txt_money_Leave);
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(93, 159);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 3;
			this.btn_ok.Text = "存入(&O)";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// pcb_money
			// 
			this.pcb_money.Image = ((System.Drawing.Image)(resources.GetObject("pcb_money.Image")));
			this.pcb_money.Location = new System.Drawing.Point(213, 105);
			this.pcb_money.Name = "pcb_money";
			this.pcb_money.Size = new System.Drawing.Size(15, 15);
			this.pcb_money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcb_money.TabIndex = 21;
			this.pcb_money.TabStop = false;
			this.pcb_money.Visible = false;
			// 
			// Frm_savemoney
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.timg11;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(273, 212);
			this.Controls.Add(this.pcb_money);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.txt_money);
			this.Controls.Add(this.txt_bnkcard);
			this.Controls.Add(this.lbl_money);
			this.Controls.Add(this.lbl_bnkcard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Frm_savemoney";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "现金存入";
			this.Load += new System.EventHandler(this.Frm_savemoney_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcb_money)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_bnkcard;
		private System.Windows.Forms.Label lbl_money;
		private System.Windows.Forms.TextBox txt_bnkcard;
		private System.Windows.Forms.TextBox txt_money;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.PictureBox pcb_money;
	}
}