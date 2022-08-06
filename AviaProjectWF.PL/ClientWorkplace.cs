using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AviaProject.DAL.Entities;
using AviaProjectWF.PL.BLLForms;

namespace AviaProjectWF.PL
{
    public partial class ClientWorkplace : Form
    {
        private Thread th;

        private enum ServiceType { Planes, Tickets };

        private ServiceType currentService;
        private List<Plane> _planes;
        private List<Ticket> _tickets;

        public ClientWorkplace()
        {
            InitializeComponent();
            currentService = ServiceType.Tickets;

            RefreshGrid();
        }
        public void RefreshGrid()
        {
            _planes = new List<Plane>(Connection.planeService.GetAllPlanes());
            _tickets = new List<Ticket>(Connection.ticketService.GetAllTickets());

            SetGrid();
        }
        private void SetGrid()
        {
            switch (currentService)
            {
                case ServiceType.Planes:
                    BindingList<Plane> blPlanes = new BindingList<Plane>(_planes);
                    dvgAdmin.DataSource = blPlanes;
                    break;

                case ServiceType.Tickets:
                    BindingList<Ticket> blTIckets = new BindingList<Ticket>(_tickets);
                    dvgAdmin.DataSource = blTIckets;
                    break;
                default:
                    blTIckets = new BindingList<Ticket>(_tickets);
                    dvgAdmin.DataSource = blTIckets;
                    break;
            }
        }

        private void ToPlanes_Click(object sender, EventArgs e)
        {
            currentService = ServiceType.Planes;
            SetGrid();
        }
        private void ToTickets_Click(object sender, EventArgs e)
        {
            currentService = ServiceType.Tickets;
            SetGrid();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Connection.Save();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket(this);
            buyTicket.Show();
        }

        private void DelayTicketBtn_Click(object sender, EventArgs e)
        {
            DelayTicket delayTicket = new DelayTicket(this);
            delayTicket.Show();
        }

        
    }
}
