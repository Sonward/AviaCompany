
namespace AviaProjectWF.PL.BLLForms
{
    partial class PilotPlanes
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
            this.cbPilot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgPlanes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPilot
            // 
            this.cbPilot.FormattingEnabled = true;
            this.cbPilot.Location = new System.Drawing.Point(204, 53);
            this.cbPilot.Name = "cbPilot";
            this.cbPilot.Size = new System.Drawing.Size(339, 28);
            this.cbPilot.TabIndex = 0;
            this.cbPilot.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot:";
            // 
            // dvgPlanes
            // 
            this.dvgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPlanes.Location = new System.Drawing.Point(64, 131);
            this.dvgPlanes.Name = "dvgPlanes";
            this.dvgPlanes.RowHeadersWidth = 51;
            this.dvgPlanes.RowTemplate.Height = 29;
            this.dvgPlanes.Size = new System.Drawing.Size(664, 287);
            this.dvgPlanes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Planes";
            // 
            // PilotPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgPlanes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPilot);
            this.Name = "PilotPlanes";
            this.Text = "PilotPlanes";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPilot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPlanes;
        private System.Windows.Forms.Label label2;
    }
}