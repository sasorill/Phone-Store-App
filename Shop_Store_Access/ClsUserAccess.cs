using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
	public class ClsUserAccess
	{
		public static DataTable GetAllUsers()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllUsers";

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

		public static DataTable GetAllActiveUsers()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllActiveUsers";

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

		public static DataTable GetAllUnActiveUsers()
		{
			DataTable dt = new DataTable();

			string Query = @"exec SP_GetAllUsers";

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

		public static bool GetUserByID(int UserID1,ref int PersonID1,ref string UserName1,ref string Password1,ref bool IsActive1)
		{
			string Query = @"exec SP_GetUserByID @UserID = @UserID1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserID1", UserID1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID1 = (int)Reader["PersonID"];
							UserName1 = (string)Reader["UserName"];
							Password1 = (string)Reader["Password"];
							IsActive1 = (bool)Reader["IsActive"];
							

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

		public static bool GetUserByPersonID(ref int UserID1,  int PersonID1, ref string UserName1, ref string Password1, ref bool IsActive1)
		{
			string Query = @"exec SP_GetUserByPersonID @PersonID = @PersonID1";

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
							UserID1 = (int)Reader["UserID"];
							UserName1 = (string)Reader["UserName"];
							Password1 = (string)Reader["Password"];
							IsActive1 = (bool)Reader["IsActive"];


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

		public static bool GetUserByUserName(ref int UserID1, ref int PersonID1, string UserName1, ref string Password1, ref bool IsActive1)
		{
			string Query = @"exec SP_GetUserByName @UserName = @UserName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserName1", UserName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID1 = (int)Reader["PersonID"];
							UserID1 = (int)Reader["UserID"];
							Password1 = (string)Reader["Password"];
							IsActive1 = (bool)Reader["IsActive"];


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

		public static int AddNewUser(int PersonID1 , string UserName1,string Password1,bool IsActive1)
		{
			string Query = @"exec SP_AddNewUser
                            @PersonID = @PersonID1,
                            @UserName = @UserName1,
                            @Password = @Password1,
                            @IsActive = @IsActive1";

			int UserID1 = -1;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@UserName1", UserName1);
					Command.Parameters.AddWithValue("@Password1", Password1);
					Command.Parameters.AddWithValue("@IsActive1", IsActive1);

					object Result = Command.ExecuteScalar();

					if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
					{
						UserID1 = InsertID;
					}
				}
			}
			return UserID1;
		}

		public static bool UpdateUser(int UserID1,int PersonID1, string UserName1, string Password1, bool IsActive1)
		{
			string Query = @"exec SP_UpdateUser
                           @PersonID = @PersonID1,
                           @UserName = @UserName1,
                           @Password = @Password1,
                           @IsActive = @IsActive1,
                           @UserID = @UserID1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserID1", UserID1);
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@UserName1", UserName1);
					Command.Parameters.AddWithValue("@Password1", Password1);
					Command.Parameters.AddWithValue("@IsActive1", IsActive1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; 
		}

		public static bool DeleteUser(int UserID1)
		{
			string Query = @"exec SP_DeleteUser @UserID = @UserID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserID1", UserID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

		public static bool ActivateUser(int UserID1)
		{
			string Query = @"exec SP_ActivateUser @UserID = @UserID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserID1", UserID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

		public static bool UnActivateUser(int UserID1)
		{
			string Query = @"exec SP_UnActivateUser @UserID = @UserID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserID1", UserID1);

					EffectRow = Command.ExecuteNonQuery();

				}
			}
			return EffectRow > 0; ;
		}

		public static bool FindUserByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName1, string Password1, ref bool IsActive)
		{
			string Query = @"exec SP_FindUserByUserNameAndPassword @UserName = @UserName1 ,@Password = @Password1";


			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@UserName1", UserName1);
					Command.Parameters.AddWithValue("Password1", Password1);

					using(SqlDataReader Reader = Command.ExecuteReader())
					{
						if(Reader.Read())
						{
							IsFound = true;
							UserID = (int)Reader["UserID"];
							PersonID = (int)Reader["PersonID"];
							IsActive = (bool)Reader["IsActive"];
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
