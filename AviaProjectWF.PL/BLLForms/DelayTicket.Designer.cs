
namespace AviaProjectWF.PL.BLLForms
{
    partial class DelayTicket
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
            this.cbTripDate = new System.Windows.Forms.ComboBox();
            this.cbTripName = new System.Windows.Forms.ComboBox();
            this.cbPassport = new System.Windows.Forms.ComboBox();
            this.DelayBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTripDate
            // 
            this.cbTripDate.FormattingEnabled = true;
            this.cbTripDate.Location = new System.Drawing.Point(132, 106);
            this.cbTripDate.Name = "cbTripDate";
            this.cbTripDate.Size = new System.Drawing.Size(309, 28);
            this.cbTripDate.TabIndex = 20;
            // 
            // cbTripName
            // 
            this.cbTripName.FormattingEnabled = true;
            this.cbTripName.Location = new System.Drawing.Point(132, 65);
            this.cbTripName.Name = "cbTripName";
            this.cbTripName.Size = new System.Drawing.Size(309, 28);
            this.cbTripName.TabIndex = 19;
            // 
            // cbPassport
            // 
            this.cbPassport.FormattingEnabled = true;
            this.cbPassport.Location = new System.Drawing.Point(132, 12);
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Size = new System.Drawing.Size(309, 28);
            this.cbPassport.TabIndex = 18;
            // 
            // DelayBtn
            // 
            this.DelayBtn.Location = new System.Drawing.Point(347, 167);
            this.DelayBtn.Name = "DelayBtn";
            this.DelayBtn.Size = new System.Drawing.Size(94, 29);
            this.DelayBtn.TabIndex = 17;
            this.DelayBtn.Text = "Delay";
            this.DelayBtn.UseVisualStyleBackColor = true;
            this.DelayBtn.Click += new System.EventHandler(this.DelayBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Passsport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trip";
            // 
            // DelayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 216);
            this.Controls.Add(this.cbTripDate);
            this.Controls.Add(this.cbTripName);
            this.Controls.Add(this.cbPassport);
            this.Controls.Add(this.DelayBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DelayTicket";
            this.Text = "Delaying Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTripDate;
        private System.Windows.Forms.ComboBox cbTripName;
        private System.Windows.Forms.ComboBox cbPassport;
        private System.Windows.Forms.Button DelayBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}