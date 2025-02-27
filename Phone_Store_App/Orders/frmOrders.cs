using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class frmOrders : Form
	{
		public frmOrders()
		{
			InitializeComponent();
		}

		private void _RefreshAllOrders()
		{
			dgvOrders.DataSource = ClsOrders.GetAllOrders();
			laCountOrders.Text = dgvOrders.Rows.Count.ToString();
		}

		private void frmOrders_Load(object sender, EventArgs e)
		{
			_RefreshAllOrders();
		}

		private void viewPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPersonDetails frm = new frmPersonDetails((int)dgvOrders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshAllOrders();
		}

		private void viewCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCardDetails frm = new frmCardDetails((int)dgvOrders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshAllOrders();
		}

		private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmShowDetails frm = new frmShowDetails((int)dgvOrders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshAllOrders();
		}

		private void setAsCompleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//dgvOrders.CurrentRow.Cells[0].Value = Color.Green;
			
			dgvOrders.CurrentRow.Cells[0].Value = DataGrid.DefaultForeColor;
			
		}
	}
}
