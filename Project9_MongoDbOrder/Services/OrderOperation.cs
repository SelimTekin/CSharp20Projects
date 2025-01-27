using DnsClient.Protocol;
using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
	public class OrderOperation
	{
		public void AddOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderColleciton = connection.GetOrdersCollection();

			var document = new BsonDocument
			{
				{"CustomerName", order.CustomerName},
				{"City", order.City},
				{"District", order.District},
				{"TotalPrice", order.TotalPrice }
			};

			orderColleciton.InsertOne(document);
		}

		public List<Order> GetAllOrders()
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var orders = orderCollection.Find(new BsonDocument()).ToList();

			List<Order> orderList = new List<Order>(); // Datagridde listeleyeceğimiz liste

			foreach (var order in orders)
			{
				orderList.Add(new Order
				{
					City = order["City"].ToString(),
					CustomerName = order["CustomerName"].ToString(),
					District = order["District"].ToString(),
					OrderId = order["_id"].ToString(),
					TotalPrice = decimal.Parse(order["TotalPrice"].ToString()),
				});
			}

			return orderList;
		}

		public void DeleteOrder(string orderId)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			orderCollection.DeleteOne(filter);
		}

		public void UpdateOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var ordersCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
			var updatedValue = Builders<BsonDocument>.Update
				.Set("CustomerName", order.CustomerName)
				.Set("District", order.District)
				.Set("City", order.City)
				.Set("TotalPrice", order.TotalPrice);
			ordersCollection.UpdateOne(filter, updatedValue);
		}

		public Order GetOrderById(string orderId)
		{
			var connection = new MongoDbConnection();
			var ordersCollection = connection.GetOrdersCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			var result = ordersCollection.Find(filter).FirstOrDefault();

			if (result != null)
			{
				return new Order
				{
					City = result["City"].ToString(),
					CustomerName = result["City"].ToString(),
					District = result["District"].ToString(),
					TotalPrice = decimal.Parse(result["TotalPrice"].ToString()),
					OrderId = orderId
				};
			}
			else
			{
				return null;
			}
		}
	}
}
