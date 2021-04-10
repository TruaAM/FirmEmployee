using System;

namespace FirmEmployee.Employees
{
    public class Worker : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Worker. Product is outputed.");
        }
    }
}
