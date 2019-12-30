using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
	public partial class Frm_chkbalance : Form
	{
		int querystate = 0;
		public Frm_chkbalance()
		{
			InitializeComponent();
			myCls.frm_chkbalance = this;
		}

		private void Frm_chkbalance_Load(object sender, EventArgs e)
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)
			{
				lbl_balance.Visible = false;
				txt_balance.Visible = false;
				btn_ok.Text = "查询余额(&C)";
			}
			else
			{
				txt_bnkcard.Text = myCls.job_num;
				txt_balance.Text = myCls.Decode(myCls.getNewMoney(txt_bnkcard.Text).ToString());
				lbl_balance.Visible = true;
				txt_balance.Visible = true;
				lbl_bnkcard.Visible = false;
				txt_bnkcard.Visible = false;
				lbl_pwd.Visible = false;
				txt_pwd.Visible = false;
				btn_ok.Text = "确定(&O)";
				querystate = 1;
			}
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			if (querystate == 0)
			{
				int state = 0;
				myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_bnkcard.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "1")
				{
					myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_bnkcard.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
					else state = 1;
				}

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
					txt_balance.Text = myCls.Decode(myCls.getNewMoney(txt_bnkcard.Text).ToString());
					lbl_balance.Visible = true;
					txt_balance.Visible = true;
					lbl_bnkcard.Visible = false;
					txt_bnkcard.Visible = false;
					lbl_pwd.Visible = false;
					txt_pwd.Visible = false;
					btn_ok.Text = "确定(&O)";
					querystate = 1;
				}
			}
			else
			{
				this.Close();
			}	
		}
	}
}
