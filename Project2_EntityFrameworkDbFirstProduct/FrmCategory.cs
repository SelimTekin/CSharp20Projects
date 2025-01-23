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
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		Db2Project20Entities db = new Db2Project20Entities();
		void CategoryList()
		{
			dataGridView1.DataSource = db.Category.ToList();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Category category = new Category(); // Tablo
			category.CategoryName = txtCategoryName.Text;
			db.Category.Add(category);
			db.SaveChanges();
			CategoryList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtCategoryId.Text);
			var value = db.Category.Find(id);
			db.Category.Remove(value);
			db.SaveChanges();
			CategoryList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtCategoryId.Text);
			var value = db.Category.Find(id);
			value.CategoryName = txtCategoryName.Text;
			db.SaveChanges();
			CategoryList();
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{

		}
	}
}
