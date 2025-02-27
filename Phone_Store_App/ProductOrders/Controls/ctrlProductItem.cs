using Phone_Store_App.ProductOrders;
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

namespace Phone_Store_App
{
	public partial class ctrlProductItem : UserControl
	{
		public ctrlProductItem()
		{
			InitializeComponent();
		}

		private int _ProductID = -1;

		public int ProductID
		{
			get { return _ProductID; }
		}

		private ClsProducts _Products;

		public ClsProducts Products
		{
			get { return _Products; }
			set { _Products = value; }
		}

		private void _DefaultView()
		{
			laProductName.Text = "???";
			laCategory.Text = "???";
			laMakeDate.Text = "???";
			laColor.Text = "???";
			laPrice.Text = "???";
			pbProduct.ImageLocation = "";
			rtxtDescription.Text = "???";
		}

		private void _LoadData()
		{
			_ProductID = _Products.ProductID;
			laProductName.Text = _Products.ProductName;
			laCategory.Text = _Products.Category.CategoryName;
			laMakeDate.Text = _Products.MakeDate.ToString();
			laColor.Text = _Products.Color.ColorName;
			laPrice.Text = _Products.Price.ToString() + "$";
			laCountry.Text = ClsCountries.Find(_Products.CountryID).CountryName;
			pbProduct.ImageLocation = _Products.Image;
			rtxtDescription.Text = _Products.Description;
		}

		public void _LoadProductByID(int ProductID)
		{
			_Products = ClsProducts.FindID(ProductID);

			if( _Products == null )
			{
				_DefaultView();
				MessageBox.Show("No ProductName With [" + ProductID.ToString() + "]"," Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_LoadData();
		}

		public void _LoadProductByCategory(int CategoryID)
		{
			_Products = ClsProducts.FindID(CategoryID);

			if (_Products == null)
			{
				_DefaultView();
				MessageBox.Show("No ProductName With [" + CategoryID.ToString() + "]", " Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_LoadData();
		}

		public void _LoadProductByProductName(string ProductName)
		{
			_Products = ClsProducts.FindName(ProductName);

			if (_Products == null)
			{
				_DefaultView();
				MessageBox.Show("No Product Name With [" + ProductName.ToString() + "]", " Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_LoadData();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if (Products == null) 
			{
				MessageBox.Show("No Product Exhibit!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (ClsUtilizationLogin.Person == null) 
			{
			
				MessageBox.Show("You Can't Order This Product Register First", "You Are Not Register As Person!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				//MessageBox.Show("You Can Order This Product Soon", "It's Not Ready Yet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmProductOrders Orders = new frmProductOrders(_ProductID);
				Orders.ShowDialog();
				//this.Hide();
			}
		}
	}
}
