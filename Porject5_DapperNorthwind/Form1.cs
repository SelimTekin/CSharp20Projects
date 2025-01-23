using Dapper;
using Porject5_DapperNorthwind.Dtos.CategoryDtos;
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

namespace Porject5_DapperNorthwind
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=SELIM\\SQLEXPRESS;initial catalog=NORTHWND;integrated security=true");
		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select * from Categories";
			var values = await connection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnCreateCategory_Click(object sender, EventArgs e)
		{
			string query = "insert into Categories (CategoryName, Description) values (@categoryName, @description)";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryName", txtCategoryName.Text);
			parameters.Add("@description", txtCategoryDescription.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			string query = "delete from Categories where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			string query = "update Categories set CategoryName=@categoryName, Description=@description where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryName", txtCategoryName.Text);
			parameters.Add("@description", txtCategoryDescription.Text);
			parameters.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			// Kategori Sayısı
			string query = "select count(*) from Categories";
			var categoryCount = await connection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Toplam Kategori Sayısı: " + categoryCount;

			// Ürün Sayısı
			string query2 = "select count(*) from Products";
			var productCount = await connection.ExecuteScalarAsync<int>(query2);
			lblProductCount.Text = "Toplam Ürin Sayısı: " + productCount;

			// Ortalama Ürün Stok Sayısı
			string query3 = "select avg(UnitsInStock) from Products";
			var avgProductStock= await connection.ExecuteScalarAsync<int>(query3);
			lblAvgProductStock.Text = "Ortalama Ürün Sayısı: " + avgProductStock;

			// Deniz Ürünleri Toplam Fiyatı
			string query4 = "select sum(UnitPrice) from Products where CategoryId=(select CategoryId from Categories where CategoryName='SeaFood')";
			var totalSeaFoodPrice = await connection.ExecuteScalarAsync<decimal>(query4);
			lblSeafoodProductTotalPrice.Text = "Deniz Ürünleri Toplam Fiyatı: " + totalSeaFoodPrice;
		}
	}
}
