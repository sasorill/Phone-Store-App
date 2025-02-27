using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsCountries
	{

		public int CountryID { get; set; }
		public string CountryName { get; set; }

		public ClsCountries(int CountryID ,string CountryName)
		{
			this.CountryID = CountryID;
			this.CountryName = CountryName;
		}

		public static ClsCountries Find(int CountryID)
		{
			string CountryName = "";
			if (ClsCountriesAccess.GetCountryByID(CountryID, ref CountryName))
			{
				return new ClsCountries(CountryID, CountryName);
			}
			else
				return null;
		}

		public static ClsCountries Find(string CountryName)
		{
			int CountryID = -1;
			if (ClsCountriesAccess.GetCountryByName(ref CountryID, CountryName)) 
			{
				return new ClsCountries(CountryID, CountryName);
			}
			else
				return null;
		}

		public static DataTable GetAllCountry()
		{
			return ClsCountriesAccess.GetAllCountries();
		}

	}
}
