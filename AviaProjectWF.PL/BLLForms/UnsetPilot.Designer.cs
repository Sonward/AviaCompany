
namespace AviaProjectWF.PL.BLLForms
{
    partial class UnsetPilot
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
            this.UnsetButton = new System.Windows.Forms.Button();
            this.cbPlanesRemove = new System.Windows.Forms.ComboBox();
            this.cbPilotsRemove = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnsetButton
            // 
            this.UnsetButton.Location = new System.Drawing.Point(385, 186);
            this.UnsetButton.Name = "UnsetButton";
            this.UnsetButton.Size = new System.Drawing.Size(94, 29);
            this.UnsetButton.TabIndex = 9;
            this.UnsetButton.Text = "Unset";
            this.UnsetButton.UseVisualStyleBackColor = true;
            this.UnsetButton.Click += new System.EventHandler(this.UnsetButton_Click);
            // 
            // cbPlanesAdd
            // 
            this.cbPlanesRemove.FormattingEnabled = true;
            this.cbPlanesRemove.Location = new System.Drawing.Point(186, 54);
            this.cbPlanesRemove.Name = "cbPlanesAdd";
            this.cbPlanesRemove.Size = new System.Drawing.Size(293, 28);
            this.cbPlanesRemove.TabIndex = 8;
            // 
            // cbPilotsAdd
            // 
            this.cbPilotsRemove.FormattingEnabled = true;
            this.cbPilotsRemove.Location = new System.Drawing.Point(186, 125);
            this.cbPilotsRemove.Name = "cbPilotsAdd";
            this.cbPilotsRemove.Size = new System.Drawing.Size(293, 28);
            this.cbPilotsRemove.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pilots";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Planes";
            // 
            // UnsetPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 268);
            this.Controls.Add(this.UnsetButton);
            this.Controls.Add(this.cbPlanesRemove);
            this.Controls.Add(this.cbPilotsRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnsetPilot";
            this.Text = "UnsetPilot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnsetButton;
        private System.Windows.Forms.ComboBox cbPlanesRemove;
        private System.Windows.Forms.ComboBox cbPilotsRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}