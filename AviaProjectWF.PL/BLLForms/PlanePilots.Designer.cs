
namespace AviaProjectWF.PL.BLLForms
{
    partial class PlanePilots
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
            this.label2 = new System.Windows.Forms.Label();
            this.dvgPilots = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlane = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPilots)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pilots";
            // 
            // dvgPilots
            // 
            this.dvgPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPilots.Location = new System.Drawing.Point(68, 121);
            this.dvgPilots.Name = "dvgPilots";
            this.dvgPilots.RowHeadersWidth = 51;
            this.dvgPilots.RowTemplate.Height = 29;
            this.dvgPilots.Size = new System.Drawing.Size(664, 287);
            this.dvgPilots.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plane:";
            // 
            // cbPlane
            // 
            this.cbPlane.FormattingEnabled = true;
            this.cbPlane.Location = new System.Drawing.Point(208, 43);
            this.cbPlane.Name = "cbPlane";
            this.cbPlane.Size = new System.Drawing.Size(339, 28);
            this.cbPlane.TabIndex = 4;
            this.cbPlane.SelectedIndexChanged += new System.EventHandler(this.cbPlane_SelectedIndexChanged);
            // 
            // PlanePilots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgPilots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlane);
            this.Name = "PlanePilots";
            this.Text = "PlanePilots";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPilots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlane;
        private System.Windows.Forms.DataGridView dvgPilots;
    }
}