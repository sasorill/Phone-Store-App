using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsCreditCardAccess
	{
		public static DataTable GetAllCards()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllCards";

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

		public static DataTable GetAllActiveCards()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllActiveCards";

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

		public static DataTable GetAllUnActiveCards()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllUnActiveCards";

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

		public static bool GetCardByID(int CardID1, ref int PersonID1, ref string CardNumber1, ref string CardCVC1, ref bool IsActive1,ref int CardClassicID,ref DateTime StartDate,ref DateTime EndDate)
		{
			string Query = @"exec SP_GetCardByID @CardID = @CardID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardID1", CardID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID1 = (int)Reader["PersonID"];
							CardNumber1 = (string)Reader["CardNumber"];
							CardCVC1 = (string)Reader["CardCVC"];
							IsActive1 = (bool)Reader["IsActive"];
							CardClassicID = (int)Reader["CardClassicID"];
							StartDate = (DateTime)Reader["StartDate"];
							EndDate = (DateTime)Reader["EndDate"];

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

		public static bool GetCardByPersonID(ref int CardID1,  int PersonID1, ref string CardNumber1, ref string CardCVC1, ref bool IsActive1, ref int CardClassicID, ref DateTime StartDate, ref DateTime EndDate)
		{
			string Query = @"exec SP_GetCardByPersonID @PersonID = @PersonID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							CardNumber1 = (string)Reader["CardNumber"];
							CardCVC1 = (string)Reader["CardCVC"];
							CardID1 = (int)Reader["CardID"];
							IsActive1 = (bool)Reader["IsActive"];
							CardClassicID = (int)Reader["CardClassicID"];
							StartDate = (DateTime)Reader["StartDate"];
							EndDate = (DateTime)Reader["EndDate"];


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

		public static bool GetCardByCardNumber(ref int CardID1, ref int PersonID1,  string CardNumber1, ref string CardCVC1, ref bool IsActive1, ref int CardClassicID, ref DateTime StartDate, ref DateTime EndDate)
		{
			string Query = @"exec SP_GetCardByCardNumber @CardNumber = @CardNumber1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardNumber1", CardNumber1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID1 = (int)Reader["PersonID"];
							CardID1 = (int)Reader["CardID"];
							CardCVC1 = (string)Reader["CardCVC"];
							IsActive1 = (bool)Reader["IsActive"];
							CardClassicID = (int)Reader["CardClassicID"];
							StartDate = (DateTime)Reader["StartDate"];
							EndDate = (DateTime)Reader["EndDate"];

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

		public static int AddNewCard(int PersonID1, string CardNumber1, string CardCVC1, bool IsActive1, int ClassID1,  DateTime StartDate1,  DateTime EndDate1)
		{
			string Query = @"exec SP_AddNewCard
                            @PersonID = @PersonID1,
                            @CardNumber = @CardNumber1,
                            @CardCVC = @CardCVC1,
                            @IsActive = @IsActive1,
                            @ClassID = @ClassID1,
                            @StartDate = @StartDate1,
                            @EndDate = @EndDate1";

			int CardID1 = -1;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@CardNumber1", CardNumber1);
					Command.Parameters.AddWithValue("@CardCVC1", CardCVC1);
					Command.Parameters.AddWithValue("@IsActive1", IsActive1);
					Command.Parameters.AddWithValue("@ClassID1", ClassID1);
					Command.Parameters.AddWithValue("@StartDate1", StartDate1);
					Command.Parameters.AddWithValue("@EndDate1", EndDate1);

					object Result = Command.ExecuteScalar();

					if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
					{
						CardID1 = InsertID;
					}
				}
			}
			return PersonID1;
		}

		public static bool UpdateCard(int CardID1, int PersonID1, string CardNumber1, string CardCVC1, bool IsActive1, int ClassID1, DateTime StartDate1, DateTime EndDate1)
		{
			string Query = @"exec SP_UpdateUser
                           @PersonID = @PersonID1,
                           @CardNumber = @CardNumber1,
                           @CardCVC = @CardCVC1,
                           @IsActive = @IsActive1,
                           @ClassID = @ClassID1,
                           @StartDate = @StartDate1,
                           @EndDate = @EndDate1,
                           @CardID = @CardID1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardID1", CardID1);
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@CardNumber1", CardNumber1);
					Command.Parameters.AddWithValue("@CardCVC1", CardCVC1);
					Command.Parameters.AddWithValue("@IsActive1", IsActive1);
					Command.Parameters.AddWithValue("@ClassID1", ClassID1);
					Command.Parameters.AddWithValue("@StartDate1", StartDate1);
					Command.Parameters.AddWithValue("@EndDate1", EndDate1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0;
		}

		public static bool DeleteCard(int CardID1)
		{
			string Query = @"exec SP_DeleteCard @CardID = @CardID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardID1", CardID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

		public static bool ActivateCard(int CardID1)
		{
			string Query = @"exec SP_ActivateCard @CardID = @CardID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardID1", CardID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

		public static bool UnActivateCard(int CardID1)
		{
			string Query = @"exec SP_UnActivateCard @CardID = @CardID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@CardID1", CardID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}
	}
}
