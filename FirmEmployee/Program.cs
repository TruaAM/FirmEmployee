using System;
using System.Collections.Generic;
using FirmEmployee.Employees;
using FirmEmployee.ExtensionMethods;
using FirmEmployee.GenericMethods;
using FirmEmployee.Interfaces;

namespace FirmEmployee
{
    class Program
    {
        static void Main(string[] args)
        {           
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Hellow, welcome to my project.\nYou have a firm, with list of employees.\nTo work with list use commands.\n");
            Console.WriteLine("Commands: \n.help\n.add\n.remove\n.work\n.task\n.check\n.exist\n.show\n.count\n.exit\n");
            string command = "";
            bool check = true;

            Firm firm = new Firm();
            List<Employee> employees = new List<Employee>() {
                new Worker { Name = "Worker", Surname = "SurWorker", Experience = "ExW" },
                new Manager { Name = "Manager", Surname = "SurManager", Experience = "ExM" },
                new Foreman { Name = "Foreman", Surname = "SurForeman", Experience = "ExF" }
            };
            firm.Employees = employees;
            GenericClass<Employee> generics = new GenericClass<Employee>();

            do
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case ".help":
                        Help();
                        Console.WriteLine();
                        break;
                    case ".add":
                        Add(firm);
                        Console.WriteLine();
                        break;
                    case ".remove":
                        Remove(firm);
                        Console.WriteLine();
                        break;
                    case ".work":
                        Work(firm);
                        Console.WriteLine();
                        break;
                    case ".task":
                        GiveTasks(firm);
                        Console.WriteLine();
                        break;
                    case ".check":
                        CheckWorkers(firm);
                        Console.WriteLine();
                        break;
                    case ".exist":
                        Exist(firm);
                        Console.WriteLine();
                        break;
                    case ".show":
                        firm.ShowAllEmployes();
                        Console.WriteLine();
                        break;
                    case ".count":
                        Console.WriteLine($"This firm has {generics.Count(firm.Employees)} employees.");
                        Console.WriteLine();
                        break;
                    case ".exit":
                        check = false;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine();
                        break;
                }
            } while (check);

            Console.WriteLine("Press any button, to exit.");
            Console.ReadLine();
        }

        public static void Add(Firm firm)
        {
            string name = "", surname = "", experience = "";
            Console.WriteLine("Input employee data.");
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input surname: ");
            surname = Console.ReadLine();
            Console.Write("Input experience: ");
            experience = Console.ReadLine();


            firm += new Employee { Name = name, Surname = surname, Experience = experience };
        }

        public static void Remove(Firm firm)
        {
            string name = "", surname = "", experience = "";
            Console.WriteLine("Input employee data.");
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input surname: ");
            surname = Console.ReadLine();

            firm -= new Employee { Name = name, Surname = surname};
        }

        public static void Work(Firm firm)
        {
            foreach (var employee in firm.Employees)
            {
                employee.DoWork();
            }
        }

        public static void GiveTasks(Firm firm)
        {
            Manager manager;
            foreach (var employee in firm.Employees)
            {
                if (employee is IManager p)
                {
                    manager = (Manager)employee;
                    manager.GiveTask();
                }
            }
        }

        public static void CheckWorkers(Firm firm)
        {
            Foreman foreman;
            foreach (var employee in firm.Employees)
            {
                if (employee is IForeman p)
                {
                    foreman = (Foreman)employee;
                    foreman.CheckingWorkers();
                }
            }
        }

        public static void Exist(Firm firm)
        {
            string name = "", surname = "";
            Console.WriteLine("Input employee data.");
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input surname: ");
            surname = Console.ReadLine();

            var emp = new Employee { Name = name, Surname = surname };

            if (firm.CheckEmployee(emp))
            {
                Console.WriteLine($"Such employee {name} {surname} is in firm.");
            }
            else
            {
                Console.WriteLine($"There are no such employee {name} {surname} in firm.");
            }
        }

        public static string GetTypeName()
        {
            string typename = "";
            bool check = true;
            do
            {
                Console.WriteLine("Chose, what kind of employees you want to get.\nYour variants: employee, worker, manager, foreman.\n");
                typename = Console.ReadLine();

                switch (typename)
                {
                    case "employee":
                        check = false;
                        break;
                    case "worker":
                        check = false;
                        break;
                    case "manager":
                        check = false;
                        break;
                    case "foreman":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try next time.");
                        check = true;
                        break;
                }
            } while (check);
            return typename;
        }

        public static void Help()
        {
            Console.WriteLine("There are explanations for commands.");
            Console.WriteLine("Commands: \n.add\t - this command allows you to add new employee to firm;" +
                                        "\n.remove\t - this command allows you to remove existing employee from firm;" +
                                        "\n.work\t - this command allows you to make all employees in firm work;" +
                                        "\n.task\t - this command allows you to make all foremans in firm to check workers;" +
                                        "\n.check\t - this command allows you to make all managers in firm to give tasks;" +
                                        "\n.exist\t - this command allows you to input data to check if employee with such data exist;" +
                                        "\n.show\t - this command allows you look at list of employees in firm;" +
                                        "\n.count\t - this command allows you count all employees in firm;" +
                                        "\n.exit\t - this command allows you stop this project working;");
        }
    }
}
