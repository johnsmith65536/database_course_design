using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication4
{
	public partial class Frm_accinfo : Form
	{
		public Frm_accinfo()
		{
			InitializeComponent();
			myCls.frm_accinfo = this;
		}

		private void Frm_accinfo_Load(object sender, EventArgs e)
		{

		}

		private void btn_ok_Click(object sender, EventArgs e)
		{

			int state = 0;
			myCls.dt = myCls.Query("select count(*) from customer_info where idcard_num='" + txt_idcard.Text + "'");
			if (myCls.dt.Rows[0][0].ToString() == "1")
			{
				myCls.dt = myCls.Query("select count(*) from customer_info where idcard_num='" + txt_idcard.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
				if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
				else state = 1;
			}


			/*myCls.dt = myCls.Query("select idcard_num,pwd from customer_info");
			int state = 0;
			for (int i = 0; i < myCls.dt.Rows.Count; i++)
			{
				if (myCls.dt.Rows[i][0].ToString() == txt_idcard.Text)
				{
					if (myCls.dt.Rows[i][1].ToString() == txt_pwd.Text) state = 2;
					else state = 1;
					break;
				}
			}*/
			if (myCls.fromwho == 0)	//信息查询
			{
				if (state == 0)
				{
					MessageBox.Show("此用户未在本行注册，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_idcard.Text = "";
					txt_pwd.Text = "";
				}
				else if (state == 1)
				{
					MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_pwd.Text = "";
				}
				else
				{
					myCls.dt = myCls.Query("select * from customer_info where idcard_num='" + txt_idcard.Text + "'");
					String res = "";
					res += "姓名: " + myCls.dt.Rows[0][7].ToString();
					res += Environment.NewLine + "身份证: " + myCls.dt.Rows[0][1].ToString();
					res += Environment.NewLine + "银行卡号: " + myCls.dt.Rows[0][0].ToString();
					res += Environment.NewLine + "账户状态: " + (myCls.dt.Rows[0][8].ToString() == "False" ? "正常" : "冻结");
					res += Environment.NewLine + "预留号码: " + myCls.dt.Rows[0][3].ToString();

					MessageBox.Show(res, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			else if (myCls.fromwho == 1)//信息补充
			{
				if (state == 0)
				{
					MessageBox.Show("此用户未在本行注册，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_idcard.Text = "";
					txt_pwd.Text = "";
				}
				else if (state == 1)
				{
					MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_pwd.Text = "";
				}
				else
				{
					myCls.dt = myCls.Query("select frozen from customer_info where idcard_num='" + txt_idcard.Text + "'");
					if (myCls.dt.Rows[0][0].ToString() == "True")
					{
						MessageBox.Show("账户冻结期间无法进行信息补充，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.Close();
						return;
					}
					myCls.dt = myCls.Query("select * from customer_info where idcard_num='" + txt_idcard.Text + "'");
					myCls.FilePath = myCls.myPath + @"\pictures\customer\" + myCls.dt.Rows[0][0].ToString();
					new Frm_accupdate().ShowDialog();
					this.Close();
				}
			}
			else if (myCls.fromwho == 2)//账户销户
			{
				if (state == 0)
				{
					MessageBox.Show("此用户未在本行注册，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_pwd.Text = "";
					txt_idcard.Text = "";
				}
				else if (state == 1)
				{
					MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_pwd.Text = "";
				}
				else
				{
					myCls.dt = myCls.Query("select frozen from customer_info where idcard_num='" + txt_idcard.Text + "'");
					if (myCls.dt.Rows[0][0].ToString() == "True")
					{
						MessageBox.Show("账户冻结期间无法进行销户，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.Close();
						return;
					}


					//检查余额是否为0
					myCls.dt = myCls.Query("select amout_money from customer_info where idcard_num='" + txt_idcard.Text + "'");
					if (myCls.dt.Rows[0][0].ToString() != "0")
					{
						MessageBox.Show("当前账户存在余额，无法进行销户，请进行取款或转账后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.Close();
						return;
					}



					DialogResult ret = MessageBox.Show("确认要执行销户操作吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (ret == DialogResult.Yes)
					{
						myCls.dt = myCls.Query("select job_num from customer_info where idcard_num='" + txt_idcard.Text + "'");
						myCls.Delete("delete from customer_info where idcard_num='" + txt_idcard.Text + "'");
						if (File.Exists(myCls.myPath + @"\pictures\customer\" + myCls.dt.Rows[0][0].ToString())) File.Delete(myCls.myPath + @"\pictures\customer\" + myCls.dt.Rows[0][0].ToString());
						MessageBox.Show("销户成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
			}
			else if (myCls.fromwho == 3)	//挂失操作
			{
				if (state == 0)
				{
					MessageBox.Show("此用户未在本行注册，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_idcard.Text = "";
					txt_pwd.Text = "";
				}
				else if (state == 1)
				{
					MessageBox.Show("开户密码输入错误，请核对后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txt_pwd.Text = "";
				}
				else
				{
					myCls.dt = myCls.Query("select frozen from customer_info where idcard_num='" + txt_idcard.Text + "'");
					if (myCls.dt.Rows[0][0].ToString() == "False")	//正常状态
					{
						DialogResult ret = MessageBox.Show("账户当前为正常状态，办理挂失业务后，账户会进入冻结状态，确认要办理挂失业务吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (ret == DialogResult.Yes)
						{
							myCls.Update("update customer_info set frozen='True' where idcard_num='" + txt_idcard.Text + "'");
							MessageBox.Show("办理挂失业务成功，账户进入冻结状态！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else //冻结状态
					{
						DialogResult ret = MessageBox.Show("账户当前为冻结状态，取消挂失服务后，账户会进入正常状态，确认要取消挂失服务吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (ret == DialogResult.Yes)
						{
							myCls.Update("update customer_info set frozen='False' where idcard_num='" + txt_idcard.Text + "'");
							MessageBox.Show("取消挂失业务成功，账户进入正常状态！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					this.Close();
				}
			}
			
		}
	}
}
