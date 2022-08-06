using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AviaProject.DAL.Entities;

namespace AviaProjectWF.PL.AddForms
{
    public partial class AddPassenger : Form
    {
        private AdminWorkplace fromOutside;

        public AddPassenger(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.passengerService.CreatePassenger(new Passenger
            {
                Id = Connection.passengersCounter,
                Name = txtPassName.Text,
                Surname = txtPassSurname.Text,
                Age = Convert.ToInt32(txtPassAge.Text),
                Passport = txtPassPassport.Text
            });
            Connection.passengersCounter++;
            fromOutside.RefreshGrid();
            Close();
        }
    }
}
