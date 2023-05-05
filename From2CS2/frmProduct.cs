using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace From2CS2
{
	public partial class frmProduct : Form
	{
		DBConnect cn = new DBConnect();
		string[] strHead = { " ລະຫັດສິນຄ້າ ", "ບາໂຄດ", " ຊື່ສິນຄ້າ ", " ປະເພດສິນຄ້າ ", "ຈຳນວນ","ຮູບສິນຄ້າ" };
		int[] col = { 100, 200,100,100,100,500};
		public frmProduct()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmProduct_Load(object sender, EventArgs e)
		{
			ShowData();
			for (int i = 0; i < strHead.Length; i++)
			{
				dgvProduct.Columns[i].HeaderText = strHead[i];
				dgvProduct.Columns[i].Width = col[i];
			}
			dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
			//dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Saysetta OT", 1, 0);
			dgvProduct.EnableHeadersVisualStyles = false;
		}
		private void ShowData()
		{
			string sqlPro = "select * from tbproduct ";
			cn.getData(sqlPro);
			dgvProduct.DataSource = cn.dt;
		}
	}
	
}
