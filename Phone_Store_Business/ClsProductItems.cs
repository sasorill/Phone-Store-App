using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsProductItems
	{
		public enum enMode {AddNew=0,Non=1};

		private enMode _Mode = enMode.AddNew;

		public int ItemID {  get; set; }
		public int OrderID { get; set; }
		public int ProductID { get; set; }
		public int PersonID { get; set; }
		public int Quantity { get; set; }
		public float TotalPrice { get; set; }
		public int CardID {  get; set; }

		public ClsProductItems(int ItemID, int OrderID, int ProductID, int PersonID, int Quantity, float TotalPrice, int cardID)
		{
			this.ItemID = ItemID;
			this.OrderID = OrderID;
			this.ProductID = ProductID;
			this.PersonID = PersonID;
			this.Quantity = Quantity;
			this.TotalPrice = TotalPrice;
			this.CardID = cardID;
			_Mode = enMode.Non;
		
		}

		public ClsProductItems()
		{
			_Mode = enMode.AddNew;
		}

		private bool _AddNewProductItem()
		{
			this.ItemID = ClsProductItemAccess.AddNewProductItems(this.ProductID,this.PersonID,this.Quantity,this.TotalPrice,this.CardID);
			return (this.ItemID != -1);
		}

		public bool Save()
		{
			switch(_Mode)
			{
				case enMode.AddNew:
					{
						if(_AddNewProductItem())
						{
							_Mode = enMode.Non;
							return true;
						}
						else
						{
							return false;
						}
					}
			}
			return false;
		}

		public bool Delete()
		{
			return ClsProductItemAccess.DeleteProductIem(this.ItemID);
		}

		public static ClsProductItems Find(int ItemID)
		{
			int ProductID = -1, PersonID = -1, OrderID = -1, Quantity = -1, CardID = -1;
			float TotalPrice = -1;
			if (ClsProductItemAccess.GetProductItemByID(ItemID, ref OrderID, ref ProductID, ref PersonID, ref Quantity, ref TotalPrice,ref CardID)) 
			{
				return new ClsProductItems(ItemID, OrderID, ProductID, PersonID, Quantity, TotalPrice,CardID);
			}
			else
			{
				return null;
			}
		}

		public static ClsProductItems FindOrder(int OrderID)
		{
			int ProductID = -1, PersonID = -1, Quantity = -1, ItemID = -1, CardID = -1;
			float TotalPrice = -1;
			if (ClsProductItemAccess.GetProductItemByOrderID(ref ItemID,  OrderID, ref ProductID, ref PersonID, ref Quantity, ref TotalPrice,ref CardID))
			{
				return new ClsProductItems(ItemID, OrderID, ProductID, PersonID, Quantity, TotalPrice, CardID);
			}
			else
			{
				return null;
			}
		}

		public static DataTable GetAllProductItems()
		{
			return ClsProductItemAccess.GetAllProductItems();
		}

	}
}
