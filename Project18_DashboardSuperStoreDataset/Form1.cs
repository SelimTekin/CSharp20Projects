﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project18_DashboardSuperStoreDataset
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("Server=SELIM\\SQLEXPRESS;initial catalog=Db17Project20;integrated security=true;");
		private void Form1_Load(object sender, EventArgs e)
		{

			#region Widgets

			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select Count(*) From superstore", sqlConnection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				lblProductCount.Text = reader[0].ToString();
			}
			sqlConnection.Close();

			sqlConnection.Open();
			SqlCommand command2 = new SqlCommand("Select Count(distinct(state)) From superstore", sqlConnection);
			SqlDataReader reader2 = command2.ExecuteReader();
			while (reader2.Read())
			{
				lblCityCount.Text = reader2[0].ToString();
			}
			sqlConnection.Close();

			sqlConnection.Open();
			SqlCommand command3 = new SqlCommand("Select Count(*) From superstore where country='Turkey'", sqlConnection);
			SqlDataReader reader3 = command3.ExecuteReader();
			while (reader3.Read())
			{
				lblOrderCountByTurkiye.Text = reader3[0].ToString();
			}
			sqlConnection.Close();

			sqlConnection.Open();
			SqlCommand command4 = new SqlCommand("Select sum(Quantity) From superstore", sqlConnection);
			SqlDataReader reader4 = command4.ExecuteReader();
			while (reader4.Read())
			{
				lblOrderCount.Text = reader4[0].ToString();
			}
			sqlConnection.Close();

			#endregion

			#region Charts

			sqlConnection.Open();
			SqlCommand command5 = new SqlCommand("Select top(7) Country, Count(*) From superstore group by Country order by Count(*) desc", sqlConnection);
			SqlDataReader reader5 = command5.ExecuteReader();
			while (reader5.Read())
			{
				chart1.Series["Series1"].Points.AddXY(reader5[0], reader5[1]);
			}
			sqlConnection.Close();

			sqlConnection.Open();
			SqlCommand command6 = new SqlCommand("Select top(3) Country, Sum(Quantity) From superstore group by Country order by Sum(Quantity) desc", sqlConnection);
			SqlDataReader reader6 = command6.ExecuteReader();
			while (reader6.Read())
			{
				chart2.Series["Series1"].Points.AddXY(reader6[0], reader6[1]);
			}
			sqlConnection.Close();

			sqlConnection.Open();
			SqlCommand command7 = new SqlCommand("Select Order_Priority, Count(*) From superstore group by Order_Priority order by Order_Priority desc", sqlConnection);
			SqlDataReader reader7 = command7.ExecuteReader();
			while (reader7.Read())
			{
				chart3.Series["Series1"].Points.AddXY(reader7[0], reader7[1]);
			}
			sqlConnection.Close();


			#endregion
		}

	}
}
