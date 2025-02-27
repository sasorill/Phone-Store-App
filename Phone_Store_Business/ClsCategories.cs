using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsCategories
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }

		public ClsCategories(int CategoryID, string CategoryName)
		{
			this.CategoryID = CategoryID;
			this.CategoryName = CategoryName;
		}

		public static ClsCategories Find(int CategoryID)
		{
			string CategoryName = "";
			if (ClsCategoriesAccess.GetCategoryID(CategoryID, ref CategoryName))
			{
				return new ClsCategories(CategoryID, CategoryName);
			}
			else
				return null;
		}

		public static ClsCategories Find(string CountryName)
		{
			int CountryID = -1;
			if (ClsCategoriesAccess.GetCategoryByName(ref CountryID, CountryName))
			{
				return new ClsCategories(CountryID, CountryName);
			}
			else
				return null;
		}

		public static DataTable GetAllCategories()
		{
			return ClsCategoriesAccess.GetAllCategories();
		}
	}
}
