using FirmEmployee.Employees;
using System;
using System.Linq;

namespace FirmEmployee.ExtensionMethods
{
    public static class FirmExtension
    {
        public static bool CheckEmployee(this Firm firm, Employee employee)
        {
            if (firm.Employees.Where(x => x.Name == employee.Name && x.Surname == employee.Surname).FirstOrDefault() == null)
            {
                return false;
            }
            return true;
        }

        public static void ShowAllEmployes(this Firm firm)
        {
            foreach(var employee in firm.Employees)
            {
                Console.WriteLine($"Name: {employee.Name}; Surname: {employee.Surname}; Experince: {employee.Experience} ");
            }
        }
    }
}
