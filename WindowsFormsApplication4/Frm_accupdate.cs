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
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
	public partial class Frm_accupdate : Form
	{
		String strFileName;
		public Frm_accupdate()
		{
			InitializeComponent();
			myCls.frm_accupdate = this;
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			bool flag = pcb_phone.Visible;
			if (flag)
			{
				MessageBox.Show("信息格式有误，请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				String job_num=myCls.FilePath.Substring(myCls.FilePath.Length-6,6);
				if (strFileName != null && File.Exists(strFileName)) File.Copy(strFileName, myCls.myPath + @"\pictures\customer\" + job_num, true);

				myCls.Update("update customer_info set phone_num='" + txt_phone.Text + "' where job_num='" + job_num + "'");
				myCls.Update("update customer_info set address_='" + txt_address.Text + "' where job_num='" + job_num + "'");

				MessageBox.Show("信息补充成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();

			}
		}

		private void Frm_accupdate_Load(object sender, EventArgs e)
		{
			txt_name.Enabled = false;
			txt_idcard.Enabled = false;
			txt_bnkcard.Enabled = false;
			//pcb_user.Load(myCls.FilePath);

			Stream s = new FileStream(myCls.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			Image img = new Bitmap(s);
			pcb_user.Image = img;
			///后面释放资源
			s.Close();
			s.Dispose(); 


			txt_name.Text = myCls.dt.Rows[0][7].ToString();
			txt_idcard.Text = myCls.dt.Rows[0][1].ToString();
			txt_phone.Text = myCls.dt.Rows[0][3].ToString();
			txt_address.Text = myCls.dt.Rows[0][2].ToString();
			txt_bnkcard.Text = myCls.dt.Rows[0][0].ToString();
		}

		private void txt_phone_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_phone_Leave(object sender, EventArgs e)
		{
			Regex reg1 = new Regex(@"^(\d{3,4}-)?\d{6,8}$");
			Regex reg2 = new Regex(@"^[1]+[3,5]+\d{9}");
			pcb_phone.Visible = !reg1.IsMatch(txt_phone.Text) && !reg2.IsMatch(txt_phone.Text);
		}

		private void btn_picture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "图片文件(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
			ofd.ValidateNames = true;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				strFileName = ofd.FileName;
				//pcb_user.Load(strFileName);
				Stream s = new FileStream(strFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
				Image img = new Bitmap(s);
				pcb_user.Image = img;
				///后面释放资源
				s.Close();
				s.Dispose(); 
			}
			else
			{
				strFileName = "";
			}
		}

		private void txt_name_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
