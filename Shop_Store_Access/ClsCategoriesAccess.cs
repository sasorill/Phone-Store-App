using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsCategoriesAccess
	{
		public static DataTable GetAllCategories()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllCategories";

			using (SqlConnection Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
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

		public static bool GetCategoryID(int CategoryID1, ref string CategoryName1)
		{
			string Query = @"exec SP_GetCategoryByID @CategoryID = @CategoryID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CategoryID1", CategoryID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							CategoryName1 = (string)Reader["CategoryName"];

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

		public static bool GetCategoryByName(ref int CategoryID1, string CategoryName1)
		{
			string Query = @"exec SP_GetCategoryByName @CategoryName = @CategoryName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CategoryName1", CategoryName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							CategoryID1 = (int)Reader["CategoryID"];

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
