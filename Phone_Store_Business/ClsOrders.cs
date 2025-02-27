using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsOrders
	{
		public int OrderID {  get; set; }
		public DateTime OrderDate { get; set; }

		public ClsOrders(int OrderID,DateTime Orderdate)
		{
			this.OrderID = OrderID;
			this.OrderDate = Orderdate;
		}

		public static DataTable GetAllOrders()
		{
			return ClsOrdersAccess.GetAllOrders();
		}

		public static ClsOrders Find(int OrderID)
		{
			DateTime OrderDate = DateTime.Now;

			if(ClsOrdersAccess.GetOrderByID(OrderID,ref OrderDate))
			{
				return new ClsOrders(OrderID,OrderDate);
			}
            else
            {
				return null;
            }
        }

	}
}
