using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsColourAccess
	{
		public static DataTable GetAllColours()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllColours";

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

		public static bool GetColourByID(int ColourID1, ref string ColourName1)
		{
			string Query = @"exec SP_GetColourByID @ColourID = @ColourID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ColourID1", ColourID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							ColourName1 = (string)Reader["ColourName"];

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

		public static bool GetColourByName(ref int ColourID1, string ColourName1)
		{
			string Query = @"exec SP_GetColourByName @ColourName = @ColourName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ColourName1", ColourName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							ColourID1 = (int)Reader["ColourID"];

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
