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

namespace Phone_Store_App.ProductOrders
{
	public partial class frmProductOrders : Form
	{
		public frmProductOrders(int ProductID)
		{
			InitializeComponent();
			this._ProductID = ProductID;
		}

		private ClsCreditCard _Cards;

		private int _ProductID;

		private int _ItemID;

		private int OrderID;

		private ClsProducts Products;

		private ClsProductItems _Items;

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmShowProductToPerson frmShowProductTo = new frmShowProductToPerson();
			frmShowProductTo.ShowDialog();
		}

		private void btnAddCard_Click(object sender, EventArgs e)
		{
			frmAddUpdateCard frm  = new frmAddUpdateCard();
			frm.ShowDialog();
		}

		private void _FillColorInCB()
		{
			DataTable dtColor = ClsColor.GetAllColors();

			foreach(DataRow Row in dtColor.Rows)
			{
				cbColor.Items.Add(Row["ColourName"]);
			}
		}

		private void _FillData()
		{
			Products = ClsProducts.FindID(_ProductID);

			if (Products != null)
			{
				laProductName.Text = Products.ProductName;
				laCategory.Text = Products.Category.CategoryName;
				laTotalPrice.Text = Products.Price.ToString();
				cbColor.Text = Products.Color.ColorName;
				laDate.Text = Products.MakeDate.ToString();
				laCountry.Text = Products.Country.CountryName;
				pcProductImage.ImageLocation = Products.Image;
			}
		}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			
			_Items = new ClsProductItems();

			_Items.PersonID = ClsUtilizationLogin.Person.PersonID;

			_Items.Quantity = Convert.ToInt32(nudQuantity.Value);

			Products = ClsProducts.FindID(_ProductID);

			if (Products != null) 
			{
				_Items.ProductID = Products.ProductID;
				Products.ColorID = ClsColor.Find(cbColor.Text).ColorID;
			}
			_Items.CardID = _Cards.CardID;
			_Items.TotalPrice = Convert.ToInt32(nudQuantity.Value);

			if(_Items.Save())
			{
				this.Text = "Complete!";
				MessageBox.Show("Process Complete You Will Receive The Order Soon", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("An Error Occurred", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmProductOrders_Load(object sender, EventArgs e)
		{
			_FillData();
			_FillColorInCB();
			laPersonID.Text = ClsUtilizationLogin.Person.PersonID.ToString();

			 _Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (_Cards != null)
			{
				if(_Cards.IsActive)
				{
					btnBuy.Enabled = true;
					laCardID.Text = _Cards.PersonID.ToString();
				}
				
			}
			else
			{
				btnBuy.Enabled = false;
				btnAddCard.ForeColor = Color.Green;
				MessageBox.Show("Your Card Is UnActive Please Activate It!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		
		private void btnShowPersonDetails_Click(object sender, EventArgs e)
		{
		
			frmPersonDetails frmPersonDetails = new frmPersonDetails(ClsUtilizationLogin.Person.PersonID);
			frmPersonDetails.ShowDialog();
		
		}

		private void btnShowCardDetails_Click(object sender, EventArgs e)
		{
			 _Cards = ClsCreditCard.FindByPerson(ClsUtilizationLogin.Person.PersonID);

			if (_Cards != null)
			{
				btnBuy.Enabled = true;
				//ctrlCardDetails1.LoadCardInfoPerson(_Cards.PersonID);
				frmCardDetails frmCard = new frmCardDetails(_Cards.CardID);
				frmCard.ShowDialog();
			}
			else
			{
				btnBuy.Enabled = false;
				btnAddCard.ForeColor = Color.Green;
				MessageBox.Show("No Personal Card Please Add Card...", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
