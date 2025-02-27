using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsCountriesAccess
	{
		public static DataTable GetAllCountries()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllCountries";

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.HasRows)
						{
							dt.Load(Reader);
						}
					}
				}
			}
			return dt;
		}

		public static bool GetCountryByID(int CountryID1,ref string CountryName1)
		{
			string Query = @"exec SP_GetCountryByID @CountryID = @CountryID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CountryID1", CountryID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							
							CountryName1 = (string)Reader["Name"];
							
						}
						else
						{
							IsFound = false;
						}
					}
				}
			}
			return IsFound;
		}

		public static bool GetCountryByName(ref int CountryID1, string CountryName1)
		{
			string Query = @"exec SP_GetCountryByName @CountryName = @CountryName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CountryName1", CountryName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							CountryID1 = (int)Reader["CountryID"];

						}
						else
						{
							IsFound = false;
						}
					}
				}
			}
			return IsFound;
		}

	}
}
