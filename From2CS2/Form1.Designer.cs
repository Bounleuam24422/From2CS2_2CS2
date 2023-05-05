
using System;
using System.Windows.Forms;

namespace From2CS2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvCat = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btDelete = new System.Windows.Forms.Button();
			this.btEdit = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCat
			// 
			this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCat.Location = new System.Drawing.Point(18, 27);
			this.dgvCat.Name = "dgvCat";
			this.dgvCat.RowHeadersWidth = 51;
			this.dgvCat.RowTemplate.Height = 29;
			this.dgvCat.Size = new System.Drawing.Size(759, 500);
			this.dgvCat.TabIndex = 4;
			this.dgvCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.Controls.Add(this.btDelete);
			this.panel1.Controls.Add(this.btEdit);
			this.panel1.Controls.Add(this.btSave);
			this.panel1.Controls.Add(this.textName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(52, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(657, 311);
			this.panel1.TabIndex = 3;
			// 
			// btDelete
			// 
			this.btDelete.BackColor = System.Drawing.Color.Red;
			this.btDelete.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDelete.Location = new System.Drawing.Point(339, 230);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(129, 49);
			this.btDelete.TabIndex = 4;
			this.btDelete.Text = "ລຶບ";
			this.btDelete.UseVisualStyleBackColor = false;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// btEdit
			// 
			this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btEdit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.btEdit.Location = new System.Drawing.Point(204, 230);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(129, 49);
			this.btEdit.TabIndex = 4;
			this.btEdit.Text = "ແກ້ໄຂ";
			this.btEdit.UseVisualStyleBackColor = false;
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			// 
			// btSave
			// 
			this.btSave.BackColor = System.Drawing.SystemColors.MenuText;
			this.btSave.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btSave.Location = new System.Drawing.Point(69, 230);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(129, 49);
			this.btSave.TabIndex = 4;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.UseVisualStyleBackColor = false;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// textName
			// 
			this.textName.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textName.Location = new System.Drawing.Point(266, 126);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(375, 52);
			this.textName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(38, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 46);
			this.label2.TabIndex = 2;
			this.label2.Text = "ຊື່ປະເພດສິນຄ້າ:";
			// 
			// textID
			// 
			this.textID.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textID.Location = new System.Drawing.Point(266, 42);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(348, 52);
			this.textID.TabIndex = 1;
			this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(38, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "ລະຫັດປະເພດ:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel2.BackgroundImage = global::From2CS2.Properties.Resources.wallpaperflare_com_wallpaper;
			this.panel2.Controls.Add(this.dgvCat);
			this.panel2.Location = new System.Drawing.Point(715, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(795, 551);
			this.panel2.TabIndex = 5;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1535, 670);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button btEdit;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private Button btDelete;
	}
}

