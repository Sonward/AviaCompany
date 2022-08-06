
namespace AviaProjectWF.PL
{
    partial class AdminWorkplace
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
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dvgAdmin = new System.Windows.Forms.DataGridView();
            this.ToPassengers = new System.Windows.Forms.Button();
            this.ToPilots = new System.Windows.Forms.Button();
            this.ToPlanes = new System.Windows.Forms.Button();
            this.ToTickets = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.SetPilotOnPlane = new System.Windows.Forms.Button();
            this.UnsetPilotFromPlane = new System.Windows.Forms.Button();
            this.bsAdmin = new System.Windows.Forms.BindingSource(this.components);
            this.ChangeRep = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1067, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dvgAdmin
            // 
            this.dvgAdmin.AllowUserToAddRows = false;
            this.dvgAdmin.AllowUserToDeleteRows = false;
            this.dvgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdmin.Location = new System.Drawing.Point(34, 73);
            this.dvgAdmin.Name = "dvgAdmin";
            this.dvgAdmin.ReadOnly = true;
            this.dvgAdmin.RowHeadersWidth = 51;
            this.dvgAdmin.RowTemplate.Height = 29;
            this.dvgAdmin.Size = new System.Drawing.Size(1021, 453);
            this.dvgAdmin.TabIndex = 1;
            this.dvgAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAdmin_CellContentClick);
            // 
            // ToPassengers
            // 
            this.ToPassengers.Location = new System.Drawing.Point(34, 12);
            this.ToPassengers.Name = "ToPassengers";
            this.ToPassengers.Size = new System.Drawing.Size(149, 42);
            this.ToPassengers.TabIndex = 2;
            this.ToPassengers.Text = "Passengers";
            this.ToPassengers.UseVisualStyleBackColor = true;
            this.ToPassengers.Click += new System.EventHandler(this.ToPassengers_Click);
            // 
            // ToPilots
            // 
            this.ToPilots.Location = new System.Drawing.Point(189, 12);
            this.ToPilots.Name = "ToPilots";
            this.ToPilots.Size = new System.Drawing.Size(149, 42);
            this.ToPilots.TabIndex = 3;
            this.ToPilots.Text = "Pilots";
            this.ToPilots.UseVisualStyleBackColor = true;
            this.ToPilots.Click += new System.EventHandler(this.ToPilots_Click);
            // 
            // ToPlanes
            // 
            this.ToPlanes.Location = new System.Drawing.Point(344, 12);
            this.ToPlanes.Name = "ToPlanes";
            this.ToPlanes.Size = new System.Drawing.Size(149, 42);
            this.ToPlanes.TabIndex = 4;
            this.ToPlanes.Text = "Planes";
            this.ToPlanes.UseVisualStyleBackColor = true;
            this.ToPlanes.Click += new System.EventHandler(this.ToPlanes_Click);
            // 
            // ToTickets
            // 
            this.ToTickets.Location = new System.Drawing.Point(499, 12);
            this.ToTickets.Name = "ToTickets";
            this.ToTickets.Size = new System.Drawing.Size(149, 42);
            this.ToTickets.TabIndex = 5;
            this.ToTickets.Text = "Tickets";
            this.ToTickets.UseVisualStyleBackColor = true;
            this.ToTickets.Click += new System.EventHandler(this.ToTickets_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(1012, 532);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(149, 42);
            this.AddItem.TabIndex = 6;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // SetPilotOnPlane
            // 
            this.SetPilotOnPlane.Location = new System.Drawing.Point(34, 543);
            this.SetPilotOnPlane.Name = "SetPilotOnPlane";
            this.SetPilotOnPlane.Size = new System.Drawing.Size(169, 42);
            this.SetPilotOnPlane.TabIndex = 7;
            this.SetPilotOnPlane.Text = "Set pilot on plane";
            this.SetPilotOnPlane.UseVisualStyleBackColor = true;
            this.SetPilotOnPlane.Click += new System.EventHandler(this.SetPilotOnPlane_Click);
            // 
            // UnsetPilotFromPlane
            // 
            this.UnsetPilotFromPlane.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnsetPilotFromPlane.Location = new System.Drawing.Point(209, 543);
            this.UnsetPilotFromPlane.Name = "UnsetPilotFromPlane";
            this.UnsetPilotFromPlane.Size = new System.Drawing.Size(169, 42);
            this.UnsetPilotFromPlane.TabIndex = 8;
            this.UnsetPilotFromPlane.Text = "Unset pilot from plane";
            this.UnsetPilotFromPlane.UseVisualStyleBackColor = true;
            this.UnsetPilotFromPlane.Click += new System.EventHandler(this.UnsetPilotFromPlane_Click);
            // 
            // ChangeRep
            // 
            this.ChangeRep.Location = new System.Drawing.Point(892, 12);
            this.ChangeRep.Name = "ChangeRep";
            this.ChangeRep.Size = new System.Drawing.Size(163, 29);
            this.ChangeRep.TabIndex = 9;
            this.ChangeRep.Text = "Change Repository";
            this.ChangeRep.UseVisualStyleBackColor = true;
            this.ChangeRep.Click += new System.EventHandler(this.ChangeRep_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1067, 47);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Click on pilot to see more data";
            // 
            // AdminWorkplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ChangeRep);
            this.Controls.Add(this.UnsetPilotFromPlane);
            this.Controls.Add(this.SetPilotOnPlane);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.ToTickets);
            this.Controls.Add(this.ToPlanes);
            this.Controls.Add(this.ToPilots);
            this.Controls.Add(this.ToPassengers);
            this.Controls.Add(this.dvgAdmin);
            this.Controls.Add(this.ExitButton);
            this.Name = "AdminWorkplace";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dvgAdmin;
        private System.Windows.Forms.Button ToPassengers;
        private System.Windows.Forms.Button ToPilots;
        private System.Windows.Forms.Button ToPlanes;
        private System.Windows.Forms.Button ToTickets;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button SetPilotOnPlane;
        private System.Windows.Forms.Button UnsetPilotFromPlane;
        private System.Windows.Forms.BindingSource bsAdmin;
        private System.Windows.Forms.Button ChangeRep;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
    }
}