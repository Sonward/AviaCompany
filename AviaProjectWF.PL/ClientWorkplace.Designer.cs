
namespace AviaProjectWF.PL
{
    partial class ClientWorkplace
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DelayTicketBtn = new System.Windows.Forms.Button();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.ToTickets = new System.Windows.Forms.Button();
            this.ToPlanes = new System.Windows.Forms.Button();
            this.dvgAdmin = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1056, 56);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DelayTicketBtn
            // 
            this.DelayTicketBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayTicketBtn.Location = new System.Drawing.Point(198, 552);
            this.DelayTicketBtn.Name = "DelayTicketBtn";
            this.DelayTicketBtn.Size = new System.Drawing.Size(169, 42);
            this.DelayTicketBtn.TabIndex = 20;
            this.DelayTicketBtn.Text = "Delay ticket";
            this.DelayTicketBtn.UseVisualStyleBackColor = true;
            this.DelayTicketBtn.Click += new System.EventHandler(this.DelayTicketBtn_Click);
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.Location = new System.Drawing.Point(23, 552);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(169, 42);
            this.BuyTicketBtn.TabIndex = 19;
            this.BuyTicketBtn.Text = "Buy ticket";
            this.BuyTicketBtn.UseVisualStyleBackColor = true;
            this.BuyTicketBtn.Click += new System.EventHandler(this.BuyTicketBtn_Click);
            // 
            // ToTickets
            // 
            this.ToTickets.Location = new System.Drawing.Point(176, 21);
            this.ToTickets.Name = "ToTickets";
            this.ToTickets.Size = new System.Drawing.Size(149, 42);
            this.ToTickets.TabIndex = 17;
            this.ToTickets.Text = "Tickets";
            this.ToTickets.UseVisualStyleBackColor = true;
            this.ToTickets.Click += new System.EventHandler(this.ToTickets_Click);
            // 
            // ToPlanes
            // 
            this.ToPlanes.Location = new System.Drawing.Point(21, 21);
            this.ToPlanes.Name = "ToPlanes";
            this.ToPlanes.Size = new System.Drawing.Size(149, 42);
            this.ToPlanes.TabIndex = 16;
            this.ToPlanes.Text = "Planes";
            this.ToPlanes.UseVisualStyleBackColor = true;
            this.ToPlanes.Click += new System.EventHandler(this.ToPlanes_Click);
            // 
            // dvgAdmin
            // 
            this.dvgAdmin.AllowUserToAddRows = false;
            this.dvgAdmin.AllowUserToDeleteRows = false;
            this.dvgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdmin.Location = new System.Drawing.Point(23, 82);
            this.dvgAdmin.Name = "dvgAdmin";
            this.dvgAdmin.ReadOnly = true;
            this.dvgAdmin.RowHeadersWidth = 51;
            this.dvgAdmin.RowTemplate.Height = 29;
            this.dvgAdmin.Size = new System.Drawing.Size(1021, 453);
            this.dvgAdmin.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1056, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClientWorkplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 614);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DelayTicketBtn);
            this.Controls.Add(this.BuyTicketBtn);
            this.Controls.Add(this.ToTickets);
            this.Controls.Add(this.ToPlanes);
            this.Controls.Add(this.dvgAdmin);
            this.Controls.Add(this.ExitButton);
            this.Name = "ClientWorkplace";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DelayTicketBtn;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.Button ToTickets;
        private System.Windows.Forms.Button ToPlanes;
        private System.Windows.Forms.DataGridView dvgAdmin;
        private System.Windows.Forms.Button ExitButton;
    }
}