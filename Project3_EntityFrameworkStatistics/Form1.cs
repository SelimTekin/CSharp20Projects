using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Db3Project20Entities db = new Db3Project20Entities();
		private void Form1_Load(object sender, EventArgs e)
		{
			// Toplam kategori sayısı
			int categoryCount = db.Category.Count();
			lblCategoryCount.Text = categoryCount.ToString();

			// Toplam ürün sayısı
			int productCount = db.Product.Count();
			lblProductCount.Text = productCount.ToString();

			// Toplam müşteri sayısı
			int customerCount = db.Customer.Count();
			lblCustomerCount.Text = customerCount.ToString();

			// Toplam sipariş sayısı
			int orderCount = db.Order.Count();
			lblOrderCount.Text = orderCount.ToString();

			// Toplam stok sayısı
			var totalStockCount = db.Product.Sum(x=>x.ProductStock);
			lblProductTotalStockCount.Text = totalStockCount.ToString();

			// Ortalama Ürün Fiyatı
			var averageProductPrice = db.Product.Average(x => x.ProductPrice);
			lblAverageProductPrice.Text = averageProductPrice.ToString() + " ₺";

			// Toplam meyve stoğu sayısı
			var totalFruitStockCount = db.Product.Where(x => x.CategoryId==1).Sum(y => y.ProductStock);
			lblSumOfFruitStock.Text = totalFruitStockCount.ToString();

			// Gazoz isimli ürünün toplam işlem hacmi
			var allGazozGetStock = db.Product.Where(x => x.ProductName=="Gazoz").Select(y => y.ProductStock).FirstOrDefault();
			var allGazozGetPrice = db.Product.Where(x => x.ProductName=="Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
			var allGazozTotalPrice = allGazozGetStock * allGazozGetPrice;
			lblTotalPriceAllGazoz.Text = allGazozTotalPrice.ToString() + " ₺";

			// Stok sayısı 100'den az olan ürün sayısı
			var smallerThen100 = db.Product.Where(x => x.ProductStock < 100).Count();
			lblSmallerThen100.Text = smallerThen100.ToString();

			// Kategorisi sebze ve durumu aktif(true) olan ürün stok toplamı
			var trueSebzeCount = db.Product.Where(x => x.CategoryId == (db.Category.Where(y => y.CategoryName == "Sebze").Select(z => z.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(w => w.ProductStock);
			lblTrueSebzeCount.Text = trueSebzeCount.ToString();
		}

	}
}
