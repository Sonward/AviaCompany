using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaProject.DAL;
using AviaProject.DAL.Entities;
using AviaProject.DAL.Interfaces;
using AviaProject.DAL.Repositories;
using AviaProject.DAL.Repositories.TextFileSaves;
using AviaProject.BLL.Infrastructure;
using AviaProject.BLL.Intefaces;
using AviaProject.BLL.Services;


namespace AdminSide
{
    class Program
    {
        static int passengersCounter = 1;
        static int planesCounter = 1;
        static int pilotsCounter = 1;
        static int ticketsCounter = 1;

        static IUnitOfWork unitOW;
        static DBSim db;
        static string filePath;
        static string errorLogPath = "ErrorLog.txt";

        static PassengerService passengerService;
        static PilotService pilotService;
        static PlaneService planeService;
        static TicketService ticketService;

        static void Main(string[] args)
        {
           
            db = new DBSim();
            DBInitialize(db);
            filePath = "DataFile.txt";


            unitOW = new UnitOfWorkTextFile(filePath);

            SetIdCounts(unitOW);
            ServiceInitialize(unitOW);

            ConsoleStart();

        }

        // UI Functions
        static void ConsoleStart()
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine(" 1) To login as admin");
                Console.WriteLine(" 2) To login as client");
                Console.WriteLine(" 3) Save and exit");

                Console.WriteLine("Input number of command --> ");
                int command;

                try
                {
                    command = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    command = 0;
                }

