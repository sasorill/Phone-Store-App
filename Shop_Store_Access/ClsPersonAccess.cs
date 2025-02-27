using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_Access
{
    public class ClsPersonAccess
    {
        
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            string Query = @"exec SP_GetAllPeople";

            using(var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
            {
				Connection.Open();
                using(var Command = new SqlCommand(Query, Connection))
                {
                    using(var Reader = Command.ExecuteReader())
                    {
                        if(Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                }
            }
            return dt;
        }

        public static bool GetPersonByID(int PersonID1,ref string FirstName,ref string SecondName,ref string LastName,ref DateTime DateOfBirth,ref int CountryID,ref string City,ref string Email,ref string Password,ref string Phone,ref string Image)
        {
            string Query = @"exec SP_FindPersonByID @PersonID = @PersonID1";

            bool IsFound = false;

            using(var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
            {
				Connection.Open();
                using(var Command = new SqlCommand(Query,Connection))
                {
                    Command.Parameters.AddWithValue("@PersonID1", PersonID1);

                    using(var Reader = Command.ExecuteReader())
                    {
                        if(Reader.Read())
                        {
                            IsFound = true;
                            FirstName = (string)Reader["FirstName"];
                            SecondName = (string)Reader["SecondName"];
                            LastName = (string)Reader["LastName"];
                            DateOfBirth = (DateTime)Reader["DateOfBirth"];
                            CountryID = (int)Reader["CountryID"];
                            City = (string)Reader["City"];
                            Phone = (string)Reader["Phone"];
							Email = (string)Reader["Email"];
							Password = (string)Reader["Password"];
							
							if (Reader["Image"] != DBNull.Value)
							{
								Image = (string)Reader["Image"];
							}
							else
							{
								Image = "";
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

		public static bool GetPersonByFirstName(ref int PersonID,  string FirstName1, ref string SecondName, ref string LastName, ref DateTime DateOfBirth, ref int CountryID, ref string City, ref string Email, ref string Password, ref string Phone,ref string Image)
		{
			string Query = @"exec SP_FindPersonByFirstName @FirstName = @FirstName1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@FirstName1", FirstName1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
                            PersonID = (int)Reader["PersonID"];
							
							SecondName = (string)Reader["SecondName"];
							LastName = (string)Reader["LastName"];
							DateOfBirth = (DateTime)Reader["DateOfBirth"];
							CountryID = (int)Reader["CountryID"];
							City = (string)Reader["City"];
							Phone = (string)Reader["Phone"];
							Email = (string)Reader["Email"];
							Password = (string)Reader["Password"];

							if (Reader[Image] != null)
							{
								Image = (string)Reader["Image"];
							}
							else
							{
								Image = "";
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

		public static bool GetPersonByEmail(ref int PersonID, ref string FirstName, ref string SecondName, ref string LastName, ref DateTime DateOfBirth, ref int CountryID, ref string City,  string Email1, ref string Password, ref string Phone,ref string Image)
		{
			string Query = @"exec SP_FindPersonByEmail @Email = @Email1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@Email1", Email1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID = (int)Reader["PersonID"];
							FirstName = (string)Reader["FirstName"];
							SecondName = (string)Reader["SecondName"];
							LastName = (string)Reader["LastName"];
							DateOfBirth = (DateTime)Reader["DateOfBirth"];
							CountryID = (int)Reader["CountryID"];
							City = (string)Reader["City"];
							Phone = (string)Reader["Phone"];
							Password = (string)Reader["Password"];
							if (Reader[Image] != null)
							{
								Image = (string)Reader["Image"];
							}
							else
							{
								Image = "";
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

		public static bool GetPersonByPhone(ref int PersonID, ref string FirstName, ref string SecondName, ref string LastName, ref DateTime DateOfBirth, ref int CountryID, ref string City,ref string Email, ref string Password,  string Phone1,ref string Image)
		{
			string Query = @"exec SP_FindPersonByPhone @Phone = @Phone1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@Phone1", Phone1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;

							PersonID = (int)Reader["PersonID"];
							FirstName = (string)Reader["FirstName1"];
							SecondName = (string)Reader["SecondName"];
							LastName = (string)Reader["LastName"];
							DateOfBirth = (DateTime)Reader["DateOfBirth"];
							CountryID = (int)Reader["CountryID"];
							City = (string)Reader["City"];
							Email = (string)Reader["Email"];
							Password = (string)Reader["Password"];
						
							if (Reader["Image"] != null)
							{
								Image = (string)Reader["Image"];
							}
							else
							{
								Image = "";
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

		public static int AddNewPerson(string FirstName1, string SecondName1, string LastName1, DateTime DateOfBirth1, int CountryID1, string City1, string Email1, string Password1, string Phone1, string Image1)
		{
			string Query = @"exec SP_AddNewPerson 
                                     @FirstName = @FirstName1,
			                         @SecondName = @SecondName1, 
			                         @LastName = @LastName1,
			                         @DateOfBirth = @DateOfBirth1,
			                         @CountryID = @CountryID1,
			                         @City = @City1,
			                         @Email = @Email1,
			                         @Password = @Password1,
			                         @Phone = @Phone1,
			                         @Image = @Image1";

			
			int PersonID1 = -1;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@FirstName1", FirstName1);
					Command.Parameters.AddWithValue("@SecondName1",SecondName1);
					Command.Parameters.AddWithValue("@LastName1", LastName1);
					Command.Parameters.AddWithValue("@DateOfBirth1", DateOfBirth1);
					Command.Parameters.AddWithValue("@CountryID1", CountryID1);
					Command.Parameters.AddWithValue("@City1", City1);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);
					Command.Parameters.AddWithValue("@Phone1", Phone1);
					if (Image1 != "" && Image1 != null)
					{
						Command.Parameters.AddWithValue("@Image1", Image1);
					}
					else
					{
						Command.Parameters.AddWithValue("@Image1", System.DBNull.Value);
					}
						
					object Result = Command.ExecuteScalar();

					if (Result != null && int.TryParse(Result.ToString(), out int InsertID)) 
					{
						PersonID1 = InsertID;
					}
				}
			}
			return PersonID1;
		}

		public static bool UpdatePerson(int PersonID1,string FirstName1, string SecondName1, string LastName1, DateTime DateOfBirth1, int CountryID1, string City1, string Email1, string Password1, string Phone1, string Image1)
		{
			string Query = @"exec SP_UpdatePerson
                            @FirstName = @FirstName1,
                            @SecondName = @SecondName1,
                            @LastName = @LastName1,
                            @DateOfBirth = @DateOfBirth1,
                            @CountryID = @CountryID1,
                            @City = @City1,
                            @Email = @Email1,
                            @Password = @Password1,
                            @Phone = @Phone1,
                            @Image = @Image1,
                            @PersonID = @PersonID1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();

				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
					Command.Parameters.AddWithValue("@FirstName1", FirstName1);
					Command.Parameters.AddWithValue("@SecondName1", SecondName1);
					Command.Parameters.AddWithValue("@LastName1", LastName1);
					Command.Parameters.AddWithValue("@DateOfBirth1", DateOfBirth1);
					Command.Parameters.AddWithValue("@CountryID1", CountryID1);
					Command.Parameters.AddWithValue("@City1", City1);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);
					Command.Parameters.AddWithValue("@Phone1", Phone1);

					if (Image1 != null && Image1 != "") 
					{
						Command.Parameters.AddWithValue("@Image1", Image1);
					}
					else
					{
						Command.Parameters.AddWithValue("@Image1", System.DBNull.Value);
					}
					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

		public static bool DeletePerson(int PersonID1)
		{
			string Query = @"exec SP_DeletePerson @PersonID = @PersonID1";


			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@PersonID1", PersonID1);
				
					EffectRow = Command.ExecuteNonQuery();
				
				}
			}
			return EffectRow > 0; ;
		}

		public static bool FindByEmailAndPassword(ref int PersonID1, ref string FirstName, ref string SecondName, ref string LastName, ref DateTime DateOfBirth, ref int CountryID, ref string City,  string Email1,  string Password1, ref string Phone, ref string Image)
		{
			string Query = @"exec SP_FindPersonByEmailAndPassword @Email = @Email1 , @Password = @Password1";

			bool IsFound = false;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);

					using (var Reader = Command.ExecuteReader())
					{
						if (Reader.Read())
						{
							IsFound = true;
							PersonID1 = (int)Reader["PersonID"];
							FirstName = (string)Reader["FirstName"];
							SecondName = (string)Reader["SecondName"];
							LastName = (string)Reader["LastName"];
							DateOfBirth = (DateTime)Reader["DateOfBirth"];
							CountryID = (int)Reader["CountryID"];
							City = (string)Reader["City"];
							Phone = (string)Reader["Phone"];
							if (Reader["Image"] != DBNull.Value) 
							{
								Image = (string)Reader["Image"];
							}
							else
							{
								Image = "";
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

		public static bool EditPersonNameByEmailAndPassword(string FirstName1, string SecondName1, string LastName1, string Email1, string Password1)
		{
			string Query = @"exec SP_EditPersonName @FirstName = @FirstName1 , @SecondName = @SecondName1 ,
			                          @LastName = @LastName1 , @Email = @Email1 , @Password = @Password1";



			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@FirstName1", FirstName1);
					Command.Parameters.AddWithValue("@SecondName1", SecondName1);
					Command.Parameters.AddWithValue("@LastName1", LastName1);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);

					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

		public static bool EditPersonEmailByEmailAndPassword(string NewEmail,string Email1, string Password1)
		{
			string Query = @"exec SP_EditPersonEmail @NewEmail = @NewEmail , @Email = @Email1 , @Password = @Password1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@NewEmail", NewEmail);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);

					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

		public static bool EditPersonPasswordByEmailAndPassword(string NewPassword1,string Email1, string Password1)
		{
			string Query = @"exec SP_EditPersonPassword @NewPassword = @NewEmail, @Email = @Email1 , @Password = @Password1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@NewEmail", NewPassword1);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);

					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

		public static bool EditPersonPhoneByEmailAndPassword(string Phone1, string Email1, string Password1)
		{
			string Query = @"exec SP_EditPersonPhone @Phone = @Phone1 , @Email = @Email1 , @Password = @Password1";

			int EffectRow = 0;

			using (var Connection = new SqlConnection(ClsConnectionToDB.ConnectionCommand))
			{
				Connection.Open();
				using (var Command = new SqlCommand(Query, Connection))
				{
					Command.Parameters.AddWithValue("@Phone1", Phone1);
					Command.Parameters.AddWithValue("@Email1", Email1);
					Command.Parameters.AddWithValue("@Password1", Password1);

					EffectRow = Command.ExecuteNonQuery();
				}
			}
			return EffectRow > 0;
		}

	}
}
