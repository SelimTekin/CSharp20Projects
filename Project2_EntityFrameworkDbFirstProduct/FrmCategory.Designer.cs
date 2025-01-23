namespace Project2_EntityFrameworkDbFirstProduct
{
	partial class FrmCategory
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
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(116, 273);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(234, 28);
			this.btnSearch.TabIndex = 24;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(116, 224);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(234, 28);
			this.btnUpdate.TabIndex = 23;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(116, 178);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(234, 28);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(116, 133);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(234, 28);
			this.btnCreate.TabIndex = 21;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(116, 49);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(234, 22);
			this.txtCategoryName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(10, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Kategori Adı:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(116, 87);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(234, 28);
			this.btnList.TabIndex = 16;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(368, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(613, 289);
			this.dataGridView1.TabIndex = 15;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(116, 12);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(234, 22);
			this.txtCategoryId.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(18, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Kategori ID:";
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 450);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategori İşlemleri";
			this.Load += new System.EventHandler(this.FrmCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label1;
	}
}

