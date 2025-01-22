using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
	public partial class FrmMovie : Form
	{
		public FrmMovie()
		{
			InitializeComponent();
		}

		MovieContext context = new MovieContext();
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = context.Movies.ToList();
			dataGridView1.DataSource = values;
		}

		private void FrmMovie_Load(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void CategoryList()
		{
			var values = context.Categories.ToList();
			cmbCategory.ValueMember = "CategoryId";
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.DataSource = values;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Movie movie = new Movie();
			movie.MovieTitle = txtMovieName.Text;
			movie.Description = txtMovieDetails.Text;
			movie.CreatedDate = DateTime.Parse(mskDate.Text);
			movie.Duration = int.Parse(txtMovieDuration.Text);
			movie.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			context.Movies.Add(movie);
			context.SaveChanges();
			MessageBox.Show("İşlem Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtMovieId.Text);
			var values = context.Movies.Find(id);
			context.Movies.Remove(values);
			context.SaveChanges();
			MessageBox.Show("İşlem Başarılı");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var values = context.Movies.Where(x => x.MovieTitle.Contains(txtMovieName.Text)).ToList();
			dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtMovieId.Text);
			var values = context.Movies.Find(id);
			values.Duration = int.Parse(txtMovieDuration.Text);
			values.MovieTitle = txtMovieName.Text;
			values.Description = txtMovieDetails.Text;
			values.CreatedDate = DateTime.Parse(mskDate.Text);
			values.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			context.SaveChanges();
			MessageBox.Show("İşlem Başarılı");
		}

		private void btnMovieWithCategory_Click(object sender, EventArgs e)
		{
			var values = context.Movies.
				Join(context.Categories,
				movie => movie.CategoryId,
				category => category.CategoryId,
				(movie, category) => new // movie ile category'i birleştir
				{
					MovieId = movie.MovieId, // datagrid'deki sütun isimleri oluyor eşitliğin sol tarafındakiler
					MovieTitle = movie.MovieTitle,
					Description = movie.Description,
					Duration = movie.Duration,
					CategoryName = category.CategoryName,
				}).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
