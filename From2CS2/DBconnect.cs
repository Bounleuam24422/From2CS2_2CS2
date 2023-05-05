using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace From2CS2
{
	class DBConnect
	{
		private static string strCon = "server=DESKTOP-02JQ3PK\\SQLEXPRESS; Initial Catalog = dbpos2cs2; Integrated Security = true";	//ເຊື່ອມຖານຂໍ້ມູນ
		public SqlConnection cn = new SqlConnection(strCon);
		public SqlCommand cmd = new SqlCommand();
		public SqlDataAdapter da = new SqlDataAdapter();
		public DataTable dt = new DataTable();

		public void getData(string sql)
		{

			if (cn.State == ConnectionState.Closed)
			{
				cn.Open();
			}
			da = new SqlDataAdapter(sql, cn);
			dt = new DataTable();
			da.Fill(dt);
		}

		internal void exeCuteData(string sql)
		{
			if (cn.State == ConnectionState.Closed)
			{
				cn.Open();
			}
			cmd = new SqlCommand(sql, cn);
			cmd.ExecuteNonQuery();
		}
	}
}

