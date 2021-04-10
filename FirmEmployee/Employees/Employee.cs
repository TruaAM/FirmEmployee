using System;
using System.Collections.Generic;

namespace FirmEmployee.Employees
{
    public class Employee 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Experience { get; set; }

        //public Employee(string name, string surname, string experience)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Experience = experience;
        //}

        public virtual void DoWork()
        {
            Console.WriteLine($"I am {Name} {Surname} with experince {Experience} and my role is Employee. I... don't know what I am supposed to do.");
        }

        //public static List<Employee> operator +(List<Employee> employees, Employee employee)
        //{
        //    if (IsExist(employees, employee))
        //    {
        //        Console.WriteLine($"Can't add. Such employee: - {employee.Name} {employee.Surname} with experince {employee.Experience}, already in firm.");
        //        return employees;
        //    }
        //    employees.Add(employee);
        //    return employees;
        //}

        //public static List<Employee> operator -(List<Employee> employees, Employee employee)
        //{
        //    if (!IsExist(employees, employee))
        //    {
        //        Console.WriteLine($"Can't delete. Such employee: - {employee.Name} {employee.Surname} with experince {employee.Experience}, does not exist in firm.");
        //        return employees;
        //    }
        //    employees.Remove(employees.Find(x => x.Name == employee.Name && x.Surname == employee.Surname));
        //    return employees;
        //}

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

