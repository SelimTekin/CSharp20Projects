using Project11_TriggerOrderStock.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Db First'te bu şekilde entities çağırılıyor
			Db11Project20Entities context = new Db11Project20Entities();

			string number;
			Console.WriteLine("### Sipariş Stok Sistemi ###");
			Console.WriteLine();
			Console.WriteLine("1-Ürün Listesi");
			Console.WriteLine("2-Sipariş Listesi");
			Console.WriteLine("3-Kasa Durumu");
			Console.WriteLine("4-Yeni Ürün Satışı");
			Console.WriteLine("5-İşlem Sayacı");
			Console.WriteLine("6-Ürün Stok Güncelleme");
			Console.WriteLine();
			Console.WriteLine("---------------------------");
			Console.WriteLine();

			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin: ");
			number = Console.ReadLine();
			Console.WriteLine();


			if (number == "1")
			{
				Console.WriteLine("---- Ürün Listesi ----");

				var values = context.Product.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.ProductId + "-" + item.ProductName + " Stok Sayısı: " + item.ProductStock + " Fiyatı: " + item.ProductPrice + " TL");
				}
			}
			if (number == "2")
			{
				Console.WriteLine("---- Sipariş Listesi ----");

				var values = context.Order.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.OrderId + "-" + item.Product.ProductName + " Birim Fiyat: " + item.UnitPrice + " Adet: " + item.Quantity + " Toplam Fiyat: " + item.TotalPrice);
				}
			}
			if (number == "3")
			{
				Console.WriteLine("---- Sipariş Listesi ----");

				var values = context.CashRegister.Select(x => x.Balance).FirstOrDefault();
				Console.WriteLine("Kasadaki Toplam Tutar: " + values + " TL");
			}
			if (number == "4")
			{
				Console.WriteLine("---- Yeni Ürün Sipariş Girişi ----");

				Console.Write("Müşteri Adı:");
				string customer = Console.ReadLine();

				Console.Write("Ürün Id:");
				int productId = int.Parse(Console.ReadLine());

				Console.Write("Ürün Adedi:");
				int quantity = int.Parse(Console.ReadLine());

				Console.WriteLine();
				Console.WriteLine("---- Ürümn Bilgileri ----");

				var productName = context.Product.Where(x => x.ProductId == productId).Select(y => y.ProductName).FirstOrDefault();
				Console.Write("Ürün ADı:" + productName);

				var productUnitPrice = context.Product.Where(x => x.ProductId == productId).Select(y => y.ProductPrice).FirstOrDefault();
				Console.Write("Birim Fiyat:" + productUnitPrice);

				decimal totalPrice = quantity * decimal.Parse(productUnitPrice.ToString());
				Console.WriteLine("Toplam Fiyat: " + totalPrice);

				Console.WriteLine();
				Console.WriteLine("---- Ürün Bilgileri ----");

				Order order = new Order();
				order.UnitPrice = productUnitPrice;
				order.Quantity = quantity;
				order.Customer = customer;
				order.ProductId = productId;
				order.TotalPrice = totalPrice;

				context.Order.Add(order);
				context.SaveChanges();
			}
			if (number == "5")
			{
				var value = context.Process.Select(x => x.Process1).FirstOrDefault();
				Console.WriteLine("Toplam işlem Sayısı: " + value);
			}
			Console.Read();

		}
	}
}
