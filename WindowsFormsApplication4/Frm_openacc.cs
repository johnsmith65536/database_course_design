using System;
using System.IO;
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
	public partial class Frm_openacc : Form
	{
		string strFileName;
		public Frm_openacc()
		{
			InitializeComponent();
			myCls.frm_openacc = this;
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
		public static bool IsIDCard18(string input)
		{
			if (input.Length != 18) return false;
			//验证是否可以转换为正确的整数  
			long l = 0;
			if (!long.TryParse(input.Remove(17), out l) || l.ToString().Length != 17 || !long.TryParse(input.Replace('x', '0').Replace('X', '0'), out l))
			{
				return false;
			}
			//验证省份是否匹配  
			//1~6位为地区代码，其中1、2位数为各省级政府的代码，3、4位数为地、市级政府的代码，5、6位数为县、区级政府代码。  
			string address = "11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82,91,";
			if (!address.Contains(input.Remove(2) + ","))
			{
				return false;
			}
			//验证生日是否匹配  
			string birthdate = input.Substring(6, 8).Insert(6, "/").Insert(4, "/");
			DateTime dt;
			if (!DateTime.TryParse(birthdate, out dt))
			{
				return false;
			}
			//校验码验证  
			//校验码：  
			//（1）十七位数字本体码加权求和公式   
			//S = Sum(Ai * Wi), i = 0, ... , 16 ，先对前17位数字的权求和   
			//Ai:表示第i位置上的身份证号码数字值   
			//Wi:表示第i位置上的加权因子   
			//Wi: 7 9 10 5 8 4 2 1 6 3 7 9 10 5 8 4 2   
			//（2）计算模   
			//Y = mod(S, 11)   
			//（3）通过模得到对应的校验码   
			//Y: 0 1 2 3 4 5 6 7 8 9 10   
			//校验码: 1 0 X 9 8 7 6 5 4 3 2   
			string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
			string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
			char[] Ai = input.Remove(17).ToCharArray();
			int sum = 0;
			for (int i = 0; i < 17; i++)
			{
				sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
			}
			int y = -1;
			Math.DivRem(sum, 11, out y);
			if (arrVarifyCode[y] != input.Substring(17, 1).ToLower())
			{
				return false;
			}
			return true;
		}

		

		private void txt_idcard_Leave(object sender, EventArgs e)
		{
			pcb_idcard.Visible=!IsIDCard18(txt_idcard.Text);
		}

		private void txt_pwd_Leave(object sender, EventArgs e)
		{

			Regex reg = new Regex(@"^\d{6}$");
			pcb_pwd.Visible=!reg.IsMatch(txt_pwd.Text);
		}

		private void txt_pwd_TextChanged(object sender, EventArgs e)
		{

		}


		private void Frm_openacc_Load(object sender, EventArgs e)
		{

		}

		private void txt_pwdrep_Leave(object sender, EventArgs e)
		{
			Regex reg = new Regex(@"^\d{6}$");
			pcb_pwdrep.Visible = txt_pwd.Text != txt_pwdrep.Text || !reg.IsMatch(txt_pwdrep.Text);
		}

		private void txt_phone_Leave(object sender, EventArgs e)
		{
			Regex reg1 = new Regex(@"^(\d{3,4}-)?\d{6,8}$");
			Regex reg2 = new Regex(@"^[1]+[3,5]+\d{9}");
			pcb_phone.Visible = !reg1.IsMatch(txt_phone.Text) && !reg2.IsMatch(txt_phone.Text);
		}

		private void txt_money_Leave(object sender, EventArgs e)
		{
			Regex reg = new Regex(@"(^[1-9](\d+)?(\.\d{1,2})?$)|(^0$)|(^\d\.\d{1,2}$)");
			pcb_money.Visible = txt_money.Text.Length==0 || !reg.IsMatch(txt_money.Text);
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			bool flag = false;
			flag |= pcb_idcard.Visible;
			flag |= pcb_money.Visible;
			flag |= pcb_phone.Visible;
			flag |= pcb_pwd.Visible;
			flag |= pcb_pwdrep.Visible;
			flag |= !File.Exists(strFileName);
			if(flag)
			{
				MessageBox.Show("信息格式有误，请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				myCls.dt = myCls.Query("select idcard_num from customer_info");
				for (int i = 0; i < myCls.dt.Rows.Count; i++)
				{
					if (myCls.dt.Rows[i][0].ToString() == txt_idcard.Text)
					{
						MessageBox.Show("您已在本行开户，如需修改账户信息，请前往信息补充菜单!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
				}
				Random rd = new Random();
				myCls.dt = myCls.Query("select job_num from customer_info");
				bool f;
				String str;
				do
				{
					f = true;
					str = "16" + rd.Next(1, 10000).ToString().PadLeft(4,'0');
					for (int i = 0; i < myCls.dt.Rows.Count; i++)
					{
						if (myCls.dt.Rows[i][0].ToString() == str) 
							{
								f=false;
								break;
							}
					}
				} while (!f);
				File.Copy(strFileName, myCls.myPath + @"\pictures\customer\" + str, true);
				String ret = myCls.Encode(txt_money.Text).ToString();
				myCls.Insert("insert into customer_info values('" + str + "','" + txt_idcard.Text + "','" + txt_address.Text + "','" + txt_phone.Text + "','" + ret + "',pwdencrypt('" + txt_pwd.Text + "'),'" + txt_name.Text + "','" + ((txt_idcard.Text[16] - '0') % 2 == 1 ? "男" : "女") + "','0')");
				ret = "开户成功!";
				ret += Environment.NewLine + "银行卡号：" + str;
				ret += Environment.NewLine + "预存款：￥" + txt_money.Text;
				MessageBox.Show(ret, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				myCls.InsertLog("0", str, myCls.DEPOSIT, myCls.Encode(txt_money.Text).ToString(),"0", myCls.Encode(txt_money.Text).ToString());
				this.Close();
			}
		}

		private void txt_idcard_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txt_phone_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_money_TextChanged(object sender, EventArgs e)
		{

		}	

	}
}
