using FirmEmployee.Employees;
using System.Collections.Generic;
using System.Linq;

namespace FirmEmployee.GenericMethods
{
    class GenericClass<T> where T : Employee
    {
        public int Count(IEnumerable<T> employees)
        {
            return employees.Count();
        }

        public IEnumerable<T> GetAllByType(IEnumerable<T> employees, string typeName)
        {
            return employees.Where(e => e.GetType().Name == typeName).ToList();
        }
    }
}
