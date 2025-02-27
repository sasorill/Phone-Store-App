using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class ctrlshowProduct : UserControl
	{
		public ctrlshowProduct()
		{
			InitializeComponent();
		}

		private ClsProducts Product;

		private int _ProductID = -1;

		public int ProductID
		{
			get { return _ProductID; }
			set {_ProductID = value; }
		}

		private void _FillNow()
		{
			_ProductID = Product.ProductID;
			laProductName.Text = Product.ProductName;
			laCategory.Text = Product.Category.CategoryName;
			laPrice.Text = Product.Price.ToString() + "$";
			laPrice.ForeColor = Color.Green;
			pbProduct.ImageLocation = Product.Image;
		}

		public void LoadProductByID(int ProductID)
		{
			Product = ClsProducts.FindID(ProductID);

			if(Product == null)
			{
				MessageBox.Show("No Product With ["+ProductID.ToString()+"]","Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNow();
		}

		private void btnView_Click(object sender, EventArgs e)
		{
		    frmShowDetails frmProducts = new frmShowDetails(_ProductID);
			frmProducts.ShowDialog();
		}
	}
}
