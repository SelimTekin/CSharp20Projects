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

namespace Project1_AdoNetCustomer
{
	public partial class FrmCity : Form
	{
		public FrmCity()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		SqlConnection sqlConnection = new SqlConnection("Server=SELIM\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true;");

		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * from City", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command); // Hafızada tutulan verileri ekrana yansıtmak için bir köprü görevi görür.
			DataTable dt = new DataTable();
			adapter.Fill(dt); // dt'nin içini adapterdaki verilerle doldurduk
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into city (CityName, CityCountry) values (@cityName, @cityCountry)", sqlConnection); // sql'de değişkenler @ işareti ile olur. Burda da öyle yaptık
			command.Parameters.AddWithValue("@cityName", txtCityName.Text);
			command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir başarılı bir şekilde eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("delete from City where CityId=@cityId", sqlConnection);
			command.Parameters.AddWithValue("@cityId", txtCityId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("update City set CityName=@cityName, CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
			command.Parameters.AddWithValue("@cityId", txtCityId.Text);
			command.Parameters.AddWithValue("@cityName", txtCityName.Text);
			command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir başarılı bir şekilde güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * from City where CityName=@cityName", sqlConnection);
			command.Parameters.AddWithValue("@cityName", txtCityName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}
	}
}
