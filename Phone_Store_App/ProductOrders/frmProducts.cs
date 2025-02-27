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
using System.Windows.Forms.DataVisualization.Charting;

namespace Phone_Store_App
{
	public partial class frmProducts : Form
	{
		private static DataTable dataGrid = ClsProducts.GetAllProducts();
		
		public frmProducts()
		{
			InitializeComponent();
		}

		private ClsPeople Product;

		private int _ProductID = -1;
	
		private void _RefreshAllProduct()
		{
			dgvProduct.DataSource = dataGrid;

			_ProductID = (int)dgvProduct.CurrentRow.Cells[0].Value;
		}

		private void frmProducts_Load(object sender, EventArgs e)
		{
			_RefreshAllProduct();
		}

		private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateProduct frmAddUpdate = new frmAddUpdateProduct();
			frmAddUpdate.ShowDialog();
			_RefreshAllProduct();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateProduct frmAddUpdate = new frmAddUpdateProduct((int)_ProductID);
			frmAddUpdate.ShowDialog();
			_RefreshAllProduct();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClsProducts Products = ClsProducts.FindID(_ProductID);

			if(Products != null)
			{
				if(MessageBox.Show("Are You Sure You want to Delete Product?","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
				{
					if(Products.Delete())
					{
						MessageBox.Show("Delete Cell Succeeded","Successfully",MessageBoxButtons.OK, MessageBoxIcon.Information);
						_RefreshAllProduct();
					}
					else
					{
						MessageBox.Show("Delete Cell Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}

		private void findProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFindProduct product = new frmFindProduct();
			product.ShowDialog();
		}

		private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
		{
			frmShowDetails product = new frmShowDetails((int)dgvProduct.CurrentRow.Cells[0].Value);
			product.ShowDialog();
			_RefreshAllProduct();
		}
	}
}
