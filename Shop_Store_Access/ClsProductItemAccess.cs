using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsProductItemAccess
	{

		public static DataTable GetAllProductItems()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllProductItems";

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

		public static bool GetProductItemByID(int ItemID1, ref int OrderID1, ref int ProductID1, ref int PersonID1,ref int Quantity, ref float TotalPrice1,ref int CardID)
		{
			string Query = @"exec SP_GetProductItemsByID @ItemID = @ItemID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ItemID1", ItemID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							OrderID1 = (int)Reader["OrderID"];
							ProductID1 = (int)Reader["ProductID"];
							PersonID1 = (int)Reader["PersonID"];
							Quantity = (int)Reader["Quantity"];
							TotalPrice1 = (float)Reader["TotalPrice"];
							CardID = (int)Reader["CardID"];

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

		public static bool GetProductItemByOrderID(ref int ItemID1,  int OrderID1, ref int ProductID1, ref int PersonID1,ref int Quantity, ref float TotalPrice1,ref int CardID)
		{
			string Query = @"exec SP_GetProductItemsByOrderID @OrderID = @OrderID1";

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
							ItemID1 = (int)Reader["ItemID"];
							ProductID1 = (int)Reader["ProductID"];
							PersonID1 = (int)Reader["PersonID"];
							Quantity = (int)Reader["Quantity"];
							TotalPrice1 = (float)Reader["TotalPrice"];
							CardID = (int)Reader["CardID"];

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

		public static int AddNewProductItems(int ProductID1, int PersonID1, int Quantity1, float TotalPrice1,int CardID1)
		{
			string Query = @"exec SP_AddNewProductItem
                            @ProductID = @ProductID1,
                            @PersonID = @PersonID1,
                            @Quantity = @Quantity1,
                            @TotalPrice = @TotalPrice1,
                            @CardID = @CardID1";

			int ItemID = -1;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					
					Command.Parameters.AddWithValue("@ProductID1", ProductID1);
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@Quantity1", Quantity1);
					Command.Parameters.AddWithValue("@TotalPrice1", TotalPrice1);
					Command.Parameters.AddWithValue("@CardID1", CardID1);

					object Result = Command.ExecuteScalar();

					if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
					{
						ItemID = InsertID;
					}
				}
			}
			return ItemID;
		}

		public static bool DeleteProductIem(int ItemID1)
		{
			string Query = @"exec SP_DeleteProductItem @ItemID = @ItemID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ItemID1", ItemID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

	}
}
