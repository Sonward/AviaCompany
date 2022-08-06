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
    public partial class BuyTicket : Form
    {
        ClientWorkplace fromOutside;

        public BuyTicket(ClientWorkplace from)
        {
            InitializeComponent();

            fromOutside = from;

            BindingList<Passenger> blPassengers = new BindingList<Passenger>((List<Passenger>)Connection.passengerService.GetAllPassengers());
            cbPassport.DataSource = blPassengers;
            cbPassport.DisplayMember = "Passport";

            BindingList<Ticket> blTickets = new BindingList<Ticket>((List<Ticket>)Connection.ticketService.GetAllTickets());
            cbTripName.DataSource = blTickets;
            cbTripName.DisplayMember = "TripName";
            cbTripDate.DataSource = blTickets;
            cbTripDate.DisplayMember = "Date";
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtAge.Text) < 18)
                {
                    MessageBox.Show("You must be 18 to buy the ticket");
                    return;
                }

                Passenger pas = cbPassport.SelectedItem as Passenger;
                Ticket tn = cbTripName.SelectedItem as Ticket;
                Ticket td = cbTripDate.SelectedItem as Ticket;

                Connection.ticketService.BuyTicket(pas.Passport, tn.TripName, td.Date);

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
