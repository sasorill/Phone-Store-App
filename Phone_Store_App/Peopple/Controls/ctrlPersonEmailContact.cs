using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;

namespace Phone_Store_App
{
	public partial class ctrlPersonEmailContact : UserControl
	{
		public ctrlPersonEmailContact()
		{
			InitializeComponent();
		}

		private void txtTo_Validating(object sender, CancelEventArgs e)
		{
			ErrorProvider errorProvider = new ErrorProvider();
			if (!ClsValidate.EmailValidate(txtTo.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtTo, "This is Not Correct Address");
			}
			else
			{
				errorProvider.SetError(txtTo, null);
			}

		}

		public void SendMessage(int ID, string From)
		{
			txtFrom.Text = From;
			//var message = new MimeMessage();
			//message.From.Add(new MailboxAddress(txtFrom.Text, txtFrom.Text));
			//message.To.Add(new MailboxAddress(txtTo.Text, txtTo.Text));
			//message.Subject = rtxtMessage.Text;

			//message.Body = new TextPart("plain")
			//{
			//	Text = txtBody.Text
			//};

			//using (var client = new SmtpClient())
			//{
			//	try
			//	{
			//		//client.Connect("smtp.gmail.com", 587, false);
			//	//	client.Authenticate("your-email@gmail.com", "your-password");
			//		client.Send(txtFrom.Text, txtTo.Text, rtxtMessage.Text, txtBody.Text);
			//		client.Disconnect(true);
			//		MessageBox.Show("Email sent successfully!");
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show($"Error: {ex.Message}");
			//	}
			//}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{

			MessageBox.Show("Not Yet", "UnAvailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}


}
	


