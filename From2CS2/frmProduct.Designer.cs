
namespace From2CS2
{
	partial class frmProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btEdit = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(12, 523);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.RowTemplate.Height = 29;
			this.dgvProduct.Size = new System.Drawing.Size(988, 180);
			this.dgvProduct.TabIndex = 0;
			this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(38, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "ລະຫັດປະເພດ:";
			// 
			// textID
			// 
			this.textID.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textID.Location = new System.Drawing.Point(266, 20);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(348, 52);
			this.textID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(38, 297);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 46);
			this.label2.TabIndex = 2;
			this.label2.Text = "ຈຳນວນສິນຄ້າ";
			// 
			// textName
			// 
			this.textName.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textName.Location = new System.Drawing.Point(266, 297);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(348, 52);
			this.textName.TabIndex = 3;
			// 
			// btSave
			// 
			this.btSave.BackColor = System.Drawing.SystemColors.MenuText;
			this.btSave.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btSave.Location = new System.Drawing.Point(266, 423);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(129, 49);
			this.btSave.TabIndex = 4;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.UseVisualStyleBackColor = false;
			// 
			// btEdit
			// 
			this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.btEdit.Location = new System.Drawing.Point(437, 423);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(129, 49);
			this.btEdit.TabIndex = 4;
			this.btEdit.Text = "ແກ້ໄຂ";
			this.btEdit.UseVisualStyleBackColor = false;
			// 
			// btDelete
			// 
			this.btDelete.BackColor = System.Drawing.Color.Red;
			this.btDelete.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDelete.Location = new System.Drawing.Point(609, 423);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(129, 49);
			this.btDelete.TabIndex = 4;
			this.btDelete.Text = "ລຶບ";
			this.btDelete.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(98, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 46);
			this.label3.TabIndex = 5;
			this.label3.Text = "ຊື່ສິນຄ້າ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(266, 154);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(348, 52);
			this.textBox1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(46, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(195, 46);
			this.label4.TabIndex = 7;
			this.label4.Text = "ປະເພດສິນຄ່້າ";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox2.Location = new System.Drawing.Point(266, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(348, 52);
			this.textBox2.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(41, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 46);
			this.label5.TabIndex = 9;
			this.label5.Text = "ບາໂຄ້ດສິນຄ້າ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(266, 375);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(348, 28);
			this.comboBox1.TabIndex = 11;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(266, 242);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(348, 28);
			this.comboBox2.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(733, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 225);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(733, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 45);
			this.button1.TabIndex = 13;
			this.button1.Text = "ເລືອກຮູບ.....";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(42, 358);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 46);
			this.label6.TabIndex = 14;
			this.label6.Text = "ຫົວໜ່ວຍ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btDelete);
			this.panel1.Controls.Add(this.btEdit);
			this.panel1.Controls.Add(this.btSave);
			this.panel1.Controls.Add(this.textName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(988, 487);
			this.panel1.TabIndex = 4;
			// 
			// frmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 727);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvProduct);
			this.Name = "frmProduct";
			this.Text = "frmProduct";
			this.Load += new System.EventHandler(this.frmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btEdit;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
	}
}