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
    public partial class PlanePilots : Form
    {
        private List<Pilot> _pilots;
        BindingList<Plane> blPlanes;

        public PlanePilots()
        {
            InitializeComponent();

            blPlanes = new BindingList<Plane>((List<Plane>)Connection.planeService.GetAllPlanes());

            cbPlane.DataSource = blPlanes;
            cbPlane.DisplayMember = "Name";

            _pilots = blPlanes[0].Pilots;
            dvgPlanes.DataSource = _pilots;
        }

        private void RefreshGrid()
        {
            _pilots = blPlanes[cbPlane.SelectedIndex].Pilots;
            dvgPlanes.DataSource = _pilots;
        }

        private void cbPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
