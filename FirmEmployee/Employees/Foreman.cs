using FirmEmployee.Interfaces;
using System;

namespace FirmEmployee.Employees
{
    public class Foreman : Employee, IForeman
    {
        public override void DoWork()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Foreman. Materials are bought.");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Foreman. Workers are chekced.");
        }
    }
}
