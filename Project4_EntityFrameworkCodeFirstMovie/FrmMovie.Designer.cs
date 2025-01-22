namespace Project4_EntityFrameworkCodeFirstMovie
{
	partial class FrmMovie
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtMovieName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMovieId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.txtMovieDetails = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMovieDuration = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mskDate = new System.Windows.Forms.MaskedTextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnMovieWithCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 253);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(765, 185);
			this.dataGridView1.TabIndex = 19;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(361, 182);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 26);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(361, 142);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 26);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(361, 103);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 26);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(361, 60);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(120, 26);
			this.btnCreate.TabIndex = 15;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtMovieName
			// 
			this.txtMovieName.Location = new System.Drawing.Point(100, 62);
			this.txtMovieName.Name = "txtMovieName";
			this.txtMovieName.Size = new System.Drawing.Size(252, 22);
			this.txtMovieName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Film Adı:";
			// 
			// txtMovieId
			// 
			this.txtMovieId.Location = new System.Drawing.Point(100, 23);
			this.txtMovieId.Name = "txtMovieId";
			this.txtMovieId.Size = new System.Drawing.Size(252, 22);
			this.txtMovieId.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Film Id:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(361, 21);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(120, 26);
			this.btnList.TabIndex = 10;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtMovieDetails
			// 
			this.txtMovieDetails.Location = new System.Drawing.Point(100, 144);
			this.txtMovieDetails.Name = "txtMovieDetails";
			this.txtMovieDetails.Size = new System.Drawing.Size(252, 22);
			this.txtMovieDetails.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "Açıklama:";
			// 
			// txtMovieDuration
			// 
			this.txtMovieDuration.Location = new System.Drawing.Point(100, 105);
			this.txtMovieDuration.Name = "txtMovieDuration";
			this.txtMovieDuration.Size = new System.Drawing.Size(252, 22);
			this.txtMovieDuration.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Film Süresi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 16);
			this.label5.TabIndex = 25;
			this.label5.Text = "Kategori:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 16);
			this.label6.TabIndex = 24;
			this.label6.Text = "İzlenme Tarihi:";
			// 
			// mskDate
			// 
			this.mskDate.Location = new System.Drawing.Point(102, 184);
			this.mskDate.Mask = "00/00/0000";
			this.mskDate.Name = "mskDate";
			this.mskDate.Size = new System.Drawing.Size(250, 22);
			this.mskDate.TabIndex = 26;
			this.mskDate.ValidatingType = typeof(System.DateTime);
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(100, 223);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(252, 24);
			this.cmbCategory.TabIndex = 27;
			// 
			// btnMovieWithCategory
			// 
			this.btnMovieWithCategory.Location = new System.Drawing.Point(361, 218);
			this.btnMovieWithCategory.Name = "btnMovieWithCategory";
			this.btnMovieWithCategory.Size = new System.Drawing.Size(120, 26);
			this.btnMovieWithCategory.TabIndex = 28;
			this.btnMovieWithCategory.Text = "Listele2";
			this.btnMovieWithCategory.UseVisualStyleBackColor = true;
			this.btnMovieWithCategory.Click += new System.EventHandler(this.btnMovieWithCategory_Click);
			// 
			// FrmMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMovieWithCategory);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.mskDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMovieDetails);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMovieDuration);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtMovieName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMovieId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnList);
			this.Name = "FrmMovie";
			this.Text = "FrmMovie";
			this.Load += new System.EventHandler(this.FrmMovie_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtMovieName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMovieId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtMovieDetails;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMovieDuration;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mskDate;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnMovieWithCategory;
	}
}