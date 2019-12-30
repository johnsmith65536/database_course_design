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
	public partial class Frm_savemoney : Form
	{
		public Frm_savemoney()
		{
			InitializeComponent();
			myCls.frm_savemoney = this;
		}

		private void Frm_savemoney_Load(object sender, EventArgs e)
		{

		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			bool f = false;
			myCls.dt = myCls.Query("select job_num from customer_info");
			for (int i = 0; i < myCls.dt.Rows.Count; i++)
			{
				if (myCls.dt.Rows[i][0].ToString() == txt_bnkcard.Text)
				{
					f = true;
					break;
				}
			}
			if (!f)
			{
				MessageBox.Show("本行未发行此卡，请确认卡号后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_bnkcard.Text = "";
				txt_money.Text = "";
				return;
			}
			if (pcb_money.Visible == true)
			{
				MessageBox.Show("信息格式有误，请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			myCls.dt = myCls.Query("select frozen from customer_info where job_num='" + txt_bnkcard.Text + "'");
			if (myCls.dt.Rows[0][0].ToString() == "True")
			{
				MessageBox.Show("账户冻结期间无法进行存款，请取消挂失后重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_bnkcard.Text = "";
				txt_money.Text = "";
				return;
			}

			String str = "本次操作将产生以下行为，请确认";
			str += Environment.NewLine + "向卡号" + txt_bnkcard.Text + " 存入(现金)￥" + txt_money.Text;
			DialogResult ret = MessageBox.Show(str,"消息",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			if (ret == DialogResult.Yes)
			{

				int curmoney=myCls.getNewMoney(txt_bnkcard.Text)+myCls.Encode(txt_money.Text);
				myCls.InsertLog("0", txt_bnkcard.Text, myCls.DEPOSIT, myCls.Encode(txt_money.Text).ToString(), "0", curmoney.ToString());

				myCls.Update("update customer_info set amout_money='" + curmoney.ToString() + "' where job_num='" + txt_bnkcard.Text + "'");
				MessageBox.Show("存款成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			this.Close();
		}

		private void txt_money_Leave(object sender, EventArgs e)
		{
			Regex reg = new Regex(@"(^[1-9](\d+)?(\.\d{1,2})?$)|(^0$)|(^\d\.\d{1,2}$)");
			pcb_money.Visible = txt_money.Text.Length == 0 || !reg.IsMatch(txt_money.Text);
		}
	}
}
