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
    public partial class AddPilot : Form
    {
        AdminWorkplace fromOutside;

        public AddPilot(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.pilotService.CreatePilot(new Pilot
            {
                Id = Connection.pilotsCounter,
                Name = txtPilName.Text,
                Surname = txtPilSurname.Text,
                Experience = Convert.ToInt32(txtPassAge.Text),
                Planes = new List<Plane>()
            });
            Connection.pilotsCounter++;
            fromOutside.RefreshGrid();
            Close();
        }
    }
}
