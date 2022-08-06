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
    public partial class UnsetPilot : Form
    {
        AdminWorkplace fromOutside;

        public UnsetPilot(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;

            BindingList<Plane> blPlanes = new BindingList<Plane>((List<Plane>)Connection.planeService.GetAllPlanes());
            cbPlanesRemove.DataSource = blPlanes;
            cbPlanesRemove.DisplayMember = "Name";

            BindingList<Pilot> blPilots = new BindingList<Pilot>((List<Pilot>)Connection.pilotService.GetAllPilots());
            cbPilotsRemove.DataSource = blPilots;
            cbPilotsRemove.DisplayMember = "Name";
        }

        private void UnsetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pilot p = cbPilotsRemove.SelectedItem as Pilot;
                Plane pl = cbPlanesRemove.SelectedItem as Plane;
                int? pilotId = p.Id;
                int? planeId = pl.Id;
                Connection.planeService.RemovePilot(planeId, pilotId);

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
