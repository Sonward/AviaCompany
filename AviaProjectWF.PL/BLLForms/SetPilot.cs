using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AviaProject.DAL.Entities;
using AviaProject.BLL.Infrastructure;

namespace AviaProjectWF.PL.BLLForms
{
    public partial class SetPilot : Form
    {
        AdminWorkplace fromOutside;

        public SetPilot(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;

            BindingList<Plane> blPlanes = new BindingList<Plane>((List<Plane>)Connection.planeService.GetAllPlanes());
            bsPlanes.DataSource = blPlanes;
            cbPlanesAdd.DataSource = bsPlanes;
            cbPlanesAdd.DisplayMember = "Name";

            BindingList<Pilot> blPilots = new BindingList<Pilot>((List<Pilot>)Connection.pilotService.GetAllPilots());
            bsPilots.DataSource = blPilots;
            cbPilotsAdd.DataSource = bsPilots;
            cbPilotsAdd.DisplayMember = "Name";
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pilot p = cbPilotsAdd.SelectedItem as Pilot;
                Plane pl = cbPlanesAdd.SelectedItem as Plane;
                int? pilotId = p.Id;
                int? planeId = pl.Id;
                Connection.planeService.AddPilot(planeId, pilotId);

                fromOutside.RefreshGrid();
                Close();
            }
            catch (ValidationExeption exeption)
            {
                Connection.WriteExeption(exeption, "SetButton_CLick");
            }
        }
    }
}
