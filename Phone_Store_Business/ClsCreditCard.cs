using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsCreditCard
	{
		public enum enMode { AddNew = 0, Update = 1 };

		private enMode _Mode = enMode.AddNew;

		public int CardID { get; set; }
		public int PersonID { get; set; }
		public string CardNumber { get; set; }
		public string CVC { get; set; }
		public bool IsActive { get; set; }
		public int CardClassicID {  get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public ClsPeople ClsPeople;

		public ClsCardClassics ClsCardClassics;

		public ClsCreditCard(int CardID, int PersonID, string CardNumber, string CVC, bool IsActive, int cardClassicID, DateTime startDate, DateTime endDate)
		{
			this.CardID = CardID;
			this.PersonID = PersonID;
			this.ClsPeople = ClsPeople.FindID(PersonID);
			this.ClsCardClassics = ClsCardClassics.Find(cardClassicID);
			this.CardNumber = CardNumber;
			this.CVC = CVC;
			this.IsActive = IsActive;
			this.CardClassicID = cardClassicID;
			this.StartDate = startDate;
			this.EndDate = endDate;
			_Mode = enMode.Update;
		}

		public ClsCreditCard()
		{
			_Mode = enMode.AddNew;
		}

		private bool _AddNewCard()
		{
			this.CardID = ClsCreditCardAccess.AddNewCard(this.PersonID, this.CardNumber, this.CVC, this.IsActive,this.CardClassicID,this.StartDate,this.EndDate);
			return (this.CardID != -1);
		}

		private bool _UpdateCard()
		{
			return ClsCreditCardAccess.UpdateCard(this.CardID,this.PersonID,this.CardNumber,this.CVC,this.IsActive,this.CardClassicID, this.StartDate,this.EndDate);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:
					if (_AddNewCard())
					{
						_Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.Update:
					return _UpdateCard();
			}
			return false;
		}

		public static ClsCreditCard FindID(int CardID)
		{

			int PersonID = -1, CardClassicID = -1;
			DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;
			string CardNumber = "", CVC = "";
			
			bool IsActive = false;
			if (ClsCreditCardAccess.GetCardByID(CardID, ref PersonID, ref CardNumber, ref CVC, ref IsActive,ref CardClassicID,ref StartDate,ref EndDate))
			{
				return new ClsCreditCard(CardID, PersonID, CardNumber, CVC, IsActive, CardClassicID, StartDate, EndDate);
			}
			else
				return null;
		}

		public static ClsCreditCard FindByPerson(int PersonID)
		{
			int CardID = -1, CardClassicID = -1;
			DateTime StartDate = DateTime.Now , EndDate = DateTime.Now;
			string CardNumber = "", CVC = "";
			
			bool IsActive = false;
			if (ClsCreditCardAccess.GetCardByPersonID(ref CardID, PersonID, ref CardNumber, ref CVC, ref IsActive, ref CardClassicID, ref StartDate, ref EndDate)) 
			{
				return new ClsCreditCard(CardID, PersonID, CardNumber, CVC, IsActive, CardClassicID, StartDate, EndDate);
			}
			else
				return null;
		}

		public static ClsCreditCard FindByNumber(string CardNumber)
		{
			int PersonID = -1, CardID = -1, CardClassicID = -1;
			DateTime StartDate= DateTime.Now , EndDate = DateTime.Now;
			string CVC = "";
			bool IsActive = false;
			if (ClsCreditCardAccess.GetCardByCardNumber(ref CardID, ref PersonID, CardNumber, ref CVC, ref IsActive, ref CardClassicID, ref StartDate, ref EndDate)) 
			{
				return new ClsCreditCard(CardID, PersonID, CardNumber, CVC, IsActive, CardClassicID, StartDate, EndDate);
			}
			else
				return null;
		}

		public static DataTable GetAllCards()
		{
			return ClsCreditCardAccess.GetAllCards();
		}

		public static DataTable GetAllActiveCards()
		{
			return ClsCreditCardAccess.GetAllActiveCards();
		}

		public static DataTable GetAllUnActiveCards()
		{
			return ClsCreditCardAccess.GetAllUnActiveCards();
		}

		public bool Delete()
		{
			return ClsCreditCardAccess.DeleteCard(this.CardID);
		}

		public static bool ActivateCard(int CardID)
		{
			return ClsCreditCardAccess.ActivateCard(CardID);
		}

		public static bool UnActiveCard(int CardID)
		{
			return ClsCreditCardAccess.UnActivateCard(CardID);
		}

		
	}
}
