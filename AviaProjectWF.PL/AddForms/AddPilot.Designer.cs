
namespace AviaProjectWF.PL.AddForms
{
    partial class AddPilot
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassAge = new System.Windows.Forms.TextBox();
            this.txtPilSurname = new System.Windows.Forms.TextBox();
            this.txtPilName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(421, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Experience";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // txtPassAge
            // 
            this.txtPassAge.Location = new System.Drawing.Point(262, 139);
            this.txtPassAge.Name = "txtPassAge";
            this.txtPassAge.Size = new System.Drawing.Size(253, 27);
            this.txtPassAge.TabIndex = 12;
            // 
            // txtPilSurname
            // 
            this.txtPilSurname.Location = new System.Drawing.Point(262, 86);
            this.txtPilSurname.Name = "txtPilSurname";
            this.txtPilSurname.Size = new System.Drawing.Size(253, 27);
            this.txtPilSurname.TabIndex = 11;
            // 
            // txtPilName
            // 
            this.txtPilName.Location = new System.Drawing.Point(262, 34);
            this.txtPilName.Name = "txtPilName";
            this.txtPilName.Size = new System.Drawing.Size(253, 27);
            this.txtPilName.TabIndex = 10;
            // 
            // AddPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 233);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassAge);
            this.Controls.Add(this.txtPilSurname);
            this.Controls.Add(this.txtPilName);
            this.Name = "AddPilot";
            this.Text = "AddPilot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassAge;
        private System.Windows.Forms.TextBox txtPilSurname;
        private System.Windows.Forms.TextBox txtPilName;
    }
}