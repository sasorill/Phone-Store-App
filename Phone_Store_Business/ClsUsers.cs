using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsUsers
	{
		public enum enMode { AddNew = 0, Update = 1 };

		private enMode _Mode = enMode.AddNew;

		public int UserID { get; set; }
		public int PersonID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }

		public ClsPeople ClsPeople;

		public ClsUsers(int UserID,int PersonID, string UserName, string Password, bool IsActive)
		{
			this.UserID = UserID;
			this.PersonID = PersonID;
			this.ClsPeople = ClsPeople.FindID(PersonID);
			this.UserName = UserName;
			this.Password = Password;
			this.IsActive = IsActive;
			_Mode = enMode.Update;
		}

		public ClsUsers()
		{
			_Mode = enMode.AddNew;
		}

		private bool _AddNewUser()
		{
			this.UserID = ClsUserAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
			return (this.PersonID != -1);
		}

		private bool _UpdateUser()
		{
			return ClsUserAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:
					if (_AddNewUser())
					{
						_Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.Update:
					return _UpdateUser();
			}
			return false;
		}

		public static ClsUsers FindID(int UserID)
		{
			int PersonID = -1;
			string UserName = "", Password = "";
			bool IsActive = false;
			if (ClsUserAccess.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
			{
				return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
			}
			else
				return null;
		}

		public static ClsUsers FindByPerson(int PersonID)
		{
			int UserID = -1;
			string UserName = "", Password = "";
			bool IsActive = false;
			if (ClsUserAccess.GetUserByPersonID(ref UserID,  PersonID, ref UserName, ref Password, ref IsActive))
			{
				return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
			}
			else
				return null;
		}

		public static ClsUsers Find(string UserName)
		{
			int PersonID = -1, UserID = -1;
			string  Password = "";
			bool IsActive = false;
			if (ClsUserAccess.GetUserByUserName(ref UserID, ref PersonID,  UserName, ref Password, ref IsActive))
			{
				return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
			}
			else
				return null;
		}

		public static DataTable GetAllUsers()
		{
			return ClsUserAccess.GetAllUsers();
		}

		public static DataTable GetAllActiveUsers()
		{
			return ClsUserAccess.GetAllActiveUsers();
		}

		public static DataTable GetAllUnActiveUsers()
		{
			return ClsUserAccess.GetAllUnActiveUsers();
		}

		public bool Delete()
		{
			return ClsUserAccess.DeleteUser(this.UserID);
		}

		public static bool ActivateUser(int UserID)
		{
			return ClsUserAccess.ActivateUser(UserID);
		}

		public static bool UnActiveUser(int UserID)
		{
			return ClsUserAccess.UnActivateUser(UserID);
		}

		public static ClsUsers FindUserNamePassword(string UserName,string Password)
		{
			int UserID = -1, PersonID = -1;
			bool IsActive = false;
			if (ClsUserAccess.FindUserByUserNameAndPassword(ref UserID, ref PersonID, UserName, Password, ref IsActive))  
			{
				return new ClsUsers(UserID, PersonID, UserName, Password, IsActive);
			}
			else
			{
				return null;
			}
		}


	}
}
