using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class Frm_cardinfo : Form
	{
		public Frm_cardinfo()
		{
			InitializeComponent();
			myCls.frm_cardinfo = this;
		}

		private void Frm_cardinfo_Load(object sender, EventArgs e)
		{

		}

		private void btn_ok_Click(object sender, EventArgs e)
		{


			int state = 0;
			myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_bnkcard.Text + "'");
			if (myCls.dt.Rows[0][0].ToString() == "1")
			{
				myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_bnkcard.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
				if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
				else state = 1;
			}

			/*
			myCls.dt = myCls.Query("select job_num,pwd from customer_info");
			int state = 0;
			for (int i = 0; i < myCls.dt.Rows.Count; i++)
			{
				if (myCls.dt.Rows[i][0].ToString() == txt_bnkcard.Text)
				{
					if (myCls.dt.Rows[i][1].ToString() == txt_pwd.Text) state = 2;
					else state = 1;
					break;
				}
			}*/

			if (state == 0)
			{
				MessageBox.Show("本行未发行此卡，请核对卡号后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_bnkcard.Text = "";
				txt_pwd.Text = "";
			}
			else if (state == 1)
			{
				MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_pwd.Text = "";
			}
			else
			{
				myCls.bnkcard = txt_bnkcard.Text;
				new Frm_schedule().ShowDialog();
				this.Close();
			}
			
		}
	}
}
