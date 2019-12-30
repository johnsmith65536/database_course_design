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
	public partial class Frm_acctsfer : Form
	{
		public int querystate = 0;
		public Frm_acctsfer()
		{
			InitializeComponent();
			myCls.frm_acctsfer = this;
		}

		private void Frm_acctsfer_Load(object sender, EventArgs e)
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)
			{
				lbl_balance.Visible = false;
				txt_balance.Visible = false;
				lbl_takeout.Visible = false;
				txt_takeout.Visible = false;
				lbl_tocard.Visible = false;
				txt_tocard.Visible = false;
				btn_ok.Text = "查询余额(&C)";
			}
			else
			{
				txt_fromcard.Text = myCls.job_num;
				txt_balance.Text = myCls.Decode(myCls.getNewMoney(txt_fromcard.Text).ToString());


				lbl_balance.Visible = true;
				txt_balance.Visible = true;
				lbl_takeout.Visible = true;
				txt_takeout.Visible = true;
				lbl_fromcard.Visible = false;
				txt_fromcard.Visible = false;
				lbl_tocard.Visible = true;
				txt_tocard.Visible = true;
				lbl_pwd.Visible = false;
				txt_pwd.Visible = false;
				btn_ok.Text = "转账(&T)";
				querystate = 1;
			}
			
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			if (querystate == 0)
			{
				int state = 0;
				myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_fromcard.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "1")
				{
					myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_fromcard.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
					else state = 1;
				}
				if (state == 0)
				{
					MessageBox.Show("本行未发行此卡，请核对卡号后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_fromcard.Text = "";
					txt_pwd.Text = "";
				}
				else if (state == 1)
				{
					MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_pwd.Text = "";
				}
				else
				{

					txt_balance.Text = myCls.Decode(myCls.getNewMoney(txt_fromcard.Text).ToString());

					lbl_balance.Visible = true;
					txt_balance.Visible = true;
					lbl_takeout.Visible = true;
					txt_takeout.Visible = true;
					lbl_fromcard.Visible = false;
					txt_fromcard.Visible = false;
					lbl_tocard.Visible = true;
					txt_tocard.Visible = true;
					lbl_pwd.Visible = false;
					txt_pwd.Visible = false;

					btn_ok.Text = "转账(&T)";
					querystate = 1;
				}
			}
			else
			{
				if (txt_fromcard.Text == txt_tocard.Text)
				{
					MessageBox.Show("转出卡号与转入卡号不能相同，请检查后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_tocard.Text = "";
					return;
				}
				if (pcb_takeout.Visible == true)
				{
					MessageBox.Show("信息格式有误，请检查后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				myCls.dt = myCls.Query("select job_num from customer_info");
				bool f = false;
				for (int i = 0; i < myCls.dt.Rows.Count; i++)
				{
					if (myCls.dt.Rows[i][0].ToString() == txt_tocard.Text)
					{
						f = true;
						break;
					}
				}
				if (!f)
				{
					MessageBox.Show("本行未发行此卡，请核对卡号后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_tocard.Text = "";
					return;
				}

				if (myCls.Encode(txt_balance.Text) < myCls.Encode(txt_takeout.Text))
				{
					MessageBox.Show("此卡不支持透支，请修改取款数目后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_takeout.Text = "";
					return;
				}

				myCls.dt = myCls.Query("select frozen from customer_info where job_num='" + txt_fromcard.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "True")
				{
					MessageBox.Show("转出银行卡账户被冻结，账户冻结期间无法进行存款，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				myCls.dt = myCls.Query("select frozen from customer_info where job_num='" + txt_tocard.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "True")
				{
					MessageBox.Show("转入银行卡账户被冻结，账户冻结期间无法进行存款，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}


				int from_curmoney = myCls.getNewMoney(txt_fromcard.Text) - myCls.Encode(txt_takeout.Text);
				int to_curmoney = myCls.getNewMoney(txt_tocard.Text) + myCls.Encode(txt_takeout.Text);

				myCls.InsertLog(txt_fromcard.Text, txt_tocard.Text, myCls.TRANSFER,myCls.Encode(txt_takeout.Text).ToString() ,from_curmoney.ToString(),to_curmoney.ToString());

				myCls.Update("update customer_info set amout_money='" + from_curmoney.ToString() + "' where job_num='" + txt_fromcard.Text + "'");
				myCls.Update("update customer_info set amout_money='" + to_curmoney.ToString() + "' where job_num='" + txt_tocard.Text + "'");
				
				MessageBox.Show("转账成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}	
		}

		private void txt_takeout_Leave(object sender, EventArgs e)
		{
			Regex reg = new Regex(@"(^[1-9](\d+)?(\.\d{1,2})?$)|(^0$)|(^\d\.\d{1,2}$)");
			pcb_takeout.Visible = txt_takeout.Text.Length == 0 || !reg.IsMatch(txt_takeout.Text);
		}
	}
}
