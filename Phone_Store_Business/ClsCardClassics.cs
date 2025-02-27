using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsCardClassics
	{
		public int ClassID { get; set; }
		public string ClassName { get; set; }

		public ClsCardClassics(int ClassID, string ClassName)
		{
			this.ClassID = ClassID;
			this.ClassName = ClassName;
		}

		public static ClsCardClassics Find(int ClassID)
		{
			string ClassName = "";
			if (ClsCardClassicsAccess.GetCardClassicByID(ClassID, ref ClassName))
			{
				return new ClsCardClassics(ClassID, ClassName);
			}
			else
				return null;
		}

		public static ClsCardClassics Find(string ClassName)
		{
			int ClassID = -1;
			if (ClsCardClassicsAccess.GetCardClassicByName(ref ClassID, ClassName))
			{
				return new ClsCardClassics(ClassID, ClassName);
			}
			else
				return null;
		}

		public static DataTable GetAllCardClassics()
		{
			return ClsCardClassicsAccess.GetAllCardsClassics();
		}
	}
}
