﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Entities
{
	public class Order
	{
        [BsonId] // ORderId'nin Id olduğunu belirtiyoruz
        [BsonRepresentation(BsonType.ObjectId)] // Otomatik artan haline getiriyoruz
        public string OrderId { get; set; }
		public string CustomerName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
