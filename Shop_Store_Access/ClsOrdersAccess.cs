using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsOrdersAccess
	{
		public static DataTable GetAllOrders()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllOrders";

			using (SqlConnection Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (SqlCommand Command = new SqlCommand(Query, Connection))
				{
					using (SqlDataReader Reader = Command.ExecuteReader())
					{
						if (Reader.HasRows && Reader != null) 
						{
							dt.Load(Reader);
						}
					}
				}
			}
			return dt;
		}

		public static bool GetOrderByID(int OrderID1, ref DateTime OrderDate)
		{
			string Query = @"exec SP_GetOrderByID @OrderID = @OrderID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@OrderID1", OrderID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							OrderDate = (DateTime)Reader["OrderDate"];
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
