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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("Server=SELIM\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true;");
		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerSurname, CustomerBalance, CustomerStatus, CityName from Customer cst inner join City c on c.CityId=cst.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into Customer (CustomerName, CustomerSurname, CustomerCity, CustomerBalance, CustomerStatus) values (@CustomerName, @CustomerSurname, @CustomerCity, @CustomerBalance, @CustomerStatus)", sqlConnection);
			command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@CustomerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@CustomerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@CustomerBalance", txtBalance.Text);
			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@CustomerStatus", true);
			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@CustomerStatus", false);
			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarıyla eklendi");
		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			//sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * from City", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command); // connection açıp kapamasak da SqlDataAdapter bunu yapıyor zaten
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			cmbCity.ValueMember = "CityId"; // combobox'taki şehir bilgilerinin arka tarafında id bilgisi olarak tutulur
			cmbCity.DisplayMember = "CityName"; // Kullanıcıya gösterilecek kısım
			cmbCity.DataSource = dt;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("delete from Customer where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("update Customer set CustomerName=@CustomerName, CustomerSurname=@CustomerSurname, CustomerCity=@CustomerCity, CustomerBalance=@CustomerBalance, CustomerStatus=@CustomerStatus where CustomerId=@CustomerId", sqlConnection);
			command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@CustomerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@CustomerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@CustomerBalance", txtBalance.Text);
			command.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@CustomerStatus", true);
			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@CustomerStatus", false);
			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarıyla güncellendi");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerSurname, CustomerBalance, CustomerStatus, CityName from Customer cst inner join City c on c.CityId=cst.CustomerCity where CustomerName=@CustomerName", sqlConnection);
			command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}
	}
}
