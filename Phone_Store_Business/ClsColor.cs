using Shop_Store_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Store_Business
{
	public class ClsColor
	{
		public int ColorID { get; set; }
		public string ColorName { get; set; }

		public ClsColor(int ColorID, string ColorName)
		{
			this.ColorID = ColorID;
			this.ColorName = ColorName;
		}

		public static ClsColor Find(int ColorID)
		{
			string ColorName = "";
			if (ClsColourAccess.GetColourByID(ColorID, ref ColorName))
			{
				return new ClsColor(ColorID, ColorName);
			}
			else
				return null;
		}

		public static ClsColor Find(string ColorName)
		{
			int ColorID = -1;
			if (ClsColourAccess.GetColourByName(ref ColorID, ColorName))
			{
				return new ClsColor(ColorID, ColorName);
			}
			else
				return null;
		}

		public static DataTable GetAllColors()
		{
			return ClsColourAccess.GetAllColours();
		}
	}
}
