using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thing_not_covered
{
    class Address
    {
       public string Street { get; set; }
        public string Country { get; set; }
    }
    class Employee
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    class Manager : Employee
    {
        public IEnumerable<Employee> Reports { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        var employees = new List<Employee>()
        {
            new Employee()
            {
                Address = new Address()
                {

                    Street = "123 Sesame Street",
                    Country = "USA"
                }
            }
        };
            var usaEmployees = from employee in employees
                               where employee.Address.Country == "USA"
                               select employee.Name;
            
     }
    }

}
