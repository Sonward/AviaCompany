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
    public partial class AddTicket : Form
    {
        AdminWorkplace fromOutside;

        public AddTicket(AdminWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;

            foreach (Plane iter in Connection.planeService.GetAllPlanes())
            {
                cbPlanes.Items.Add(iter.Name);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Connection.ticketService.CreateTicket(new Ticket
            {
                Id = Connection.ticketsCounter,
                TripName = txtTripName.Text,
                Date = txtDate.Text,
                CurrentPassenger = new Passenger(),
                CurrentPlane = Connection.planeService.FindPlane(i=>i.Name == cbPlanes.SelectedItem.ToString())
            });
            Connection.ticketsCounter++;
            fromOutside.RefreshGrid();
            Close();
        }
    }
}
