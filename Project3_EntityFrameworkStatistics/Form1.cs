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

			// Türkiye'den yapılan siparişler SQL Query
			var orderCountFromTurkiye = db.Database.SqlQuery<int>("select count(*) from [Order] where CustomerId In (select CustomerId from Customer where CustomerCountry='Türkiye')").FirstOrDefault();
			lblOrderCountFromTurkiyeBySql.Text = orderCountFromTurkiye.ToString();

			// Türkiye'den yapılan siparişler EF Query
			var turkishCustomerIds = db.Customer.Where(x => x.CustomerCountry == "Türkiye").Select(y => y.CustomerId).ToList();
			var orderCountFromTurkiyeWithEf = db.Order.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
			lblOrderCountFromTurkiyeByEf.Text = orderCountFromTurkiyeWithEf.ToString();

			// Meyvelerin toplam satış fiyatı (SQL Query)
			var orderTotalPriceMeyve = db.Database.SqlQuery<decimal>("select sum(o.TotalPrice) from [Order] o join Product p on p.ProductId=o.ProductId join Category c on c.CategoryId=p.CategoryId where CategoryName='Meyve'").FirstOrDefault();
			lblOrderTotalPriceMeyve.Text = orderTotalPriceMeyve.ToString() + " ₺";

			// Meyvelerin toplam satış fiyatı (EF Linq)
			var orderTotalPriceMeyveByEf = (from o in db.Order
											join p in db.Product on o.ProductId equals p.ProductId
											join c in db.Category on p.CategoryId equals c.CategoryId
											where c.CategoryName == "Meyve"
											select o.TotalPrice).Sum();
			lblOrderTotalPriceMeyveByEf.Text = orderTotalPriceMeyveByEf.ToString() + " ₺";

			// Son eklenen ürünün adı
			var lastProductName = db.Product.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
			lblLastProductName.Text = lastProductName;

			// Son eklenen ürünün kategori adı
			var lastProductCategoryId = db.Product.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
			var lastProductCategoryName = db.Category.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
			lblLastProductCategoryName.Text = lastProductCategoryName;

			// Aktif ürün sayısı
			var activeProductCount = db.Product.Where(x => x.ProductStatus==true).Count();
			lblActiveProductCount.Text = activeProductCount.ToString();

			// Toplam kola stok satışlarından kazanılan para
			var colaStock = db.Product.Where(x => x.ProductName=="Kola").Select(y => y.ProductStock).FirstOrDefault();
			var colaPrice = db.Product.Where(x => x.ProductName=="Kola").Select(y => y.ProductPrice).FirstOrDefault();
			lblTotalPriceWithStockByCola.Text = (colaStock * colaPrice) + " ₺";

			// Son sipariş veren müşteri adı
			var lastCustomerId = db.Order.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
			var lastCustomerName = db.Customer.Where(x => x.CustomerId==lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
			lblLastCustomerName.Text = lastCustomerName;

			// Ülke Sayısı
			var countryCount = db.Customer.Select(x => x.CustomerCountry).Distinct().Count();
			lblCountryCount.Text = countryCount.ToString();

		}

	}
}
