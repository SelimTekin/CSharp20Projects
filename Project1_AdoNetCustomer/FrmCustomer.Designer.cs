namespace Project1_AdoNetCustomer
{
	partial class FrmCustomer
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.rdbActive = new System.Windows.Forms.RadioButton();
			this.rdbPassive = new System.Windows.Forms.RadioButton();
			this.btnProcedure = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(124, 414);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(234, 28);
			this.btnSearch.TabIndex = 24;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(124, 380);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(234, 28);
			this.btnUpdate.TabIndex = 23;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(124, 346);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(234, 28);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(124, 312);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(234, 28);
			this.btnCreate.TabIndex = 21;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Location = new System.Drawing.Point(124, 123);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(234, 22);
			this.txtCustomerSurname.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(-123, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "Ülke:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(124, 85);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(234, 22);
			this.txtCustomerName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(-149, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Şehir Adı:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(124, 278);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(113, 28);
			this.btnList.TabIndex = 16;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(364, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(770, 395);
			this.dataGridView1.TabIndex = 15;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(124, 48);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(234, 22);
			this.txtCustomerId.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(-140, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Şehir Id:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(0, 122);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "Müşteri Soyadı:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(27, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "Müşteri Adı:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(36, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 16);
			this.label6.TabIndex = 25;
			this.label6.Text = "Müşteri Id:";
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point(124, 160);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(234, 22);
			this.txtBalance.TabIndex = 28;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(57, 159);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 16);
			this.label9.TabIndex = 29;
			this.label9.Text = "Bakiye:";
			// 
			// cmbCity
			// 
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(124, 198);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(234, 24);
			this.cmbCity.TabIndex = 30;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(65, 197);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 16);
			this.label10.TabIndex = 31;
			this.label10.Text = "Şehir:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(57, 241);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 16);
			this.label11.TabIndex = 32;
			this.label11.Text = "Durum:";
			// 
			// rdbActive
			// 
			this.rdbActive.AutoSize = true;
			this.rdbActive.Location = new System.Drawing.Point(125, 243);
			this.rdbActive.Name = "rdbActive";
			this.rdbActive.Size = new System.Drawing.Size(53, 20);
			this.rdbActive.TabIndex = 33;
			this.rdbActive.TabStop = true;
			this.rdbActive.Text = "Aktif";
			this.rdbActive.UseVisualStyleBackColor = true;
			// 
			// rdbPassive
			// 
			this.rdbPassive.AutoSize = true;
			this.rdbPassive.Location = new System.Drawing.Point(237, 243);
			this.rdbPassive.Name = "rdbPassive";
			this.rdbPassive.Size = new System.Drawing.Size(58, 20);
			this.rdbPassive.TabIndex = 34;
			this.rdbPassive.TabStop = true;
			this.rdbPassive.Text = "Pasif";
			this.rdbPassive.UseVisualStyleBackColor = true;
			// 
			// btnProcedure
			// 
			this.btnProcedure.Location = new System.Drawing.Point(245, 278);
			this.btnProcedure.Name = "btnProcedure";
			this.btnProcedure.Size = new System.Drawing.Size(113, 28);
			this.btnProcedure.TabIndex = 35;
			this.btnProcedure.Text = "Prosedür";
			this.btnProcedure.UseVisualStyleBackColor = true;
			this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1211, 502);
			this.Controls.Add(this.btnProcedure);
			this.Controls.Add(this.rdbPassive);
			this.Controls.Add(this.rdbActive);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCustomer";
			this.Text = "Müşteri Formu";
			this.Load += new System.EventHandler(this.FrmCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbCity;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton rdbActive;
		private System.Windows.Forms.RadioButton rdbPassive;
		private System.Windows.Forms.Button btnProcedure;
	}
}