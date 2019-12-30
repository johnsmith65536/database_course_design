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
	public partial class Frm_schedule : Form
	{
		public Frm_schedule()
		{
			InitializeComponent();
			myCls.frm_schedule = this;
		}

		private void Frm_schedule_Load(object sender, EventArgs e)
		{
			myCls.dt = myCls.Query("select * from operation_info where source='" + myCls.bnkcard + "' or destination='" + myCls.bnkcard+"'");
			Console.WriteLine(myCls.dt.Rows.Count);
			dataGridView1.Columns.Add("0", "流水号");
			dataGridView1.Columns.Add("1", "时间");
			dataGridView1.Columns.Add("2", "支出(-)/存入(+)");
			dataGridView1.Columns.Add("3", "结余");
			dataGridView1.Columns.Add("4", "操作类型");
			dataGridView1.Columns.Add("5", "备注");
			dataGridView1.Columns.Add("6", "操作者");
			for (int i = 0; i < 7; i++)
				dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			for (int i = 0; i < myCls.dt.Rows.Count; i++)
			{
				
				if (i != 0)	//计算利息
				{
					dataGridView1.Rows.Add();
					dataGridView1.Rows[2*i-1].Cells[1].Value = myCls.UnixTimestampToString(Convert.ToInt64(myCls.dt.Rows[i][1].ToString()));
					int nowbalance=(myCls.dt.Rows[i][3].ToString() == myCls.bnkcard ? Convert.ToInt32(myCls.dt.Rows[i][7].ToString()) : Convert.ToInt32(myCls.dt.Rows[i][8].ToString()));
					int prebalance=(myCls.dt.Rows[i-1][3].ToString() == myCls.bnkcard ? Convert.ToInt32(myCls.dt.Rows[i-1][7].ToString()) : Convert.ToInt32(myCls.dt.Rows[i-1][8].ToString()));
					int delta=(myCls.dt.Rows[i][3].ToString() == myCls.bnkcard ? -1 : 1) * Convert.ToInt32(myCls.dt.Rows[i][6].ToString());
					int res=nowbalance-(prebalance+delta);
					dataGridView1.Rows[2 * i - 1].Cells[2].Value = "+"+myCls.Decode(res.ToString());
					dataGridView1.Rows[2 * i - 1].Cells[3].Value = myCls.Decode((res + prebalance).ToString());
					dataGridView1.Rows[2 * i - 1].Cells[4].Value = "利息";
					dataGridView1.Rows[2 * i - 1].Cells[5].Value = "利息结算,金额为:￥" + myCls.Decode(res.ToString());
				}

				dataGridView1.Rows.Add();
				dataGridView1.Rows[2*i].Cells[0].Value = myCls.dt.Rows[i][0].ToString();
				dataGridView1.Rows[2*i].Cells[1].Value = myCls.UnixTimestampToString(Convert.ToInt64(myCls.dt.Rows[i][1].ToString()));
				dataGridView1.Rows[2*i].Cells[2].Value = (myCls.dt.Rows[i][3].ToString() == myCls.bnkcard ? "-" : "+") + myCls.Decode(myCls.dt.Rows[i][6].ToString());
				dataGridView1.Rows[2*i].Cells[3].Value = (myCls.dt.Rows[i][3].ToString() == myCls.bnkcard ? myCls.Decode(myCls.dt.Rows[i][7].ToString()) : myCls.Decode(myCls.dt.Rows[i][8].ToString()));
				dataGridView1.Rows[2*i].Cells[4].Value = (myCls.dt.Rows[i][5].ToString() == "0" ? "转账" : (myCls.dt.Rows[i][5].ToString() == "1"?"存款":"取款"));
				dataGridView1.Rows[2*i].Cells[6].Value = myCls.dt.Rows[i][2].ToString();
				if (myCls.dt.Rows[i][5].ToString() == "0")
				{
					if (myCls.dt.Rows[i][3].ToString() == myCls.bnkcard)
						dataGridView1.Rows[2*i].Cells[5].Value = "转出至卡" + myCls.dt.Rows[i][4].ToString() + ",金额为:￥" + myCls.Decode(myCls.dt.Rows[i][6].ToString());
					else
						dataGridView1.Rows[2*i].Cells[5].Value = "由卡" + myCls.dt.Rows[i][4].ToString() + "转入,金额为:￥" + myCls.Decode(myCls.dt.Rows[i][6].ToString());
				}
				else if (myCls.dt.Rows[i][5].ToString() == "1")
					dataGridView1.Rows[2*i].Cells[5].Value = "存款,金额(现金)为:￥" + myCls.Decode(myCls.dt.Rows[i][6].ToString());
				else
					dataGridView1.Rows[2*i].Cells[5].Value = "取款,金额(现金)为:￥" + myCls.Decode(myCls.dt.Rows[i][6].ToString());
				
			}
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			String str = myCls.getTime();
			ExportToExcel d = new ExportToExcel();
			d.OutputAsExcelFile(dataGridView1, myCls.myPath + @"\" + str + ".xls");
			System.Diagnostics.Process.Start("explorer", myCls.myPath);
		}
	}
}
