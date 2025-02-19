﻿using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		OrderOperation orderOperation = new OrderOperation();
		private void btnCreate_Click(object sender, EventArgs e)
		{
			var order = new Order
			{
				City = txtCity.Text,
				CustomerName = txtCustomer.Text,
				District = txtDistrict.Text,
				TotalPrice = decimal.Parse(txtTotalPrice.Text)
			};

			orderOperation.AddOrder(order);
			MessageBox.Show("Ekleme işlemi yapıldı");
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Order> orders = orderOperation.GetAllOrders();
			dataGridView1.DataSource = orders;

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			var updateOrder = new Order
			{
				City = txtCity.Text,
				CustomerName = txtCustomer.Text,
				District = txtDistrict.Text,
				TotalPrice = decimal.Parse(txtTotalPrice.Text),
				OrderId = id
			};
			orderOperation.UpdateOrder(updateOrder);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			orderOperation.DeleteOrder(id);
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			Order order = orderOperation.GetOrderById(id);
			dataGridView1.DataSource = new List<Order> { order };
		}
	}
}
