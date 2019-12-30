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
	public partial class Frm_openuser : Form
	{
		string strFileName;
		public Frm_openuser()
		{
			InitializeComponent();
			myCls.frm_openuser = this;
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			bool flag = false;
			flag |= pcb_pwdrep.Visible;
			flag |= strFileName == null;
			flag |= !File.Exists(strFileName);
			if (flag)
			{
				MessageBox.Show("信息格式有误，请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				myCls.dt = myCls.Query("select count(*) from user_info");
				String str ="16" +(Convert.ToInt32(myCls.dt.Rows[0][0].ToString()) + 1).ToString().PadLeft(4,'0');
				File.Copy(strFileName, myCls.myPath + @"\pictures\user\" + str, true);

				myCls.Insert("insert into user_info values('" + str + "',pwdencrypt('" + txt_pwd.Text + "'),'False','" + txt_name.Text + "','" + (cbx_sex.SelectedIndex == 0 ? "男')" : "女')"));

				String ret = "柜员注册成功!";
				ret += Environment.NewLine + "工号：" + str;
				MessageBox.Show(ret, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		private void Frm_openuser_Load(object sender, EventArgs e)
		{
			cbx_sex.Items.Add("男");
			cbx_sex.Items.Add("女");
			cbx_sex.SelectedIndex = 0;
		}

		private void txt_pwdrep_Leave(object sender, EventArgs e)
		{
			pcb_pwdrep.Visible = txt_pwd.Text != txt_pwdrep.Text;
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
				pcb_user.Image = null;
				pcb_user.Refresh();
			}
		}

		private void lbl_pwd_Click(object sender, EventArgs e)
		{

		}
	}
}
