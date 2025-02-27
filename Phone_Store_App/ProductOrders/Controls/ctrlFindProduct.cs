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
	public partial class ctrlFindProduct : UserControl
	{

		public Action<int> OnFindComplete;

		protected virtual void OnCompleteProduct(int ProductID)
		{
			Action<int> Handler = OnFindComplete;

			if(Handler != null)
			{
				Handler(ProductID);
			}
		}

		public ctrlFindProduct()
		{
			InitializeComponent();
		}

		private void _FilterBy()
		{
			switch(cbFilterBy.Text)
			{
				case "Product ID":
					ctrlProductItem1._LoadProductByID(int.Parse(txtFind.Text));
					break;

				case "Product Name":
					ctrlProductItem1._LoadProductByProductName(txtFind.Text);
					break;

				case "Category ID":
					ctrlProductItem1._LoadProductByCategory(int.Parse(txtFind.Text));
					break;

				default:
					break;
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			//cbFilterBy.SelectedIndex = 0;
			//cbFilterBy.Focus();
			//txtFind.Text.ToLower().Trim();
			//txtFind.Text.ToUpper().Trim();
			if (string.IsNullOrEmpty(txtFind.Text)) 
			{
				txtFind.Text = null;
			}
			else if(string.IsNullOrWhiteSpace(txtFind.Text))
			{
				txtFind.Text = null;
			}
			else
			{
				_FilterBy();
			}
		
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddUpdateProduct frm = new frmAddUpdateProduct();
			frm.DataBack += DataBack;
			frm.ShowDialog();
		}

		private void ctrlFindProduct_Load(object sender, EventArgs e)
		{
			if (ClsUtilizationLogin.Users == null)
			{
				btnAddNew.Visible = false;
			}
		}

		private void DataBack(object sender,int PersonID)
		{
			txtFind.Text += PersonID.ToString();
		}
	}
}
