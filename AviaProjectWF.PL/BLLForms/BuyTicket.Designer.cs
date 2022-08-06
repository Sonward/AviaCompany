
namespace AviaProjectWF.PL.BLLForms
{
    partial class BuyTicket
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.cbPassport = new System.Windows.Forms.ComboBox();
            this.cbTripName = new System.Windows.Forms.ComboBox();
            this.cbTripDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(161, 30);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(309, 27);
            this.txtAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passsport";
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(376, 231);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(94, 29);
            this.BuyBtn.TabIndex = 8;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // cbPassport
            // 
            this.cbPassport.FormattingEnabled = true;
            this.cbPassport.Location = new System.Drawing.Point(161, 76);
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Size = new System.Drawing.Size(309, 28);
            this.cbPassport.TabIndex = 9;
            // 
            // cbTripName
            // 
            this.cbTripName.FormattingEnabled = true;
            this.cbTripName.Location = new System.Drawing.Point(161, 129);
            this.cbTripName.Name = "cbTripName";
            this.cbTripName.Size = new System.Drawing.Size(309, 28);
            this.cbTripName.TabIndex = 10;
            // 
            // cbTripDate
            // 
            this.cbTripDate.FormattingEnabled = true;
            this.cbTripDate.Location = new System.Drawing.Point(161, 170);
            this.cbTripDate.Name = "cbTripDate";
            this.cbTripDate.Size = new System.Drawing.Size(309, 28);
            this.cbTripDate.TabIndex = 11;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 269);
            this.Controls.Add(this.cbTripDate);
            this.Controls.Add(this.cbTripName);
            this.Controls.Add(this.cbPassport);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Name = "BuyTicket";
            this.Text = "Buying Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cbPassport;
        private System.Windows.Forms.ComboBox cbTripName;
        private System.Windows.Forms.ComboBox cbTripDate;
    }
}