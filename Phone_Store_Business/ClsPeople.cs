using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
    public class ClsPeople
    {
        public enum enMode { AddNew=0,Update=1};

        private enMode _Mode = enMode.AddNew;


        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName {  get; set; }
        public string LastName {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID {  get; set; }
        public string City {  get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string Phone {  get; set; }
        public string Image {  get; set; }

        public ClsCountries Country;

        public ClsPeople(int PersonID, string FirstName, string SecondName, string LastName,
            DateTime DateOfBirth, int CountryID, string City, string Email, string Password, string Phone, string Image)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.Country = ClsCountries.Find(CountryID);
            this.City = City;
            this.Email = Email;
            this.Password = Password;
            this.Phone = Phone;
            this.Image = Image;
            _Mode = enMode.Update;
        }

        public ClsPeople()
        {
            this.FirstName = null;
            this.SecondName = null;
            this.LastName = null;
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.City = null;
            this.Email = null;
            this.Password = null;
            this.Phone = null;
            this.Image = null;
            _Mode = enMode.AddNew;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = ClsPersonAccess.AddNewPerson(this.FirstName, this.SecondName, this.LastName, this.DateOfBirth, this.CountryID, this.City, this.Email, this.Password, this.Phone, this.Image);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
			return ClsPersonAccess.UpdatePerson(this.PersonID,this.FirstName, this.SecondName, this.LastName, this.DateOfBirth, this.CountryID, this.City, this.Email, this.Password, this.Phone, this.Image);
		}

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }

        public static ClsPeople FindID(int PersonID)
        {
            int CountryID = -1;
            string FirstName = "", SecondName = "", LastName = ""
                , Email = "", Password = "", Phone = "", Image = "", City = "";
            DateTime DateOfBirth = DateTime.Now;
            if (ClsPersonAccess.GetPersonByID(PersonID,ref FirstName,ref SecondName,ref LastName,ref DateOfBirth,ref CountryID,ref City,ref Email,ref Password,ref Phone,ref Image))
            {
                return new ClsPeople(PersonID, FirstName, SecondName, LastName, DateOfBirth, CountryID, City, Email, Password, Phone, Image);
            }
            else
            {
                return null;
            }
        }

		public static ClsPeople FindFirstName(string FirstName)
		{
            int CountryID = -1, PersonID = -1;
			string   SecondName = "", LastName = ""
				, Email = "", Password = "", Phone = "", Image = "", City = "";
			DateTime DateOfBirth = DateTime.Now;
			if (ClsPersonAccess.GetPersonByFirstName(ref PersonID,  FirstName, ref SecondName, ref LastName, ref DateOfBirth, ref CountryID, ref City, ref Email, ref Password, ref Phone, ref Image))
			{
				return new ClsPeople(PersonID, FirstName, SecondName, LastName, DateOfBirth, CountryID, City, Email, Password, Phone, Image);
			}
			else
			{
				return null;
			}
		}

		public static ClsPeople FindEmail(string Email)
		{
            int CountryID = -1, PersonID = -1;
			string FirstName = "", SecondName = "", LastName = ""
				, Password = "", Phone = "", Image = "", City = "";
			DateTime DateOfBirth = DateTime.Now;
			if (ClsPersonAccess.GetPersonByEmail(ref PersonID, ref FirstName, ref SecondName, ref LastName, ref DateOfBirth, ref CountryID, ref City,  Email, ref Password, ref Phone, ref Image))
			{
				return new ClsPeople(PersonID, FirstName, SecondName, LastName, DateOfBirth, CountryID, City, Email, Password, Phone, Image);
			}
			else
			{
				return null;
			}
		}

		public static ClsPeople FindPhone(string Phone)
		{
            int CountryID = -1, PersonID = -1;
			string FirstName = "", SecondName = "", LastName = ""
				, Email = "", Password = "",  Image = "", City = "";
			DateTime DateOfBirth = DateTime.Now;
			if (ClsPersonAccess.GetPersonByPhone(ref PersonID, ref FirstName, ref SecondName, ref LastName, ref DateOfBirth, ref CountryID, ref City, ref Email, ref Password,  Phone, ref Image))
			{
				return new ClsPeople(PersonID, FirstName, SecondName, LastName, DateOfBirth, CountryID, City, Email, Password, Phone, Image);
			}
			else
			{
				return null;
			}
		}

        public static DataTable GetAllPeople()
        {
            return ClsPersonAccess.GetAllPeople();
        }

        public bool Delete()
        {
            return ClsPersonAccess.DeletePerson(this.PersonID);
        }

		public static ClsPeople FindPersonByEmailAndPassword(string Email, string Password)
		{
			int CountryID = -1, PersonID = -1;
			string FirstName = "", SecondName = "", LastName = ""
				, Phone = "", Image = "", City = "";
			DateTime DateOfBirth = DateTime.Now;
            if (ClsPersonAccess.FindByEmailAndPassword(ref PersonID, ref FirstName, ref SecondName, ref LastName, ref DateOfBirth, ref CountryID, ref City, Email, Password, ref Phone, ref Image)) 
			{
				return new ClsPeople(PersonID, FirstName, SecondName, LastName, DateOfBirth, CountryID, City, Email, Password, Phone, Image);
			}
			else
			{
				return null;
			}

		}

		public static bool EditPersonNameByEmailAndPassword(string FirstName, string SecondName, string LastName, string Email, string Password)
		{
       
            return ClsPersonAccess.EditPersonNameByEmailAndPassword(FirstName, SecondName, LastName, Email, Password);
		}

		public static bool EditPersonEmailByEmailAndPassword(string NewEmail, string Email, string Password)
		{
			return ClsPersonAccess.EditPersonEmailByEmailAndPassword(NewEmail, Email, Password);
		}

		public static bool EditPersonPasswordByEmailAndPassword(string NewPassword, string Email, string Password)
		{
			return ClsPersonAccess.EditPersonPasswordByEmailAndPassword(NewPassword, Email, Password);
		}

		public static bool EditPersonPhoneByEmailAndPassword(string Phone, string Email, string Password)
		{
			return ClsPersonAccess.EditPersonPhoneByEmailAndPassword(Phone, Email, Password);
		}
	}
}
