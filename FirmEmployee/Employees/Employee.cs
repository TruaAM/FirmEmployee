using System;
using System.Collections.Generic;

namespace FirmEmployee.Employees
{
    public class Employee 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Experience { get; set; }
        public virtual void DoWork()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Employee. I... don't know what I am supposed to do.");
        }

        public static bool IsExist(List<Employee> employees, Employee employee)
        {
            if(employees.FindIndex(x => x.Name == employee.Name && x.Surname == employee.Surname) != -1)
            {
                return true;
            }
            return false;
        }
    }
}

