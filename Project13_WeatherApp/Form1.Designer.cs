﻿namespace Project13_WeatherApp
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCelsius = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblWindSpeed = new System.Windows.Forms.Label();
			this.lblHumidity = new System.Windows.Forms.Label();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(60, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "İSTANBUL, TR";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Project13_WeatherApp.Properties.Resources.sun;
			this.pictureBox1.Location = new System.Drawing.Point(68, 248);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(116, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(60, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 36);
			this.label2.TabIndex = 2;
			this.label2.Text = "İSTANBUL, TR";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(62, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bugün";
			// 
			// lblCelsius
			// 
			this.lblCelsius.AutoSize = true;
			this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCelsius.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblCelsius.Location = new System.Drawing.Point(331, 245);
			this.lblCelsius.Name = "lblCelsius";
			this.lblCelsius.Size = new System.Drawing.Size(184, 69);
			this.lblCelsius.TabIndex = 4;
			this.lblCelsius.Text = "00.00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(504, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "C";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(338, 331);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 25);
			this.label6.TabIndex = 6;
			this.label6.Text = "Bugün";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.Cyan;
			this.label7.Location = new System.Drawing.Point(63, 417);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 25);
			this.label7.TabIndex = 7;
			this.label7.Text = "Rüzgar";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.Cyan;
			this.label8.Location = new System.Drawing.Point(63, 473);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 25);
			this.label8.TabIndex = 8;
			this.label8.Text = "Nem";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.Cyan;
			this.label9.Location = new System.Drawing.Point(63, 525);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 25);
			this.label9.TabIndex = 9;
			this.label9.Text = "Fahrenheit";
			// 
			// lblWindSpeed
			// 
			this.lblWindSpeed.AutoSize = true;
			this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblWindSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblWindSpeed.Location = new System.Drawing.Point(202, 417);
			this.lblWindSpeed.Name = "lblWindSpeed";
			this.lblWindSpeed.Size = new System.Drawing.Size(36, 25);
			this.lblWindSpeed.TabIndex = 10;
			this.lblWindSpeed.Text = "00";
			// 
			// lblHumidity
			// 
			this.lblHumidity.AutoSize = true;
			this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblHumidity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblHumidity.Location = new System.Drawing.Point(202, 473);
			this.lblHumidity.Name = "lblHumidity";
			this.lblHumidity.Size = new System.Drawing.Size(36, 25);
			this.lblHumidity.TabIndex = 11;
			this.lblHumidity.Text = "00";
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.AutoSize = true;
			this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblFahrenheit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblFahrenheit.Location = new System.Drawing.Point(202, 525);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(36, 25);
			this.lblFahrenheit.TabIndex = 12;
			this.lblFahrenheit.Text = "00";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(57)))), ((int)(((byte)(119)))));
			this.ClientSize = new System.Drawing.Size(616, 617);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.lblHumidity);
			this.Controls.Add(this.lblWindSpeed);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblCelsius);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCelsius;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblWindSpeed;
		private System.Windows.Forms.Label lblHumidity;
		private System.Windows.Forms.Label lblFahrenheit;
	}
}

