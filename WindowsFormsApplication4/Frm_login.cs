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
	public partial class Frm_login : Form
	{
		String str_code;
		public Frm_login()
		{
			InitializeComponent();
			myCls.frm_login = this;
		}

		

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (txt_code.Text != str_code)
			{
				MessageBox.Show("请输入正确的验证码!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				str_code = myCls.getCode();
				pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
				pcb_code.Refresh();
				txt_code.Text = "";
				return;
			}
			if (cbx_login.SelectedIndex == 0)//柜员登录
			{
				int state = 0;
				myCls.dt = myCls.Query("select count(*) from user_info where job_num='" + txt_user.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "1")
				{
					myCls.dt = myCls.Query("select count(*) from user_info where job_num='" + txt_user.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					Console.WriteLine("select count(*) from user_info where job_num='" + txt_user.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					Console.WriteLine(myCls.dt.Rows[0][0].ToString());
					if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
					else state = 1;
				}


				myCls.dt = myCls.Query("select * from user_info where job_num='" + txt_user.Text + "'");
				if (state == 0)
				{
					MessageBox.Show("此工号未注册，请确认工号后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_code.Text = "";
					txt_pwd.Text = "";
					txt_user.Text = "";
					str_code = myCls.getCode();
					pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
					pcb_code.Refresh();
				}
				else
				{
					if (state == 2)
					{
						myCls.user_tpye = myCls.EMPLOYEE;
						myCls.job_num = myCls.dt.Rows[0][0].ToString();
						myCls.user_name = myCls.dt.Rows[0][3].ToString();
						myCls.sex = myCls.dt.Rows[0][4].ToString();
						if (myCls.dt.Rows[0][2].ToString() == "True")
							myCls.is_admin = true;
						else
							myCls.is_admin = false;
						new Frm_main().Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("密码错误，请确认密码后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txt_code.Text = "";
						txt_pwd.Text = "";
						str_code = myCls.getCode();
						pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
						pcb_code.Refresh();
					}
				}
			}
			else	//客户登录
			{
				int state = 0;
				myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_user.Text + "'");
				if (myCls.dt.Rows[0][0].ToString() == "1")
				{
					myCls.dt = myCls.Query("select count(*) from customer_info where job_num='" + txt_user.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					Console.WriteLine("select count(*) from customer_info where job_num='" + txt_user.Text + "' and pwdcompare('" + txt_pwd.Text + "',pwd)=1");
					if (myCls.dt.Rows[0][0].ToString() == "1") state = 2;
					else state = 1;
				}

				if (state == 0)
				{
					MessageBox.Show("找不到此卡号，请确认卡号后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_code.Text = "";
					txt_pwd.Text = "";
					txt_user.Text = "";
					str_code = myCls.getCode();
					pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
					pcb_code.Refresh();
				}
				else
				{
					if (state == 2)
					{
						myCls.dt = myCls.Query("select * from customer_info where job_num='" + txt_user.Text + "'");
						myCls.user_tpye = myCls.CUSTOMER;
						myCls.job_num = myCls.dt.Rows[0][0].ToString();
						myCls.user_name = myCls.dt.Rows[0][6].ToString();
						myCls.sex = myCls.dt.Rows[0][7].ToString();
						new Frm_main().Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("密码错误，请确认密码后重试!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txt_code.Text = "";
						txt_pwd.Text = "";
						str_code = myCls.getCode();
						pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
						pcb_code.Refresh();
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbx_login.Items.Add("工作人员");
			cbx_login.Items.Add("银行客户");
			cbx_login.SelectedIndex = 0;
			str_code = myCls.getCode();
			pcb_code.Image = Bitmap.FromStream(myCls.CreateCodeImg(str_code));
			pcb_code.Refresh();
		}

		private void cbx_login_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_login.SelectedIndex == 0) lbl_user.Text = "工号";
			else lbl_user.Text = "卡号";
			txt_code.Text = "";
			txt_pwd.Text = "";
			txt_user.Text = "";
		}

		private void Frm_login_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}
