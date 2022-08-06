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
    public partial class AddPlane : Form
    {
        private AdminWorkplace fromOutside;

        public AddPlane(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.planeService.CreatePlane(new Plane
            {
                Id = Connection.planesCounter,
                Name = txtPlaneName.Text,
                Passengers = new List<Passenger>(),
                Pilots = new List<Pilot>()
            });
            Connection.planesCounter++;
            fromOutside.RefreshGrid();
            Close();
        }
    }
}
