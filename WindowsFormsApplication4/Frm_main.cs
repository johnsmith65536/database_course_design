using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace WindowsFormsApplication4
{
	public partial class Frm_main : Form
	{
		public Frm_main()
		{
			InitializeComponent();
			myCls.frm_main = this;
		}

		private void Frm_main_Load(object sender, EventArgs e)
		{
			timer1_task();
			timer1.Enabled = true;
			
			lbl_username.Text = "姓名: " + myCls.user_name;
			lbl_sex.Text = "性别: " + myCls.sex;
			if (myCls.user_tpye == myCls.EMPLOYEE)
			{
				//pcb_user.Load(myCls.myPath + @"\pictures\user\" + myCls.job_num);


				Stream s = new FileStream(myCls.myPath + @"\pictures\user\" + myCls.job_num, FileMode.Open, FileAccess.Read, FileShare.Read);
				Image img = new Bitmap(s);
				pcb_user.Image = img;
				///后面释放资源
				s.Close();
				s.Dispose(); 

				lbl_jobnum.Text = "工号: " + myCls.job_num;
				if (myCls.is_admin)
				{
					管理员菜单ToolStripMenuItem.Visible = true;
				}
				else
				{
					管理员菜单ToolStripMenuItem.Visible = false;
					
				}
			}
			else
			{
				管理员菜单ToolStripMenuItem.Visible = false; 
				账户开户ToolStripMenuItem.Visible = false;
				账户挂失ToolStripMenuItem.Visible = false;
				账户销户ToolStripMenuItem.Visible = false;
				存款ToolStripMenuItem.Visible = false;
				取款ToolStripMenuItem.Visible = false;
				//pcb_user.Load(myCls.myPath + @"\pictures\customer\" + myCls.job_num);

				Stream s = new FileStream(myCls.myPath + @"\pictures\customer\" + myCls.job_num, FileMode.Open, FileAccess.Read, FileShare.Read);
				Image img = new Bitmap(s);
				pcb_user.Image = img;
				///后面释放资源
				s.Close();
				s.Dispose(); 

				lbl_jobnum.Text = "卡号: " + myCls.job_num;
			}
		}

		private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void 账户开户ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_openacc().ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1_task();

		}
		private void timer1_task()
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)	//柜员
			{
				if (myCls.is_admin) toolStripStatusLabel1.Text = DateTime.Now.ToString() + " 银行管理员";
				else toolStripStatusLabel1.Text = DateTime.Now.ToString() + " 银行柜员";
			}
			else //客户
			{
				toolStripStatusLabel1.Text = DateTime.Now.ToString() + " 客户";
			}
		}

		private void 信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)
			{
				myCls.fromwho = 0;
				new Frm_accinfo().ShowDialog();
			}
			else
			{
				myCls.dt = myCls.Query("select * from customer_info where job_num='" +myCls.job_num + "'");
				String res = "";
				res += "姓名: " + myCls.dt.Rows[0][6].ToString();
				res += Environment.NewLine + "身份证: " + myCls.dt.Rows[0][1].ToString();
				res += Environment.NewLine + "银行卡号: " + myCls.dt.Rows[0][0].ToString();
				res += Environment.NewLine + "账户状态: " + (myCls.dt.Rows[0][8].ToString() == "False" ? "正常" : "冻结");
				res += Environment.NewLine + "预留号码: " + myCls.dt.Rows[0][3].ToString();

				MessageBox.Show(res, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void 信息补充ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)
			{
				myCls.fromwho = 1;
				new Frm_accinfo().ShowDialog();
			}
			else
			{
				myCls.dt = myCls.Query("select frozen from customer_info where job_num='" + myCls.job_num + "'");
				if (myCls.dt.Rows[0][0].ToString() == "True")
				{
					MessageBox.Show("账户冻结期间无法进行信息补充，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				myCls.dt = myCls.Query("select * from customer_info where job_num='" + myCls.job_num + "'");
				myCls.FilePath = myCls.myPath + @"\pictures\customer\" + myCls.dt.Rows[0][0].ToString();
				new Frm_accupdate().ShowDialog();
			}
		}

		private void 账户销户ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			myCls.fromwho = 2;
			new Frm_accinfo().ShowDialog();
		}

		private void 账户挂失ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			myCls.fromwho = 3;
			new Frm_accinfo().ShowDialog();
		}

		private void 存款ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_savemoney().ShowDialog();
		}

		private void 取款ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_takeout().ShowDialog();
		}

		private void 转账ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_acctsfer().ShowDialog();
		}

		private void 余额查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_chkbalance().ShowDialog();
		}

		private void 账户明细打印ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (myCls.user_tpye == myCls.EMPLOYEE)
				new Frm_cardinfo().ShowDialog();
			else
			{
				myCls.bnkcard = myCls.job_num;
				new Frm_schedule().ShowDialog();
			}
			
		}

		private void 新柜员注册ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_openuser().ShowDialog();
		}

		private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			myCls.user_tpye = myCls.EMPLOYEE;
			new Frm_login().Show() ;
			this.Hide();
		}

		private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}

	}
}
