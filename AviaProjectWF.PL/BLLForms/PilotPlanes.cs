using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AviaProject.DAL.Entities;

namespace AviaProjectWF.PL.BLLForms
{
    public partial class PilotPlanes : Form
    {
        private List<Plane> _planes;
        BindingList<Pilot> blPilots;

        public PilotPlanes()
        {
            InitializeComponent();

            blPilots = new BindingList<Pilot>((List<Pilot>)Connection.pilotService.GetAllPilots());

            cbPilot.DataSource = blPilots;
            cbPilot.DisplayMember = "Name";

            _planes = blPilots[0].Planes;
            dvgPlanes.DataSource = _planes;
        }

        private void RefreshGrid()
        {
            _planes = blPilots[cbPilot.SelectedIndex].Planes;
            dvgPlanes.DataSource = _planes;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
