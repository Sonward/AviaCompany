using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AviaProject.DAL;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Repositories;
using AviaProject.DAL.Repositories.TextFileSaves;
using AviaProject.BLL.Infrastructure;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Services;
using AviaProjectWF.PL.AddForms;
using AviaProjectWF.PL.BLLForms;


namespace AviaProjectWF.PL
{
    public partial class AdminWorkplace : Form
    {
        private Thread th;

        private enum ServiceType { Passengers, Pilots, Planes, Tickets };
        

        private ServiceType currentService;
        

        private readonly IPassengerService _passengerService;
        private readonly IPilotService _pilotService;
        private readonly IPlaneService _planeService;
        private readonly ITicketService _ticketService;

        private List<Passenger> _passengers;
        private List<Pilot> _pilots;
        private List<Plane> _planes;
        private List<Ticket> _tickets;

        public AdminWorkplace()
        {
            InitializeComponent();

            currentService = ServiceType.Passengers;

            _passengerService = Connection.passengerService;
            _pilotService = Connection.pilotService;
            _planeService = Connection.planeService;
            _ticketService = Connection.ticketService;

            RefreshGrid();
        }
        public void RefreshGrid()
        {
            _passengers = new List<Passenger>(_passengerService.GetAllPassengers());
            _pilots = new List<Pilot>(_pilotService.GetAllPilots());
            _planes = new List<Plane>(_planeService.GetAllPlanes());
            _tickets = new List<Ticket>(_ticketService.GetAllTickets());

            SetGrid();
        }
        private void SetGrid()
        {
            switch (currentService)
            {
                case ServiceType.Passengers:
                    BindingList<Passenger> blPassengers = new BindingList<Passenger>(_passengers);
                    bsAdmin.DataSource = blPassengers;
                    dvgAdmin.DataSource = bsAdmin;
                    break;

                case ServiceType.Pilots:
                    BindingList<Pilot> blPilots = new BindingList<Pilot>(_pilots);
                    bsAdmin.DataSource = blPilots;
                    dvgAdmin.DataSource = bsAdmin;
                    break;

                case ServiceType.Planes:
                    BindingList<Plane> blPlanes = new BindingList<Plane>(_planes);
                    bsAdmin.DataSource = blPlanes;
                    dvgAdmin.DataSource = bsAdmin;
                    break;

                case ServiceType.Tickets:
                    BindingList<Ticket> blTIckets = new BindingList<Ticket>(_tickets);
                    bsAdmin.DataSource = blTIckets;
                    dvgAdmin.DataSource = bsAdmin;
                    break;
                default:
                    blPassengers = new BindingList<Passenger>(_passengers);
                    bsAdmin.DataSource = blPassengers;
                    dvgAdmin.DataSource = bsAdmin;
                    break;
            }
        }

        private void ToPassengers_Click(object sender, EventArgs e)
        {
            currentService = ServiceType.Passengers;
            SetGrid();
        }
        private void ToPilots_Click(object sender, EventArgs e)
        {
            currentService = ServiceType.Pilots;
            SetGrid();
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

        private void ChangeRep_Click(object sender, EventArgs e)
        {
            Connection.ChangeDB();
            Close();
            th = new Thread(OpenAdminForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenAdminForm(object obj)
        {
            Application.Run(new AdminWorkplace());
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

        private void AddItem_Click(object sender, EventArgs e)
        {
            switch(currentService)
            {
                case ServiceType.Passengers:
                    AddPassenger passengerForm = new AddPassenger(this);
                    passengerForm.Show();
                    break;

                case ServiceType.Pilots:
                    AddPilot pilotForm = new AddPilot(this);
                    pilotForm.Show();
                    break;

                case ServiceType.Planes:
                    AddPlane planeForm = new AddPlane(this);
                    planeForm.Show();
                    break;

                case ServiceType.Tickets:
                    AddTicket ticketForm = new AddTicket(this);
                    ticketForm.Show();
                    break;

                default:

                    break;

            }
        }

        private void SetPilotOnPlane_Click(object sender, EventArgs e)
        {
            SetPilot setPilot = new SetPilot(this);
            setPilot.Show();
        }

        private void UnsetPilotFromPlane_Click(object sender, EventArgs e)
        {
            UnsetPilot unsetPilot = new UnsetPilot(this);
            unsetPilot.Show();
        }

        private void dvgAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentService == ServiceType.Pilots)
            {
                PilotPlanes plp = new PilotPlanes();
                plp.Show();
            }
            //else if (currentService == ServiceType.Planes)
            //{
            //    PlanePilots ppl = new PlanePilots();
            //    ppl.Show();
            //}
        }
    }
}
