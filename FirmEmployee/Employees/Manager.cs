using FirmEmployee.Interfaces;
using System;

namespace FirmEmployee.Employees
{
    public class Manager : Employee, IManager
    {
        public override void DoWork()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Manager. Orders are collected.");
        }

        public void GiveTask()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Manager. Task is delivered.");
        }
    }
}
