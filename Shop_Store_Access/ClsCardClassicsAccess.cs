using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsCardClassicsAccess
	{
		public static DataTable GetAllCardsClassics()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllCardsClassics";

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

		public static bool GetCardClassicByID(int ClassID1, ref string ClassName1)
		{
			string Query = @"exec SP_GetCardClassicByID @ClassID = @ClassID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ClassID1", ClassID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							ClassName1 = (string)Reader["ClassicName"];

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

		public static bool GetCardClassicByName(ref int ClassID1, string ClassName1)
		{
			string Query = @"exec SP_GetCardClassicByName @ClassName = @ClassName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ClassName1", ClassName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							ClassID1 = (int)Reader["ClassicID"];

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
