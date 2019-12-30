using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace WindowsFormsApplication4
{
	public static class myCls
	{
		public const int EMPLOYEE = 0;	//柜员
		public const int CUSTOMER = 1;	//客户

		public const int TRANSFER = 0;	//转账
		public const int DEPOSIT = 1;	//存款
		public const int DRAW = 2;		//取款

		public const double RATE = 0.03;	//1min 0.03%的利率

		public static Frm_login frm_login;
		public static Frm_main frm_main;
		public static Frm_openacc frm_openacc;
		public static Frm_accinfo frm_accinfo;
		public static Frm_accupdate frm_accupdate;
		public static Frm_savemoney frm_savemoney;
		public static Frm_takeout frm_takeout;
		public static Frm_acctsfer frm_acctsfer;
		public static Frm_chkbalance frm_chkbalance;
		public static Frm_schedule frm_schedule;
		public static Frm_cardinfo frm_cardinfo;
		public static Frm_openuser frm_openuser;
		public static bool is_admin;//柜员是否为管理员
		public static int user_tpye;
		public static String job_num,user_name,sex;
		public static String myPath = System.Environment.CurrentDirectory;
		public static int fromwho;//accinfo 是由谁发起
		public static String FilePath;
		public static DataTable dt;
		public static String bnkcard;
		public static DataTable Query(String sql)
		{
			String connsql;
			if (user_tpye == EMPLOYEE)
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=sa;pwd=123";
				Console.WriteLine("连接到工作人员数据库");
			}
			else
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=John;pwd=123";
				Console.WriteLine("连接到客户数据库");
			}
			using (SqlConnection conn = new SqlConnection())
			{
				conn.ConnectionString = connsql;
				conn.Open(); // 打开数据库连接

				SqlDataAdapter myda = new SqlDataAdapter(sql, conn); // 实例化适配器
				conn.Close(); // 关闭数据库连接
				dt = new DataTable();
				
				myda.Fill(dt); // 保存数据
				for (int i = 0; i < dt.Rows.Count; i++)
					for (int j = 0; j < dt.Columns.Count; j++)
					//dt.Rows[i][j] = dt.Rows[i][j].ToString().Trim();
					{
						if(dt.Rows[i][j].GetType()==typeof(byte[])) continue;
						dt.Rows[i][j] = dt.Rows[i][j].ToString().Trim();
					}
				return dt;
			}
		}
		public static bool Update(String sql)
		{
			String connsql;
			if (user_tpye == EMPLOYEE)
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=sa;pwd=123";
				Console.WriteLine("连接到工作人员数据库");
			}
			else
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=John;pwd=123";
				Console.WriteLine("连接到客户数据库");
			}
			using (SqlConnection conn = new SqlConnection())
			{
				conn.ConnectionString = connsql;
				conn.Open(); // 打开数据库连接
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.ExecuteNonQuery();
				}
				conn.Close(); // 关闭数据库连接
			}
			return true;
		}
		public static bool Insert(String sql)
		{
			String connsql;
			if (user_tpye == EMPLOYEE)
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=sa;pwd=123";
				Console.WriteLine("连接到工作人员数据库");
			}
			else
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=John;pwd=123";
				Console.WriteLine("连接到客户数据库");
			}
			using (SqlConnection conn = new SqlConnection())
			{
				conn.ConnectionString = connsql;
				conn.Open(); // 打开数据库连接
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.ExecuteNonQuery();
				}
				conn.Close(); // 关闭数据库连接
			}
			return true;
		}
		public static bool Delete(String sql)
		{
			String connsql;
			if (user_tpye == EMPLOYEE)
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=sa;pwd=123";
				Console.WriteLine("连接到工作人员数据库");
			}
			else
			{
				connsql = "data source=MY-COMPUTER\\SQLEXPRESS;initial catalog=zbk_db;user id=John;pwd=123";
				Console.WriteLine("连接到客户数据库");
			}
			using (SqlConnection conn = new SqlConnection())
			{
				conn.ConnectionString = connsql;
				conn.Open(); // 打开数据库连接
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.ExecuteNonQuery();
				}
				conn.Close(); // 关闭数据库连接
			}
			return true;
		}
		public static int Encode(String str)
		{
			int res=0;
			for (int i = 0; i < str.Length; i++)
				if (str[i] != '.')
					res = res * 10 + str[i] - '0';
			if (str.Length - 3>=0 && str[str.Length - 3] == '.') { }
			else if (str.Length - 2>=0 && str[str.Length - 2] == '.') res = res * 10;
			else res = res * 100;
			return res;
		}
		public static String Decode(String str)
		{
			if (str.Length == 1) return "0.0" + str;
			else if (str.Length == 2) return "0." + str;
			else return str.Substring(0, str.Length - 2) + "." + str.Substring(str.Length - 2, 2);
		}
		public static String getNextSerial()
		{
			String Now = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
			dt = Query("select Count(*) from operation_info where serial_number like '"+Now+"%'");
			return Now + (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString().PadLeft(4, '0');
		}
		public static String getTime()
		{
			return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0');
		}
		public static string getTimeStamp()
		{
			TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return Convert.ToInt64(ts.TotalSeconds).ToString();
		}
		public static void InsertLog(String source, String destination, int op_type,String delta,String s_balance,String d_balance)
		{
			myCls.Insert("insert into operation_info values('" + myCls.getNextSerial() + "','" + myCls.getTimeStamp() + "','" + myCls.job_num + "','" + source + "','" + destination + "','" + op_type.ToString() + "','" + delta + "','" + s_balance + "','" + d_balance + "')");
		}
		public static int getNewMoney(String job_num)
		{
			myCls.dt = myCls.Query("if (select max(time_stamp) from operation_info where source='" + job_num + "') > (select max(time_stamp) from operation_info where destination='" + job_num + "' ) select time_stamp,s_balance from operation_info where time_stamp=(select max(time_stamp) from operation_info where source='" + job_num + "'); else select time_stamp,d_balance from operation_info where time_stamp=(select max(time_stamp) from operation_info where destination='" + job_num + "')");
			int deltatime = Convert.ToInt32(myCls.getTimeStamp()) - Convert.ToInt32(myCls.dt.Rows[0][0].ToString());
			double balance = 1.0 * Convert.ToInt32(myCls.dt.Rows[0][1].ToString());
			return (int)Math.Floor(balance * Math.Pow((1 + 1.0 * myCls.RATE / 100), deltatime / 60));
		}
		public static String UnixTimestampToString(long timestamp)
		{
			long unixTimeStamp = timestamp;
			System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
			DateTime dt = startTime.AddSeconds(unixTimeStamp);
			return dt.Year.ToString() + "-" + dt.Month.ToString().PadLeft(2, '0') + "-" + dt.Day.ToString().PadLeft(2, '0') + " " + dt.Hour.ToString().PadLeft(2, '0') + ":" + dt.Minute.ToString().PadLeft(2, '0') + ":" + dt.Second.ToString().PadLeft(2, '0');
		}

		public static MemoryStream CreateCodeImg(string checkCode)
		{
			if (string.IsNullOrEmpty(checkCode))
			{
				return null;
			}
			Bitmap image = new Bitmap((int)Math.Ceiling((checkCode.Length * 12.5)), 22);
			Graphics graphic = Graphics.FromImage(image);
			try
			{
				Random random = new Random();
				graphic.Clear(Color.White);
				int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
				for (int index = 0; index < 25; index++)
				{
					x1 = random.Next(image.Width);
					x2 = random.Next(image.Width);
					y1 = random.Next(image.Height);
					y2 = random.Next(image.Height);

					graphic.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
				}
				Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
				System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
				graphic.DrawString(checkCode, font, brush, 2, 2);

				int x = 0;
				int y = 0;

				for (int i = 0; i < 100; i++)
				{
					x = random.Next(image.Width);
					y = random.Next(image.Height);
					image.SetPixel(x, y, Color.FromArgb(random.Next()));
				}
				graphic.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
				image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
				return ms;
			}
			finally
			{
				graphic.Dispose();
				image.Dispose();
			}
		}
		public static String getCode()
		{
			Random rd = new Random();
			String str="";
			for(int i=0;i<4;i++)
				str+=Convert.ToString(rd.Next(0, 10));
			return str;
		}
	}
}
