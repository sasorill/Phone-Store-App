using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsProducts
	{
		public enum enMode { AddNew = 0, Update = 1 };

		private enMode _Mode = enMode.AddNew;


		public int ProductID { get; set; }

		public string ProductName { get; set; }

		public int CategoryID { get; set; }

		public DateTime MakeDate { get; set; }

		public int CountryID { get; set; }

		public int ColorID { get; set; }

		public int Price { get; set; }

		public string Description { get; set; }

		public string Image { get; set; }

		public ClsCategories Category;

		public ClsColor Color;

		public ClsCountries Country;

		public ClsProducts(int ProductID, string ProductName, int CategoryID,
			DateTime MakeDate, int CountryID, int ColorID, int Price, string Description, string Image)
		{
			this.ProductID = ProductID;
			this.ProductName = ProductName;
			this.CategoryID = CategoryID;
			this.MakeDate = MakeDate;
			this.CountryID = CountryID;
			this.Category = ClsCategories.Find(CategoryID);
			this.Color = ClsColor.Find(ColorID);
			this.Country = ClsCountries.Find(CountryID);
			this.ColorID = ColorID;
			this.Price = Price;
			this.Description = Description;
			this.Image = Image;
			_Mode = enMode.Update;
		}

		public ClsProducts()
		{
			_Mode = enMode.AddNew;
		}

		private bool _AddNewProduct()
		{
			this.ProductID = ClsProductAccess.AddNewProducts(this.ProductName,this.CategoryID,this.MakeDate,this.CountryID,this.ColorID,this.Price,this.Image,this.Description);
			return (this.ProductID != -1);
		}

		private bool _UpdateProduct()
		{
			return ClsProductAccess.UpdateProduct(this.ProductID,this.ProductName, this.CategoryID, this.MakeDate, this.CountryID, this.ColorID, this.Price, this.Image, this.Description);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:
					if (_AddNewProduct())
					{
						_Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.Update:
					return _UpdateProduct();
			}
			return false;
		}

		public static ClsProducts FindID(int ProductID)
		{
			int CategoryID = -1, ColorID = -1, CountryID = -1, Price = -1;
			
			string ProductName = "", Description = "", Image = "";
			DateTime MakeDate = DateTime.Now;
			if (ClsProductAccess.GetProductByID(ProductID, ref ProductName, ref CategoryID, ref MakeDate, ref CountryID, ref ColorID, ref Price, ref Image, ref Description))
			{
				return new ClsProducts(ProductID, ProductName, CategoryID, MakeDate, CountryID, ColorID, Price, Description, Image);
			}
			else
				return null;
		}

		public static ClsProducts FindName(string ProductName)
		{
			int CategoryID = -1, ColorID = -1, CountryID = -1, ProductID = -1, Price = -1;
			
			string  Description = "", Image = "";
			DateTime MakeDate = DateTime.Now;
			if (ClsProductAccess.GetProductByName(ref ProductID,  ProductName, ref CategoryID, ref MakeDate, ref CountryID, ref ColorID, ref Price, ref Image, ref Description))
			{
				return new ClsProducts(ProductID, ProductName, CategoryID, MakeDate, CountryID, ColorID, Price, Description, Image);
			}
			else
				return null;
		}

		public static ClsProducts FindByCategoryID(int CategoryID)
		{
			int ProductID = -1, ColorID = -1, CountryID = -1, Price = -1;
			
			string ProductName = "", Description = "", Image = "";
			DateTime MakeDate = DateTime.Now;
			if (ClsProductAccess.GetProductByCategory(ref ProductID,ref ProductName,  CategoryID, ref MakeDate, ref CountryID, ref ColorID, ref Price, ref Image, ref Description))
			{
				return new ClsProducts(ProductID, ProductName, CategoryID, MakeDate, CountryID, ColorID, Price, Description, Image);
			}
			else
				return null;
		}

		public static DataTable GetAllProducts()
		{
			return ClsProductAccess.GetAllProducts();
		}

		public bool Delete()
		{
			return ClsProductAccess.DeleteProduct(this.ProductID);
		}

	}
}
