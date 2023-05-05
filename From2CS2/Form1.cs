using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From2CS2		   //Name is Project
{
	public partial class Form1 : Form
	{
		DBConnect con = new DBConnect();
		string[] strHead = { " ລະຫັດປະເພດສິນຄ້າ ", " ຊື່ປະເພດສິນຄ້າ "};
		int[] col = { 200, 200 };
		private object ex;

		public Form1()
		{
			InitializeComponent();
		}
		private void showData()		 //Select
		{
			con.getData("select * from tbcategory");
			dgvCat.DataSource = con.dt;
		}
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btEdit.Enabled = false;
			btDelete.Enabled = false;
			btSave.Enabled = true;
			showData();
			for (int i = 0; i < strHead.Length; i++)
			{
				dgvCat.Columns[i].HeaderText = strHead[i];
				dgvCat.Columns[i].Width = col[i];
			}
			dgvCat.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
			dgvCat.EnableHeadersVisualStyles = false;
		}


		private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)	//Properties -> CellClik "dgvCat" and Bouble Click
		{
			try		   //tab2 in Buttons
			{
				btEdit.Enabled = true;
				btDelete.Enabled = true;
				btSave.Enabled = false;

				DataGridViewRow row = this.dgvCat.Rows[e.RowIndex];
				textID.Text = row.Cells[0].Value.ToString();
				textName.Text = row.Cells[1].Value.ToString();
			}
			catch (Exception)
			{
				throw;
			}
		}
		private void btSave_Click(object sender, EventArgs e)
		{
			try
			{
				string sqlSave = "insert into tbcategory(catname) values(N'" + textName.Text + "')";
				con.exeCuteData(sqlSave);
				MessageBox.Show("ບັນທຶກສຳເລັດແລ້ວ", "ຢືນຢັນ");
				showData();
				textName.Clear();  //`Clear()` method clears the text in the control,
				textID.Clear();
				textID.Focus();
			}
			catch (Exception)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void btEdit_Click(object sender, EventArgs e)	 //Properties -> Events -> Action => Click "btEdit" 
		{
			try
			{
				string sqlUp = "update tbcategory set catname= N'" +textName.Text+ "' where  catid =" + textID.Text;
				if (MessageBox.Show("ທ່ານຕ້ອງແກ້ໄຂຂໍ້ມູນນີ້ ແທ້ ຫຼື ບໍ່?", "ຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.exeCuteData(sqlUp);
					showData();
					textID.Clear();			  //ເລືອກກົດທີ ລະຫັດປະເພດ ======== -> Properties -> Categorized -> Design "textID"
					textName.Clear();
					textName.Focus();
				}

			}
			catch (Exception)
			{

				throw;
		}
	}

		private void btDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string sqlDel = "delete from tbcategory where catid =" + textID.Text;
				if (MessageBox.Show("ທ່ານຕ້ອງລືບຂໍ້ມູນນີ້ ແທ້ ຫຼື ບໍ່?", "ຢືນຢັນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					con.exeCuteData(sqlDel);
					showData();
					textID.Clear();
					textName.Clear();
					textName.Focus();
				}

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
  }

