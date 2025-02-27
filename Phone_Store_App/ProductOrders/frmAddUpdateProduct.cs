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
	public partial class frmAddUpdateProduct : Form
	{
		public  delegate void DataBackHandler(object sender, int ProductID);

		public event DataBackHandler DataBack;

		private int _ProductID = -1;

		private ClsProducts _Product;

		public enum enMode {AddNew = 0, Update=1};

		private enMode _Mode = enMode.AddNew;

		public frmAddUpdateProduct(int productID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			_ProductID = productID;
		}

		public frmAddUpdateProduct()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		private void _LoadCategoriesInComboBox()
		{
			DataTable dtCategory = ClsCategories.GetAllCategories();

			foreach (DataRow Row in dtCategory.Rows) 
			{
				cbCategories.Items.Add(Row["CategoryName"]);
			}
		}

		private void _LoadCountriesInComboBox()
		{
			DataTable dtCountry = ClsCountries.GetAllCountry();

			foreach (DataRow Row in dtCountry.Rows)
			{
				cbCountry.Items.Add(Row["Name"]);
			}
		}

		private void _LoadColorInComboBox()
		{
			DataTable dtColors = ClsColor.GetAllColors();

			foreach (DataRow Row in dtColors.Rows)
			{
				cbColor.Items.Add(Row["ColourName"]);
			}
		}

		private void _defaultView()
		{
			_LoadCategoriesInComboBox();
			_LoadCountriesInComboBox();
			_LoadColorInComboBox();
			if (_Mode == enMode.AddNew) 
			{
				this.Text = "Add New Product";
				_Product = new ClsProducts();
			}
			else
			{
				this.Text = "Update Product";
			}
		}

		private void _FillProductInfo()
		{
			laProducID.Text = _ProductID.ToString();
			txtProductName.Text = _Product.ProductName;
			cbCategories.SelectedIndex = cbCategories.FindString(_Product.Category.CategoryName);
			dtpMakeDate.Value = _Product.MakeDate;
			cbColor.SelectedIndex = cbColor.FindString(_Product.Color.ColorName);
			cbCountry.SelectedIndex = cbCountry.FindString(_Product.Country.CountryName);
		    txtPrice.Text = _Product.Price.ToString();
			rtxtDescription.Text = _Product.Description;
			pbProduct.ImageLocation = _Product.Image;
		}

		private void _LoadProductInfo()
		{
			_Product = ClsProducts.FindID(_ProductID);

			if (_Product == null)
			{
				MessageBox.Show("No Product With ["+_ProductID.ToString()+"]","Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillProductInfo();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!this.ValidateChildren())
			{
				MessageBox.Show("Some Children Are Not Correct","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			_Product.ProductName = txtProductName.Text;
			_Product.CategoryID = ClsCategories.Find(cbCategories.Text).CategoryID;
			_Product.MakeDate = dtpMakeDate.Value;
			_Product.CountryID = ClsCountries.Find(cbCountry.Text).CountryID;
			_Product.ColorID = ClsColor.Find(cbColor.Text).ColorID;
			_Product.Price = Convert.ToInt32(txtPrice.Text);
			_Product.Description = rtxtDescription.Text;
			if (pbProduct.ImageLocation == null) 
			{
				_Product.Image = null;
			}
			else
			{
				_Product.Image = pbProduct.ImageLocation;
			}

			if(_Product.Save())
			{
				laProducID.Text = _Product.ProductID.ToString();
				_Mode = enMode.Update;
				this.Text = "Update Product";
				MessageBox.Show("Save Succeeded", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Save Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.Filter = "All Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK) 
			{
				pbProduct.Load(openFileDialog1.FileName);
			}
		}

		private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			pbProduct.ImageLocation = null;
		}

		private void frmAddUpdateProduct_Load(object sender, EventArgs e)
		{
			_defaultView();
			if (_Mode == enMode.Update)
				_LoadProductInfo();
		}
	}
}
