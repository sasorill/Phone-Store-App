using Phone_Store_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Store_App
{
	public partial class frmCreditCard : Form
	{
		ClsCreditCard Cards;

		public frmCreditCard()
		{
			InitializeComponent();
		}

		private ClsCreditCard Card;

		private void _RefreshAllCreditCards()
		{
			dgvCreditCard.DataSource = ClsCreditCard.GetAllCards();
			laCountCards.Text = dgvCreditCard.Rows.Count.ToString();
		}

		private void frmCreditCard_Load(object sender, EventArgs e)
		{
			_RefreshAllCreditCards();
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int CardID = (int)dgvCreditCard.CurrentRow.Cells[0].Value;
			using (frmCardDetails Cards = new frmCardDetails(CardID))
			{
				Cards.ShowDialog();
			}
				
		}

		private void findCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFindCard Card = new frmFindCard();
			Card.ShowDialog();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are You Sure You Want To Delete Cell?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if(this.Cards.Delete())
				{
					MessageBox.Show("Delete Cell Succeeded", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Delete Cell Failure", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void activeCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int CardID =(int) dgvCreditCard.CurrentRow.Cells[0].Value;

			Cards = ClsCreditCard.FindID(CardID);

			if (Cards != null)
			{
				if (Card.IsActive)
				{
					if (MessageBox.Show("Are You Sure You Want To Activate Cell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (ClsCreditCard.ActivateCard(CardID))
						{
							MessageBox.Show("Activate Cell Succeeded", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Activate Cell Failure", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				else
				{
					MessageBox.Show("The Card Is Already Activated", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void unActiveCardToolStripMenuItem_Click(object sender, EventArgs e)
		{

			{
				int CardID = (int)dgvCreditCard.CurrentRow.Cells[0].Value;

				Card = ClsCreditCard.FindID(CardID);

				if (Card != null)
				{
					if (!Card.IsActive)
					{
						if (MessageBox.Show("Are You Sure You Want To Activate Cell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							if (ClsCreditCard.UnActiveCard(CardID))
							{
								MessageBox.Show("UnActivate Cell Succeeded", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("UnActivate Cell Failure", "False", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					else
					{
						MessageBox.Show("The Card Is Already UnActivated", "UnActivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}

		private void addNewCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateCard frmCard = new frmAddUpdateCard();
			frmCard.ShowDialog();
			_RefreshAllCreditCards();
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateCard frmCard = new frmAddUpdateCard((int)dgvCreditCard.CurrentRow.Cells[0].Value);
			frmCard.ShowDialog();
			_RefreshAllCreditCards();
		}
	}
}
