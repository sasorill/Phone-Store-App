using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phone_Store_Business;

namespace Phone_Store_App
{
	public partial class frmAllCategories : Form
	{
		public frmAllCategories()
		{
			InitializeComponent();
		}

		private void _RefreshAllCategory()
		{
			dgvAllCategories.DataSource = ClsCategories.GetAllCategories();
			
		}

		private void frmAllCategories_Load(object sender, EventArgs e)
		{
			_RefreshAllCategory();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
