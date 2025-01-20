using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
	public partial class FrmProduct : Form
	{
		public FrmProduct()
		{
			InitializeComponent();
		}
		Db2Project20Entities db = new Db2Project20Entities();

		void ProductList()
		{
			dataGridView1.DataSource = db.Product.ToList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			ProductList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.ProductName = txtProductName.Text;
			product.ProductStock = int.Parse(txtProductStock.Text);
			product.ProductPrice = decimal.Parse(txtProductPrice.Text);
			product.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
			db.Product.Add(product);
			db.SaveChanges();
			ProductList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var value = db.Product.Find(int.Parse(txtProductId.Text));
			db.Product.Remove(value);
			db.SaveChanges();
			ProductList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var value = db.Product.Find(int.Parse(txtProductId.Text));
			value.ProductPrice = decimal.Parse(txtProductPrice.Text);
			value.ProductStock = int.Parse(txtProductStock.Text);
			value.ProductName = txtProductName.Text;
			value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString()) ;
			db.SaveChanges();
			ProductList();
		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var values = db.Category.ToList();
			cmbProductCategory.DisplayMember = "CategoryName";
			cmbProductCategory.ValueMember = "CategoryId";
			cmbProductCategory.DataSource = values;

		}

		private void btnProductListWithCategory_Click(object sender, EventArgs e)
		{
			var values = db.Product
				.Join(db.Category,
				product=>product.CategoryId,
				category=>category.CategoryId,
				(product,category) => new
				{
					// Sütun isimleri
					ProductId = product.ProductId,
					ProductName = product.ProductName,
					ProductPrice = product.ProductPrice,
					ProductStock = product.ProductStock,
					CategoryId = category.CategoryId,
					CategoryName = category.CategoryName,
				})
				.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var values = db.Product.Where(x => x.ProductName == txtProductName.Text).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
