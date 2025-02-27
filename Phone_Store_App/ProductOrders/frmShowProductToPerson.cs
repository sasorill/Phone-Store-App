using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using Phone_Store_App.EditPerson;
using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Phone_Store_App
{
	public partial class frmShowProductToPerson : Form
	{
		private static DataTable _dtProduct = ClsProducts.GetAllProducts();

		public frmShowProductToPerson()
		{
			InitializeComponent();
		}

		private void _RefreshAllProduct()
		{
			if (_dtProduct.Rows.Count > 0) 
			{
				for (int i = 1; i <= _dtProduct.Rows.Count; i++) 
				{
					ctrlshowProduct Product = new ctrlshowProduct();
					Product.LoadProductByID(i);
					flpProduct.Controls.Add(Product);
				}
				
			}
			else
			{

			}
		}		

		private void _RefreshPersonInfo()
		{

			if (ClsUtilizationLogin.Person != null) 
			{
				ctrlPersonDetails1.LoadPersonInfoByID(ClsUtilizationLogin.Person.PersonID);

				ClsCreditCard Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

				if (Cards != null)
				{
					ctrlCardDetails1.LoadCardInfoPerson(Cards.PersonID);
					ctrlCardDetails1.Visible = true;
				}
				else
				{
					ctrlCardDetails1.Visible = false;
				}
			}
			else
			{
				ctrlPersonDetails1.Visible = false;
				msProfile.Visible = false;
			
			}
		
		}

		private void frmShowProductToPerson_Load(object sender, EventArgs e)
		{
			_RefreshAllProduct();
			_RefreshPersonInfo();

		}

		private void editNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var _Person = ClsUtilizationLogin.Person;

			if (_Person != null)
			{
				frmEditPersonName Person = new frmEditPersonName(_Person.PersonID);
				Person.ShowDialog();
				_RefreshPersonInfo();
			}

		}

		private void editEmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmEditPersonEmail frmEditPerson = new frmEditPersonEmail(ClsUtilizationLogin.Person.PersonID);
			frmEditPerson.ShowDialog();
			_RefreshPersonInfo();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmEditPersonPassword frm = new frmEditPersonPassword(ClsUtilizationLogin.Person.PersonID);
			frm.ShowDialog();
			_RefreshPersonInfo();
		}

		private void updateCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClsCreditCard Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (Cards != null)
			{
				frmAddUpdateCard frm = new frmAddUpdateCard(ctrlCardDetails1.CardID);
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("You Don't Have Any Card, Add Card To Update It...", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void addNewCardToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ClsCreditCard Card = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if(Card != null)
			{
				MessageBox.Show("You Can Add Maximum Cards Is One", "You Can't Add More Than One", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmAddUpdateCard frm = new frmAddUpdateCard();
				frm.ShowDialog();
			}
		}

		private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClsCreditCard Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (Cards != null)
			{
				if(MessageBox.Show("Are You Sure You Want To Delete Card?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					if(Cards.Delete())
					{
						MessageBox.Show("Delete Card Succeeded!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Delete Card False!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
		}

		private void activeCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClsCreditCard Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (Cards != null)
			{
				if (Cards.IsActive)
				{
					MessageBox.Show("The Card Is Already Activated!", "Activation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (MessageBox.Show("Are You Sure You Want To Active Card?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (ClsCreditCard.ActivateCard(Cards.CardID))
						{
							MessageBox.Show("Activate Card Succeeded!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Activate Card False!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
				}
			}
		}

		private void unActiveCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClsCreditCard Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (Cards != null)
			{
				if (!Cards.IsActive)
				{
					MessageBox.Show("The Card Is Already UnActivate!", "UnActivation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (MessageBox.Show("Are You Sure You Want To Active Card?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (ClsCreditCard.UnActiveCard(Cards.CardID))
						{
							MessageBox.Show("Activate Card Succeeded!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Activate Card False!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
				}
			}
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
