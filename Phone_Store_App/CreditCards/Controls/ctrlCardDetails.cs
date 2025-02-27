using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class ctrlCardDetails : UserControl
	{
		public ctrlCardDetails()
		{
			InitializeComponent();
		}

		private int _CardID;

		public int CardID
		{
			get { return _CardID; }
			set
			{
				_CardID = value;
			}
		}

		private ClsCreditCard _Cards;

		public ClsCreditCard Cards
		{
			get { return _Cards; }
		}

		private void _FillNow()
		{
			_CardID = _Cards.CardID;
			laCardID.Text = _Cards.CardID.ToString();
			laPersonID.Text = _Cards.PersonID.ToString();
			laCardNumber.Text = _Cards.CardNumber;
			laIsActive.Text = _Cards.IsActive == true ? "Yes" : "No";
			laCardClassic.Text = ClsCardClassics.Find(_Cards.CardClassicID).ClassName;
			laStartDate.Text = _Cards.StartDate.ToString();
			laEndDate.Text = _Cards.EndDate.ToString();
		}

		public void LoadCardInfo(int CardID)
		{
			_Cards = ClsCreditCard.FindID(CardID);

			if(_Cards == null )
			{
				MessageBox.Show("No CardID With ["+CardID.ToString()+"]","Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNow();
		}

		public void LoadCardInfo(string CardNumber)
		{
			_Cards = ClsCreditCard.FindByNumber(CardNumber);

			if (_Cards == null)
			{
				MessageBox.Show("No Card Number With [" + CardNumber + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNow();
		}

		public void LoadCardInfoPerson(int PersonID)
		{
			_Cards = ClsCreditCard.FindByPerson(PersonID);

			if (_Cards == null)
			{
				MessageBox.Show("No PersonID With [" + PersonID.ToString() + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillNow();
		}

	}
}
