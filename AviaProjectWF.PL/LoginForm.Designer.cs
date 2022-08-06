
namespace AviaProjectWF.PL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.ClientLoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminLoginButton.Location = new System.Drawing.Point(324, 12);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(381, 137);
            this.AdminLoginButton.TabIndex = 0;
            this.AdminLoginButton.Text = "Login as Admin";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // ClientLoginButton
            // 
            this.ClientLoginButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientLoginButton.Location = new System.Drawing.Point(324, 196);
            this.ClientLoginButton.Name = "ClientLoginButton";
            this.ClientLoginButton.Size = new System.Drawing.Size(381, 137);
            this.ClientLoginButton.TabIndex = 1;
            this.ClientLoginButton.Text = "Login as Client";
            this.ClientLoginButton.UseVisualStyleBackColor = true;
            this.ClientLoginButton.Click += new System.EventHandler(this.ClientLoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(324, 380);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(381, 137);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 529);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClientLoginButton);
            this.Controls.Add(this.AdminLoginButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Button ClientLoginButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

