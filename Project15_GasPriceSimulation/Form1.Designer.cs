namespace Project15_GasPriceSimulation
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGasAmount = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDieselPrice = new System.Windows.Forms.TextBox();
			this.txtGasolinePrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLpgPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbGasoline = new System.Windows.Forms.RadioButton();
			this.rdbDiesel = new System.Windows.Forms.RadioButton();
			this.rdbLpg = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(66, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yakıt Miktarı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 258);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Toplam Tutar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 309);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Dolum Durumu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(409, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(332, 40);
			this.label4.TabIndex = 3;
			this.label4.Text = "Gas Price Simulation";
			// 
			// txtGasAmount
			// 
			this.txtGasAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGasAmount.Location = new System.Drawing.Point(192, 214);
			this.txtGasAmount.Name = "txtGasAmount";
			this.txtGasAmount.Size = new System.Drawing.Size(247, 27);
			this.txtGasAmount.TabIndex = 4;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTotalPrice.Location = new System.Drawing.Point(192, 257);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(247, 27);
			this.txtTotalPrice.TabIndex = 5;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(192, 309);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(466, 30);
			this.progressBar1.TabIndex = 6;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStart.Location = new System.Drawing.Point(345, 363);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(148, 44);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "İşlemi Başlat";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLpgPrice);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDieselPrice);
			this.groupBox1.Controls.Add(this.txtGasolinePrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(741, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 193);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fiyatlar";
			// 
			// txtDieselPrice
			// 
			this.txtDieselPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDieselPrice.Location = new System.Drawing.Point(92, 63);
			this.txtDieselPrice.Name = "txtDieselPrice";
			this.txtDieselPrice.ReadOnly = true;
			this.txtDieselPrice.Size = new System.Drawing.Size(141, 27);
			this.txtDieselPrice.TabIndex = 12;
			// 
			// txtGasolinePrice
			// 
			this.txtGasolinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGasolinePrice.Location = new System.Drawing.Point(92, 20);
			this.txtGasolinePrice.Name = "txtGasolinePrice";
			this.txtGasolinePrice.ReadOnly = true;
			this.txtGasolinePrice.Size = new System.Drawing.Size(141, 27);
			this.txtGasolinePrice.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 30);
			this.label5.TabIndex = 10;
			this.label5.Text = "Motorin:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 30);
			this.label6.TabIndex = 9;
			this.label6.Text = "Benzin:";
			// 
			// txtLpgPrice
			// 
			this.txtLpgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtLpgPrice.Location = new System.Drawing.Point(92, 109);
			this.txtLpgPrice.Name = "txtLpgPrice";
			this.txtLpgPrice.ReadOnly = true;
			this.txtLpgPrice.Size = new System.Drawing.Size(141, 27);
			this.txtLpgPrice.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(39, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 30);
			this.label7.TabIndex = 13;
			this.label7.Text = "LPG:";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbLpg);
			this.groupBox2.Controls.Add(this.rdbDiesel);
			this.groupBox2.Controls.Add(this.rdbGasoline);
			this.groupBox2.Location = new System.Drawing.Point(45, 84);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(613, 100);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yakıt Türü";
			// 
			// rdbGasoline
			// 
			this.rdbGasoline.AutoSize = true;
			this.rdbGasoline.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
			this.rdbGasoline.Location = new System.Drawing.Point(28, 48);
			this.rdbGasoline.Name = "rdbGasoline";
			this.rdbGasoline.Size = new System.Drawing.Size(85, 34);
			this.rdbGasoline.TabIndex = 0;
			this.rdbGasoline.TabStop = true;
			this.rdbGasoline.Text = "Benzin";
			this.rdbGasoline.UseVisualStyleBackColor = true;
			// 
			// rdbDiesel
			// 
			this.rdbDiesel.AutoSize = true;
			this.rdbDiesel.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
			this.rdbDiesel.Location = new System.Drawing.Point(196, 48);
			this.rdbDiesel.Name = "rdbDiesel";
			this.rdbDiesel.Size = new System.Drawing.Size(95, 34);
			this.rdbDiesel.TabIndex = 1;
			this.rdbDiesel.TabStop = true;
			this.rdbDiesel.Text = "Motorin";
			this.rdbDiesel.UseVisualStyleBackColor = true;
			// 
			// rdbLpg
			// 
			this.rdbLpg.AutoSize = true;
			this.rdbLpg.Font = new System.Drawing.Font("Myanmar Text", 10.2F);
			this.rdbLpg.Location = new System.Drawing.Point(359, 48);
			this.rdbLpg.Name = "rdbLpg";
			this.rdbLpg.Size = new System.Drawing.Size(64, 34);
			this.rdbLpg.TabIndex = 2;
			this.rdbLpg.TabStop = true;
			this.rdbLpg.Text = "LPG";
			this.rdbLpg.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(1165, 475);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.txtGasAmount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGasAmount;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLpgPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDieselPrice;
		private System.Windows.Forms.TextBox txtGasolinePrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbLpg;
		private System.Windows.Forms.RadioButton rdbDiesel;
		private System.Windows.Forms.RadioButton rdbGasoline;
	}
}

