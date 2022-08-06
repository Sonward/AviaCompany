
namespace AviaProjectWF.PL.BLLForms
{
    partial class SetPilot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.bsPlanes = new System.Windows.Forms.BindingSource(this.components);
            this.cbPilotsAdd = new System.Windows.Forms.ComboBox();
            this.cbPlanesAdd = new System.Windows.Forms.ComboBox();
            this.bsPilots = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPilots)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pilots";
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(412, 198);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(94, 29);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // cbPilotsAdd
            // 
            this.cbPilotsAdd.FormattingEnabled = true;
            this.cbPilotsAdd.Location = new System.Drawing.Point(213, 137);
            this.cbPilotsAdd.Name = "cbPilotsAdd";
            this.cbPilotsAdd.Size = new System.Drawing.Size(293, 28);
            this.cbPilotsAdd.TabIndex = 2;
            // 
            // cbPlanesAdd
            // 
            this.cbPlanesAdd.FormattingEnabled = true;
            this.cbPlanesAdd.Location = new System.Drawing.Point(213, 66);
            this.cbPlanesAdd.Name = "cbPlanesAdd";
            this.cbPlanesAdd.Size = new System.Drawing.Size(293, 28);
            this.cbPlanesAdd.TabIndex = 3;
            // 
            // SetPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 268);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.cbPlanesAdd);
            this.Controls.Add(this.cbPilotsAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetPilot";
            this.Text = "SetPilot";
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPilots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.BindingSource bsPlanes;
        private System.Windows.Forms.ComboBox cbPilotsAdd;
        private System.Windows.Forms.ComboBox cbPlanesAdd;
        private System.Windows.Forms.BindingSource bsPilots;
    }
}