using Project12_JwtToken.JWT;
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

namespace Project12_JwtToken
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("Server=SELIM\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true;");
		private void btnLogin_Click(object sender, EventArgs e)
		{
			TokenGenerator tokenGenerator = new TokenGenerator();

			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("select * from TblUser Where Username=@username and Password=@password", sqlConnection);
			cmd.Parameters.AddWithValue("@username", txtUserName.Text);
			cmd.Parameters.AddWithValue("@password", txtPassword.Text);
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			if (sqlDataReader.Read())
			{
				string token = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
				//MessageBox.Show(token);
				FrmEmployee frmEmployee = new FrmEmployee();
				frmEmployee.tokenGet = token;
				frmEmployee.Show();
			}
			else
			{
				MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
				txtPassword.Clear();
				txtUserName.Clear();
				txtUserName.Focus();
			}
			sqlConnection.Close();
		}
	}
}
