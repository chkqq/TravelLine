using Core.Models;
using DatabaseProvider;
using DatabaseProvider.Repositories.Abstractions;
using DatabaseProvider.Repositories.Implementations;
using System.Numerics;
using System;

namespace HospitalDb
{
    public class Program
    {
        private const string connectionString =
                "Data Source=WIN-26JB6NF31I0\\SQLEXPRESS01;Initial Catalog=CarMechanicDb;TrustServerCertificate=True;Pooling=true;Integrated Security=SSPI";
        private static ApplicationContext _applicationContext;
        private static ICarRepository _carRepository;
        private static IClientRepository _clientRepository;
        private static ICarMechanicRepository _carMechanicRepository;
        public static void Main(string[] args)
        {
            _applicationContext = new ApplicationContext(connectionString);
            _carRepository = new CarRepository(_applicationContext);
            _clientRepository = new ClientRepository(_applicationContext);
            _carMechanicRepository = new CarMechanicRepository(_applicationContext);
            PrintCommandsList();
            ProcessComands();
        }
        static void PrintCommandsList()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("\tadd-car [carName] [horsePower] [TypeOfRepair]");
            Console.WriteLine("\tremove-car [carId]");
            Console.WriteLine("\tadd-client [clientFirstName] [clientLastName]");
            Console.WriteLine("\tremove-client [clientId]");
            Console.WriteLine("\tadd-carMechanic [typeOfRepair] [carId] [clientId]");
            Console.WriteLine("\tremove-carMechanic [carMechanicId]");
            Console.WriteLine("\tlist-cars");
            Console.WriteLine("\tlist-clients");
            Console.WriteLine("\tlist-carMechanics");
            Console.WriteLine("\tlist-carMechanics-by-car [carId]");
            Console.WriteLine("\tlist-carMechanic-by-client [clientId]");
            Console.WriteLine("\texit");
        }
        static void ProcessComands()
        {
            while (true)
            {
                Console.Write("Enter command: ");
                string[] commandLine = Console.ReadLine()!.Split(' ');
                string command = commandLine[0];
                List<string> parameters = commandLine.Skip(1).ToList();
                switch (command)
                {
                    case "exit":
                        return;
                    case "add-car":
                        AddCar(parameters);
                        break;
                    case "remove-car":
                        RemoveCar(parameters);
                        break;
                    case "add-client":
                        AddClient(parameters);
                        break;
                    case "remove-client":
                        RemoveClient(parameters);
                        break;
                    case "add-carMechanic":
                        AddCarMechanic(parameters);
                        break;
                    case "remove-carMechanic":
                        RemoveCarMechanic(parameters);
                        break;
                    case "list-cars":
                        ListCars();
                        break;
                    case "list-clients":
                        ListClients();
                        break;
                    case "list-carMechanics":
                        ListCarMechanics();
                        break;
                    case "list-carMechanics-by-car":
                        ListCarMechanicsByCar(parameters);
                        break;
                    case "list-carMechanics-by-client":
                        ListCarMechanicsByClient(parameters);
                        break;
                    default:
                        break;

                }
            }
        }
        static void AddCar(List<string> parameters)
        {
            Car car = new()
            {
                CarName = parameters[0],
                HorsePower = int.Parse(parameters[1]),
                TypeOfRepair = parameters[2]
            };
            _carRepository?.Add(car);
            _carRepository?.SaveChanges();
        }
        static void RemoveCar(List<string> parameters)
        {
            int carId = int.Parse(parameters[0]);
            Car? car = _carRepository.GetById(carId);
            if (car != null)
            {
                _carRepository.Remove(car);
                _carRepository.SaveChanges();
            }
        }
        static void AddClient(List<string> parameters)
        {
            Client client = new()
            {
                ClientFirstName = parameters[0],
                ClientLastName = parameters[1]
            };
            _clientRepository.Add(client);
            _clientRepository.SaveChanges();
        }
        static void RemoveClient(List<string> parameters)
        {
            int clientId = int.Parse(parameters[0]);
            Client? client = _clientRepository.GetById(clientId);
            if (client != null)
            {
                _clientRepository.Remove(client);
                _clientRepository.SaveChanges();
            }
        }
        static void AddCarMechanic(List<string> parameters)
        {
            int repairCost = int.Parse(parameters[0]);
            int carId = int.Parse(parameters[1]);
            int clientId = int.Parse(parameters[2]);
            Car? car = _carRepository.GetById(carId);
            Client? client = _clientRepository.GetById(clientId);
            if (client != null && car != null)
            {
                CarMechanic carMechanic = new()
                {
                    RepairCost = repairCost,
                    CarId = carId,
                    Car = car,
                    ClientId = clientId,
                    Client = client
                };
                _carMechanicRepository.Add(carMechanic);
                _carMechanicRepository.SaveChanges();
            }
        }
        static void RemoveCarMechanic(List<string> parameters)
        {
            int receptionId = int.Parse(parameters[0]);
            CarMechanic? reception = _carMechanicRepository.GetById(receptionId);
            if (reception != null)
            {
                _carMechanicRepository.Remove(reception);
                _carMechanicRepository.SaveChanges();
            }   
        }
        static void ListCars()
        {
            _carRepository.GetAll().ForEach((car) => Console.WriteLine(car));
        }
        static void ListClients()
        {
            _clientRepository.GetAll().ForEach((client) => Console.WriteLine(client));
        }
        static void ListCarMechanics()
        {
            _carMechanicRepository.GetAll().ForEach((carMechanic) => Console.WriteLine(carMechanic));
        }
        static void ListCarMechanicsByCar(List<string> parameters)
        {
            int carId = int.Parse(parameters[0]);
            _carMechanicRepository.GetByCarId(carId).ForEach((carMechanic) => Console.WriteLine(carMechanic));
        }
        static void ListCarMechanicsByClient (List<string> parameters)
        {
            int clientId = int.Parse(parameters[0]);
            _carMechanicRepository.GetByClientId(clientId).ForEach((carMechanic) => Console.WriteLine(carMechanic));
        }
    }
}