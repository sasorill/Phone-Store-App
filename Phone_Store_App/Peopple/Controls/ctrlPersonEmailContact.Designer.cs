namespace Phone_Store_App
{
	partial class ctrlPersonEmailContact
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.rtxtMessage = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(75, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(75, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "To:";
			// 
			// txtFrom
			// 
			this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFrom.Location = new System.Drawing.Point(193, 73);
			this.txtFrom.Multiline = true;
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(637, 47);
			this.txtFrom.TabIndex = 2;
			// 
			// txtTo
			// 
			this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTo.Location = new System.Drawing.Point(193, 175);
			this.txtTo.Multiline = true;
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(637, 47);
			this.txtTo.TabIndex = 3;
			this.txtTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTo_Validating);
			// 
			// rtxtMessage
			// 
			this.rtxtMessage.Location = new System.Drawing.Point(193, 509);
			this.rtxtMessage.Name = "rtxtMessage";
			this.rtxtMessage.Size = new System.Drawing.Size(637, 207);
			this.rtxtMessage.TabIndex = 4;
			this.rtxtMessage.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Brown;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(36, 457);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Message:";
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.Brown;
			this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.Location = new System.Drawing.Point(601, 449);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(229, 46);
			this.btnSend.TabIndex = 6;
			this.btnSend.Text = "Send:";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(193, 268);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(637, 82);
			this.txtBody.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(75, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 31);
			this.label4.TabIndex = 8;
			this.label4.Text = "Body:";
			// 
			// ctrlPersonEmailContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.rtxtMessage);
			this.Controls.Add(this.txtTo);
			this.Controls.Add(this.txtFrom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(1008, 719);
			this.MinimumSize = new System.Drawing.Size(1008, 719);
			this.Name = "ctrlPersonEmailContact";
			this.Size = new System.Drawing.Size(1008, 719);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.RichTextBox rtxtMessage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.Label label4;
	}
}
