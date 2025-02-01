using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Project16_MailRegister
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Db16Project20Entities context = new Db16Project20Entities();
		private void btnRegister_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int confirmCode = random.Next(100000, 1000000); // ilk değer dahil, son değer dahil değil

			TblUser user = new TblUser();

			user.Email = txtEmail.Text;
			user.Name = txtName.Text;
			user.Surname = txtSurname.Text;
			user.Password = txtPassword.Text;
			user.IsConfirm = false;
			user.ConfirmCode = confirmCode.ToString();

			context.TblUser.Add(user);
			context.SaveChanges();

			#region MailKodları

			MimeMessage mimeMessage = new MimeMessage();

			MailboxAddress mailboxAddressFrom = new MailboxAddress("Selim", "tekinselim.57.57@gmail.com"); // kimden (isim, mail)
			mimeMessage.From.Add(mailboxAddressFrom); // mimeMessage aracılığıyla gönderen kişiyi ekledik

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text); // Alıcı
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = "Email Adresinizin Konfirmasyon Kodu: " + confirmCode;
			mimeMessage.Body = bodyBuilder.ToMessageBody(); // Mesaj eklendi

			mimeMessage.Subject = "Email Konfirmasyon Kodu"; // Konu

			SmtpClient smtpClient = new SmtpClient(); // Simple Mail Transfer Protocol
			smtpClient.Connect("smtp.gmail.com", 587, false); // bağlandığı adres, port, ssl kullanılsın mı (hayır)
			smtpClient.Authenticate("tekinselim.57.57@gmail.com", "nlzosalgsvbprqqi\r\n");
			smtpClient.Send(mimeMessage); // mimeMessage'dan gelen değeri gönder
			smtpClient.Disconnect(true); // bağlantıyı kes

			MessageBox.Show("Mail adresinize doğrulama kodu gönderilmiştir");

			FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
			frmMailConfirm.email = txtEmail.Text;
			frmMailConfirm.Show();

			#endregion

		}
	}
}
