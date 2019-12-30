using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
	public partial class Frm_takeout : Form
	{
		int querystate = 0;
		public Frm_takeout()
		{
			InitializeComponent();
			myCls.frm_takeout = this;
		}

		private void button1_Click(object sender, EventArgs e)
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
					lbl_takeout.Visible = true;
					txt_takeout.Visible = true;
					lbl_bnkcard.Visible = false;
					txt_bnkcard.Visible = false;
					lbl_pwd.Visible = false;
					txt_pwd.Visible = false;
					btn_ok.Text = "取款(&T)";
					querystate = 1;
				}
			}
			else
			{
				if (pcb_takeout.Visible == true)
				{
					MessageBox.Show("信息格式有误，请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (myCls.Encode(txt_balance.Text) < myCls.Encode(txt_takeout.Text))
				{
					MessageBox.Show("此卡不支持透支，请修改取款数目后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_takeout.Text = "";
					return;
				}
				myCls.dt = myCls.Query("select frozen from customer_info where job_num='" + txt_bnkcard.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "True")
				{
					MessageBox.Show("账户冻结期间无法进行取款，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				int curmoney = myCls.getNewMoney(txt_bnkcard.Text) - myCls.Encode(txt_takeout.Text);
				myCls.InsertLog(txt_bnkcard.Text,"0", myCls.DRAW, myCls.Encode(txt_takeout.Text).ToString(), curmoney.ToString(), "0");

				myCls.Update("update customer_info set amout_money='" + curmoney.ToString() + "' where job_num='" + txt_bnkcard.Text + "'");

				MessageBox.Show("取款成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}	
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_balance.Visible = false;
			txt_balance.Visible = false;
			lbl_takeout.Visible = false;
			txt_takeout.Visible = false;
			btn_ok.Text = "查询余额(&C)";
		}

		private void txt_balance_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_takeout_Leave(object sender, EventArgs e)
		{
			Regex reg = new Regex(@"(^[1-9](\d+)?(\.\d{1,2})?$)|(^0$)|(^\d\.\d{1,2}$)");
			pcb_takeout.Visible = txt_takeout.Text.Length == 0 || !reg.IsMatch(txt_takeout.Text);
		}
	}
}