                switch (command)
                {
                    case 1:
                        Console.Clear();
                        AdminConsoleStart();
                        break;
                    case 2:
                        Console.Clear();
                        ClientConsoleStart();
                        break;
                    case 3:
                        return;
                    default:
                        Console.Clear();

                        Console.WriteLine("Wrong input. Try again");
                        break;
                }

            }
        }

        // UI Admin Functions
        static void AdminConsoleStart()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Admin:");

                    Console.WriteLine(" 1) To create new passenger");
                    Console.WriteLine(" 2) To create new pilot");
                    Console.WriteLine(" 3) To create new ticket");
                    Console.WriteLine(" 4) To create new plane");

                    Console.WriteLine(" 5) To set pilot to the plane");
                    Console.WriteLine(" 6) To unset pilot from the plane");

                    Console.WriteLine(" 7) To print all tickets");
                    Console.WriteLine(" 8) To print all planes");
                    Console.WriteLine(" 9) To print all pilots");
                    Console.WriteLine(" 10) To print all passengers");

                    Console.WriteLine(" 11) To pring error log file");
                    Console.WriteLine(" 12) To clear error log file");

                    Console.WriteLine(" 13) To change repositories");

                    Console.WriteLine(" 14) Exit and save");

                    int command;
                    Console.WriteLine("Input number of command --> ");
                    try
                    {
                        command = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        command = 0;
                    }


                    switch (command)
                    {
                        case 1:
                            CreatePassengeer();
                            break;
                        case 2:
                            CreatePilot();
                            break;
                        case 3:
                            CreateTicket();
                            break;
                        case 4:
                            CreatePlane();
                            break;
                        case 5:
                            SetPilot();
                            break;
                        case 6:
                            UnsetPilot();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("All Tickets:");
                            PrintAll(ticketService.GetAllTickets());
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("All Planes:");
                            PrintAll(planeService.GetAllPlanes());
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("All Pilots:");
                            PrintAll(pilotService.GetAllPilots());
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("All Passengers:");
                            PrintAll(passengerService.GetAllPassengers());
                            Console.WriteLine();
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("Error Log:");
                            ReadErrorLog();
                            Console.WriteLine();
                            break;
                        case 12:
                            Console.Clear();
                            CleanErrorLog();
                            Console.WriteLine("Error Log Cleaned");
                            Console.WriteLine();
                            break;
                        case 13:
                            ChangeRepository();
                            break;
                        case 14:
                            unitOW.Save();
                            Console.Clear();
                            return;
                        default:
                            Console.Clear();

                            Console.WriteLine(" Wrong input. Try again");
                            break;
                    }
                }
                catch(Exception exception)
                {
                    WriteExeption(new ValidationExeption(exception.Message, ""), "AdminConsoleStart");
                    Console.WriteLine();
                }

                
            }
        }
        static void CreatePassengeer()
        {
            Tuple<string, string, int, string> output = printClientInput();

            passengerService.CreatePassenger(new Passenger
            {
                Id = passengersCounter,
                Name = output.Item1,
                Surname = output.Item2,
                Age = output.Item3,
                Passport = output.Item4 
            }) ;
            passengersCounter++;

        }
        static void CreatePilot()
        {
            Tuple<string, string, int> output = printPilotInput();

            pilotService.CreatePilot(new Pilot
            {
                Id = pilotsCounter,
                Name = output.Item1,
                Surname = output.Item2,
                Experience = output.Item3,
                Planes = new List<Plane>()
            });
            pilotsCounter++;

        }
        static void CreateTicket()
        {
            Tuple<string, string, string> output = printTicketInput();

            try
            {
                ticketService.CreateTicket(new Ticket
                {
                    Id = ticketsCounter,
                    TripName = output.Item1,
                    CurrentPlane = planeService.FindPlane(i => i.Name == output.Item3),
                    Date = output.Item2,
                    CurrentPassenger = new Passenger()
                });
                ticketsCounter++;
                Console.Clear();
            }
            catch (ValidationExeption exeption)
            {
                WriteExeption(exeption, "CreateTicket()");
            }
            
        }
        static void CreatePlane()
        {
            string output = printPlaneInput();

            planeService.CreatePlane(new Plane
            {
                Id = planesCounter,
                Name = output,
                Passengers = new List<Passenger>(),
                Pilots = new List<Pilot>()
            });
            planesCounter++;

            Console.Clear();
        }
        static void SetPilot()
        {
            try
            {
                Console.WriteLine("All planes:");
                PrintAll(planeService.GetAllPlanes());
                Console.WriteLine(" Input plane Id --> ");
                int planeId = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine(" Pilots in plane " + planeId + ": ");
                PrintAll(planeService.FindPlane(i => i.Id == planeId).Pilots);

                Console.WriteLine(" All: ");
                PrintAll(pilotService.GetAllPilots());
                Console.WriteLine(" Input pilot Id --> ");
                int pilotId = Convert.ToInt32(Console.ReadLine());

                planeService.AddPilot(planeId, pilotId);

                Console.Clear();
                Console.WriteLine("Pilot " + pilotId + " added to plane " + planeId);

            }
            catch (ValidationExeption exeption)
            {
                WriteExeption(exeption, "SetPilot()");
            }
            
        }
        static void UnsetPilot()
        {
            try
            {
                Console.WriteLine("All planes:");
                PrintAll(planeService.GetAllPlanes());
                Console.WriteLine(" Input plane Id --> ");
                int planeId = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine(" Pilots in plane " + planeId + ": ");

                PrintAll(planeService.FindPlane(i => i.Id == planeId).Pilots);
                Console.WriteLine(" Input pilot Id --> ");
                int pilotId = Convert.ToInt32(Console.ReadLine());

                planeService.RemovePilot(planeId, pilotId);

                Console.Clear();
                Console.WriteLine("Pilot " + pilotId + " removed from plane " + planeId);
            }
            catch (ValidationExeption exeption)
            {
                WriteExeption(exeption, "UnsetPilot()");
            }

        }
        static void ChangeRepository()
        {
            Console.Clear();
            Console.WriteLine(" Choose repositories:");
            Console.WriteLine(" 1) Memory repositories");
            Console.WriteLine(" 2) Text file repositories");

            int comm;
            Console.WriteLine(" Input repository Id --> ");
            try
            {
                comm = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                comm = 0;
            }

            switch (comm)
            {
                case 1:
                    unitOW.Save();
                    unitOW = new UnitOfWork(db);
                    SetIdCounts(unitOW);
                    ServiceInitialize(unitOW);
                    Console.Clear();
                    Console.WriteLine(" Text file unit saved");
                    Console.WriteLine(" Using memory unit");
                    Console.WriteLine();
                    break;
                case 2:
                    unitOW = new UnitOfWorkTextFile(filePath);
                    SetIdCounts(unitOW);
                    ServiceInitialize(unitOW);
                    Console.Clear();
                    Console.WriteLine(" Using text file unit");
                    Console.WriteLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Wrong input");
                    Console.WriteLine();
                    return;
            }
        }

        static Tuple<string, string, int, string> printClientInput()
        {
            string name, surname, passport;
            int age;

            Console.WriteLine("Input your name --> ");
            name = Console.ReadLine();

            Console.WriteLine("Input your surname --> ");
            surname = Console.ReadLine();

            Console.WriteLine("Input your age --> ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your passport --> ");
            passport = Console.ReadLine();

            Console.Clear();
            return Tuple.Create(name, surname, age, passport);
        }
        static Tuple<string, string, int> printPilotInput()
        {
            string name, surname;
            int experience;

            Console.WriteLine("Input name of pilot --> ");
            name = Console.ReadLine();

            Console.WriteLine("Input surname of pilot --> ");
            surname = Console.ReadLine();

            Console.WriteLine("Input experience of pilot --> ");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            return Tuple.Create(name, surname, experience);
        }
        static Tuple<string, string, string> printTicketInput()
        {
            string tripName, date, planeName;

            Console.WriteLine("Input name of the ticket --> ");
            tripName = Console.ReadLine();

            Console.WriteLine("Input date of the ticket --> ");
            date = Console.ReadLine();

            Console.WriteLine("Input plane`s name of the ticket --> ");
            planeName = Console.ReadLine();

            Console.Clear();
            return Tuple.Create(tripName, date, planeName);
        }
        static string printPlaneInput()
        {
            string name;

            Console.WriteLine("Input name of the plane --> ");
            name = Console.ReadLine();

            Console.Clear();
            return name;
        }
        static void PrintAll<T>(IEnumerable<T> enumerable)
        {
            foreach(T iter in enumerable)
            {
                Console.WriteLine(iter.ToString());
            }
        }

        // UI Client Functions
        static void ClientConsoleStart()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(" 1) To see all available tickets");
                    Console.WriteLine(" 2) To see all available planes");
                    Console.WriteLine(" 3) To see your tickets");
                    Console.WriteLine(" 4) To buy ticket");
                    Console.WriteLine(" 5) To delay ticket");
                    Console.WriteLine(" 6) Exit and save");

                    int command;
                    Console.WriteLine("Input number of command --> ");

                    try
                    {
                        command = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        command = 0;
                    }

                    switch (command)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("All Tickets:");
                            PrintAll(ticketService.GetAllTickets());
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("All Planes:");
                            PrintAll(planeService.GetAllPlanes());
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Clear();
                            PrintClientsTickets();
                            break;
                        case 4:
                            Console.Clear();
                            BuyingTicket();
                            break;
                        case 5:
                            Console.Clear();
                            DelayingTicket();
                            break;
                        case 6:
                            unitOW.Save();
                            Console.Clear();
                            return;
                        default:
                            Console.Clear();

                            Console.WriteLine("Wrong input. Try again");
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                WriteExeption(new ValidationExeption(exception.Message, ""), "AdminConsoleStart");
                Console.WriteLine();
            }
            
        }
        static void PrintClientsTickets()
        {
            string passport;

            Console.WriteLine("Input your passport --> ");
            passport = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Your tickets:");

            passengerService.GetAllPassengerTickets(passport);
            Console.WriteLine();
        }
        static void BuyingTicket()
        {
            Tuple<string, string, int, string> output = printClientInput();

            if (output.Item3 < 18) { Console.WriteLine("You must be 18 or older to buy a ticket"); }
            else
            {
                Console.WriteLine("All trips:");
                PrintAll(ticketService.GetAllTickets());

                Console.WriteLine("Input trip name and date --> ");
                string name = Console.ReadLine();
                string date = Console.ReadLine();

                ticketService.BuyTicket(output.Item4, name, date);

                Console.WriteLine("You have successfully bought a ticket");
            }
        }
        static void DelayingTicket()
        {
            string passport;

            Console.WriteLine("Input name of the plane --> ");
            passport = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Your tickets:");

            PrintAll(passengerService.GetAllPassengerTickets(passport));

            Console.WriteLine("Input name and date of ticket that you want to delete --> ");
            string name = Console.ReadLine();
            string date = Console.ReadLine();

            try
            {
                ticketService.DelayTicket(passport, name, date);
            }
            catch(ValidationExeption exeption)
            {
                WriteExeption(exeption, "DelayTicket()");
            }
            
        }

        // Auxiliary Functions
        static void DBInitialize(DBSim db)
        {
            // Passengers
            db.passengers.Add(new Passenger { Id = 1, Name = "Name1", Surname = "Surmane1", Age = 5, Passport = "passport1" });
            db.passengers.Add(new Passenger { Id = 2, Name = "Name2", Surname = "Surmane2", Age = 50, Passport = "passport2" });
            db.passengers.Add(new Passenger { Id = 3, Name = "Name3", Surname = "Surmane3", Age = 15, Passport = "passport3" });
            db.passengers.Add(new Passenger { Id = 4, Name = "Name4", Surname = "Surmane4", Age = 35, Passport = "passport4" });
            db.passengers.Add(new Passenger { Id = 5, Name = "Name5", Surname = "Surmane5", Age = 51, Passport = "passport5" });

            // Pilots
            db.pilots.Add(new Pilot { Id = 1, Name = "PilotName1", Surname = "PilotSurname1", Experience = 5, Planes = new List<Plane>() });
            db.pilots.Add(new Pilot { Id = 2, Name = "PilotName2", Surname = "PilotSurname2", Experience = 1, Planes = new List<Plane>() });
            db.pilots.Add(new Pilot { Id = 3, Name = "PilotName3", Surname = "PilotSurname3", Experience = 10, Planes = new List<Plane>() });

            // Planes
            db.planes.Add(new Plane { Id = 1, Name = "Plane1", Passengers = new List<Passenger> { db.passengers[0], db.passengers[3] }, Pilots = new List<Pilot> { db.pilots[1], db.pilots[2] } });
            db.planes.Add(new Plane { Id = 2, Name = "Plane2", Passengers = new List<Passenger> { db.passengers[1], db.passengers[2], db.passengers[3] }, Pilots = new List<Pilot> { db.pilots[1], db.pilots[0] } });
            db.planes.Add(new Plane { Id = 3, Name = "Plane3", Passengers = new List<Passenger> { db.passengers[3], db.passengers[4] }, Pilots = new List<Pilot> { db.pilots[0], db.pilots[2] } });

            // Tickets
            db.tickets.Add(new AviaProject.DAL.Entities.Ticket { Id = 1, TripName = "Trip1", CurrentPassenger = db.passengers[1], CurrentPlane = db.planes[0], Date = "01.02.22" });
            db.tickets.Add(new AviaProject.DAL.Entities.Ticket { Id = 2, TripName = "Trip1", CurrentPassenger = db.passengers[0], CurrentPlane = db.planes[0], Date = "01.02.22" });
            db.tickets.Add(new AviaProject.DAL.Entities.Ticket { Id = 3, TripName = "Trip2", CurrentPassenger = db.passengers[4], CurrentPlane = db.planes[1], Date = "05.12.22" });

            // Pilots add planes
            db.pilots[2].Planes.Add(db.planes[0]);
            db.pilots[1].Planes.Add(db.planes[0]);
            db.pilots[1].Planes.Add(db.planes[1]);
            db.pilots[0].Planes.Add(db.planes[1]);
            db.pilots[0].Planes.Add(db.planes[2]);
            db.pilots[2].Planes.Add(db.planes[2]);

        }
        static void ServiceInitialize(IUnitOfWork unit)
        {
            passengerService = new PassengerService(unit);
            pilotService = new PilotService(unit);
            planeService = new PlaneService(unit);
            ticketService = new TicketService(unit);
        }
        static void SetIdCounts(IUnitOfWork unitOfWork)
        {
            int maxId = 0;
            foreach (Plane iter in unitOfWork.Planes.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            planesCounter = maxId + 1;
            maxId = 0;
            foreach (Pilot iter in unitOfWork.Pilots.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            pilotsCounter = maxId + 1;
            maxId = 0;
            foreach (Passenger iter in unitOfWork.Passengers.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            passengersCounter = maxId + 1;
            maxId = 0;
            foreach (Ticket iter in unitOfWork.Tickets.GetAll())
            {
                if (iter.Id > maxId) { maxId = iter.Id; }
            }
            ticketsCounter = maxId+1;
        }
        static void WriteExeption(ValidationExeption exeption, string methodname)
        {
            Console.Clear();
            AddErrorLog(exeption.Message, methodname);
            Console.WriteLine(exeption.Message);
        }
        static void ReadErrorLog()
        {
            List<string> errorLog = FileWorker.ReadFromFile(errorLogPath);

            PrintAll(errorLog);
        }
        static void AddErrorLog(string log, string methodName)
        {
            string log1 = "[" + DateTime.Now.ToString() + "] " + log + " in " + methodName+".";
            FileWorker.AddToFile(errorLogPath, new List<string> { log1 });
        }
        static void CleanErrorLog()
        {
            FileWorker.CleanFile(errorLogPath);
        }

        
    }
}
