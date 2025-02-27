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
	public partial class frmAddUpdateCard : Form
	{
		public frmAddUpdateCard()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
			ctrlFindPerson1.LoadPersonInfo(ClsUtilizationLogin.Person.PersonID);
		}

		public frmAddUpdateCard(int CardID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			this._CardID = CardID;
		}

		public enum enMode {AddNew = 0 , Update = 1};

		private enMode _Mode = enMode.AddNew;

		private int _CardID = -1;

		public int CardID
		{
			get { return _CardID; }
		}

		private ClsCreditCard _Cards;

		private void _DefaultView()
		{
			_FillCardClassicsInCB();
			if (_Mode == enMode.AddNew) 
			{
				this.Text = "Add New Card";
				_Cards = new ClsCreditCard();
			}
			else
			{
				this.Text = "Update Card";
			}
		}

		private void _FillCardClassicsInCB()
		{
			DataTable dtCardClassic = ClsCardClassics.GetAllCardClassics();

			foreach(DataRow Roe in dtCardClassic.Rows)
			{
				cbCardClassics.Items.Add(Roe["ClassicName"]);
			}
		}

		private void _FillCardInfo()
		{
			_CardID = _Cards.CardID;
			ctrlFindPerson1.LoadPersonInfo(_Cards.PersonID);
			laPersonID.Text = _Cards.PersonID.ToString();
			txtCardNumber.Text = _Cards.CardNumber;
			txtCarcCVC.Text = _Cards.CVC.ToString();
			chIsActive.Checked = _Cards.IsActive;
			dtpStartDate.Value = _Cards.StartDate;
			dtpEndDate.Value = _Cards.EndDate;
			cbCardClassics.SelectedIndex = cbCardClassics.FindString(_Cards.ClsCardClassics.ClassName);
		}

		private void _LoadCardInfo()
		{
			_Cards = ClsCreditCard.FindID(_CardID);

			if (_Cards == null)
			{
				MessageBox.Show("No CardID With This [" + CardID.ToString() + "]", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillCardInfo();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!this.ValidateChildren())
			{
				MessageBox.Show("Some Of The Children Are Not Correct","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			_Cards.PersonID = ctrlFindPerson1.PersonID;
			_Cards.CardNumber = txtCardNumber.Text;
			_Cards.CVC = txtCarcCVC.Text;
			_Cards.IsActive = chIsActive.Checked;
			_Cards.CardClassicID = ClsCardClassics.Find(cbCardClassics.Text).ClassID;
			_Cards.StartDate = dtpStartDate.Value;
			_Cards.EndDate = dtpEndDate.Value;

			if(_Cards.Save())
			{
				this.Text = "Update";
				_Mode = enMode.Update;
				laCardID.Text = _Cards.CardID.ToString();
				MessageBox.Show("Save Succeeded", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Save Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddUpdateCard_Load(object sender, EventArgs e)
		{
			_DefaultView();
			if (_Mode == enMode.Update)
				_LoadCardInfo();

			
		}

		private void ctrlFindPerson1_OnFindComplete_1(int obj)
		{
			ClsPeople Person = ClsPeople.FindID(obj);

			if (Person == null)
			{
				laPersonID.Text = null;
				panel2.Enabled = false;
			}
			else
			{
				
				panel2.Enabled = true;
				laPersonID.Text = obj.ToString();
			}
		}

		private void txtCardNumber_Validating(object sender, CancelEventArgs e)
		{
			if (!ClsUtilizationLogin.ValidateCardNumber(txtCardNumber.Text))
			{
				//_Cards.CardNumber = txtCardNumber.Text;

				e.Cancel = true;
				errorProvider1.SetError(txtCardNumber, "Invalid Number");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtCardNumber, null);
			}
			
		}
	}
}
