using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AviaProjectWF.PL
{
    public partial class LoginForm : Form
    {
        private Thread th;


        public LoginForm()
        {
            InitializeComponent();
            Connection.Initialize();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            //var adForm = new AdminWorkplace();
            //adForm.Show();
            Close();
            th = new Thread(OpenAdminForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            //var clForm = new ClientWorkplace();
            //clForm.Show();
            //Hide();
            Close();
            th = new Thread(OpenClientForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void OpenAdminForm(object obj)
        {
            Application.Run(new AdminWorkplace());
        }
        private void OpenClientForm(object obj)
        {
            Application.Run(new ClientWorkplace());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
