
namespace AviaProjectWF.PL.AddForms
{
    partial class AddTicket
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
            this.AddButton = new System.Windows.Forms.Button();
            this.TripDate = new System.Windows.Forms.Label();
            this.TripName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTripName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlanes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(421, 201);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TripDate
            // 
            this.TripDate.AutoSize = true;
            this.TripDate.Location = new System.Drawing.Point(48, 93);
            this.TripDate.Name = "TripDate";
            this.TripDate.Size = new System.Drawing.Size(41, 20);
            this.TripDate.TabIndex = 15;
            this.TripDate.Text = "Date";
            // 
            // TripName
            // 
            this.TripName.AutoSize = true;
            this.TripName.Location = new System.Drawing.Point(48, 35);
            this.TripName.Name = "TripName";
            this.TripName.Size = new System.Drawing.Size(78, 20);
            this.TripName.TabIndex = 13;
            this.TripName.Text = "Trip Name";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(262, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(253, 27);
            this.txtDate.TabIndex = 10;
            // 
            // txtTripName
            // 
            this.txtTripName.Location = new System.Drawing.Point(262, 34);
            this.txtTripName.Name = "txtTripName";
            this.txtTripName.Size = new System.Drawing.Size(253, 27);
            this.txtTripName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plane";
            // 
            // cbPlanes
            // 
            this.cbPlanes.FormattingEnabled = true;
            this.cbPlanes.Location = new System.Drawing.Point(262, 140);
            this.cbPlanes.Name = "cbPlanes";
            this.cbPlanes.Size = new System.Drawing.Size(253, 28);
            this.cbPlanes.TabIndex = 19;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 250);
            this.Controls.Add(this.cbPlanes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TripDate);
            this.Controls.Add(this.TripName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTripName);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TripDate;
        private System.Windows.Forms.Label TripName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTripName;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox txtPlaneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlanes;
    }
}