using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsProductAccess
	{
		public static DataTable GetAllProducts()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllProducts";

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

		public static bool GetProductByID(int ProductID1, ref string ProductName1, ref int Category1, ref DateTime MakeDate1, ref int Country1, ref int Colour1, ref int Price1, ref string Image1, ref string Description1)
		{
			string Query = @"exec SP_GetProductByID @ProductID = @ProductID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ProductID1", ProductID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							ProductName1 = (string)Reader["ProductName"];
							Category1 = (int)Reader["Category"];
							MakeDate1 = (DateTime)Reader["MakeDate"];
							Country1 = (int)Reader["Country"];
							Colour1 = (int)Reader["Colour"];
							Price1 = (int)Reader["Price"];

							if (Reader["Description"] != DBNull.Value) 
							{
								Description1 = (string)Reader["Description"];
							}
							else
							{
								Description1 = "";
							}
							if (Reader["Image"] != DBNull.Value)
							{
								Image1 = (string)Reader["Image"];
							}
							else
							{
								Image1 = "";
							}

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

		public static bool GetProductByName(ref int ProductID1,  string ProductName1, ref int Category1, ref DateTime MakeDate1, ref int Country1, ref int Colour1, ref int Price1, ref string Image1, ref string Description1)
		{
			string Query = @"exec SP_GetProductByName @ProductName = @ProductName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ProductName1", ProductName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							ProductID1 = (int)Reader["ProductID"];
							Category1 = (int)Reader["Category"];
							MakeDate1 = (DateTime)Reader["MakeDate"];
							Country1 = (int)Reader["Country"];
							Colour1 = (int)Reader["Colour"];
							Price1 = (int)Reader["Price"];

							if (Reader["Description"] != DBNull.Value)
							{
								Description1 = (string)Reader["Description"];
							}
							else
							{
								Description1 = "";
							}
							if (Reader["Image"] != DBNull.Value)
							{
								Image1 = (string)Reader["Image"];
							}
							else
							{
								Image1 = "";
							}

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

		public static bool GetProductByCategory(ref int ProductID1, ref string ProductName1,  int Category1, ref DateTime MakeDate1, ref int Country1, ref int Colour1, ref int Price1, ref string Image1, ref string Description1)
		{
			string Query = @"exec SP_GetProductByCategory @Category = @Category1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@Category1", Category1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							ProductName1 = (string)Reader["ProductName"];
							ProductID1 = (int)Reader["ProductID"];
							MakeDate1 = (DateTime)Reader["MakeDate"];
							Country1 = (int)Reader["Country"];
							Colour1 = (int)Reader["Colour"];
							Price1 = (int)Reader["Price"];

							if (Reader[Description1] != null)
							{
								Description1 = (string)Reader["Description"];
							}
							else
							{
								Description1 = "";
							}
							if (Reader[Image1] != null)
							{
								Image1 = (string)Reader["Image"];
							}
							else
							{
								Image1 = "";
							}

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

		public static int AddNewProducts(string ProductName1, int Category1, DateTime MakeDate1, int Country1, int ColourID1, float Price1, string Image1, string Description1)
		{
			string Query = @"exec SP_AddNewProduct 
                           @ProductName = @ProductName1,
                           @Category = @Category1,
                           @MakeDate = @MakeDate1,
                           @Country = @Country1,
                           @Colour = @ColourID1,
                           @Price = @Price1,
                           @Image = @Image1,
                           @Description = @Description1";


			int ProductID1 = -1;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ProductName1", ProductName1);
					Command.Parameters.AddWithValue("@Category1", Category1);
					Command.Parameters.AddWithValue("@MakeDate1", MakeDate1);
					Command.Parameters.AddWithValue("@Country1", Country1);
					Command.Parameters.AddWithValue("@ColourID1", ColourID1);
					Command.Parameters.AddWithValue("@Price1", Price1);
					if (Image1 != null)
					{
						Command.Parameters.AddWithValue("@Image1", Image1);
						
					}
					else
					{
						Command.Parameters.AddWithValue("@Image1", System.DBNull.Value);
						
					}

					if (Description1 != null)
					{
						Command.Parameters.AddWithValue("@Description1", Description1);
					}
					else
					{
						Command.Parameters.AddWithValue("@Description1", System.DBNull.Value);
					}

					

					object Result = Command.ExecuteScalar();

					if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
					{
						ProductID1 = InsertID;
					}
				}
			}
			return ProductID1;
		}

		public static bool UpdateProduct(int ProductID1, string ProductName1, int Category1, DateTime MakeDate1, int Country1, int Colour1, float Price1, string Image1, string Description1)
		{
			string Query = @"exec SP_UpdateProduct 
                          
                           @ProductName = @ProductName1,
                           @Category = @Category1,
                           @MakeDate = @MakeDate1,
                           @Country = @Country1,
                           @Colour = @Colour1,
                           @Price = @Price1,
                           @Image = @Image1,
                           @Description = @Description1,
                           @ProductID = @ProductID1";

			int EffectRow = 0;
			

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ProductID1", ProductID1);
					Command.Parameters.AddWithValue("@ProductName1", ProductName1);
					Command.Parameters.AddWithValue("@Category1", Category1);
					Command.Parameters.AddWithValue("@MakeDate1", MakeDate1);
					Command.Parameters.AddWithValue("@Country1", Country1);
					Command.Parameters.AddWithValue("@Colour1", Colour1);
					Command.Parameters.AddWithValue("@Price1", Price1);
					if (Image1 != "" && Image1 != null) 
					{
						Command.Parameters.AddWithValue("@Image1", Image1);

					}
					else
					{
						Command.Parameters.AddWithValue("@Image1", System.DBNull.Value);

					}

					if (Description1 != null && Description1 != "") 
					{
						Command.Parameters.AddWithValue("@Description1", Description1);
					}
					else
					{
						Command.Parameters.AddWithValue("@Description1", System.DBNull.Value);
					}

					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

		public static bool DeleteProduct(int ProductID1)
		{
			string Query = @"exec SP_DeleteProduct @ProductID = @ProductID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@ProductID1", ProductID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}
	}
}
