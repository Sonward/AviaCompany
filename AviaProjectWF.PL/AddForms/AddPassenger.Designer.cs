
namespace AviaProjectWF.PL.AddForms
{
    partial class AddPassenger
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
            this.txtPassName = new System.Windows.Forms.TextBox();
            this.txtPassSurname = new System.Windows.Forms.TextBox();
            this.txtPassAge = new System.Windows.Forms.TextBox();
            this.txtPassPassport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassName
            // 
            this.txtPassName.Location = new System.Drawing.Point(247, 48);
            this.txtPassName.Name = "txtPassName";
            this.txtPassName.Size = new System.Drawing.Size(253, 27);
            this.txtPassName.TabIndex = 0;
            // 
            // txtPassSurname
            // 
            this.txtPassSurname.Location = new System.Drawing.Point(247, 100);
            this.txtPassSurname.Name = "txtPassSurname";
            this.txtPassSurname.Size = new System.Drawing.Size(253, 27);
            this.txtPassSurname.TabIndex = 1;
            // 
            // txtPassAge
            // 
            this.txtPassAge.Location = new System.Drawing.Point(247, 153);
            this.txtPassAge.Name = "txtPassAge";
            this.txtPassAge.Size = new System.Drawing.Size(253, 27);
            this.txtPassAge.TabIndex = 2;
            // 
            // txtPassPassport
            // 
            this.txtPassPassport.Location = new System.Drawing.Point(247, 204);
            this.txtPassPassport.Name = "txtPassPassport";
            this.txtPassPassport.Size = new System.Drawing.Size(253, 27);
            this.txtPassPassport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passport";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(406, 266);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 315);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassPassport);
            this.Controls.Add(this.txtPassAge);
            this.Controls.Add(this.txtPassSurname);
            this.Controls.Add(this.txtPassName);
            this.Name = "AddPassenger";
            this.Text = "Add Passenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassName;
        private System.Windows.Forms.TextBox txtPassSurname;
        private System.Windows.Forms.TextBox txtPassAge;
        private System.Windows.Forms.TextBox txtPassPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}