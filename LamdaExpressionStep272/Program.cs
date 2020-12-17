using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionStep272
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            {
                employees.Add(new Employee() { FirstName = "James", LastName = "Krack", Id = 1 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "schmoe", Id = 2 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "Kracker", Id = 3 });
                employees.Add(new Employee() { FirstName = "Steam", LastName = "Roll", Id = 4 });
                employees.Add(new Employee() { FirstName = "Boiling", LastName = "Water", Id = 5 });
                employees.Add(new Employee() { FirstName = "Jack", LastName = "beknown", Id = 6 });
                employees.Add(new Employee() { FirstName = "June", LastName = "Bug", Id = 7 });
                employees.Add(new Employee() { FirstName = "Jasper", LastName = "Cool", Id = 8 });
                employees.Add(new Employee() { FirstName = "Min", LastName = "TheGreat", Id = 9 });
                employees.Add(new Employee() { FirstName = "clock", LastName = "You", Id = 10 });
            }

            int ncount = 0;

            List<Employee> newjlist = new List<Employee>();
            foreach (var employee in employees)
            {

                if (employee.FirstName == "Joe")
                {
                    ncount++;
                    newjlist.Add(employee);
                    Console.WriteLine("employee : {0}\n", employee);
                }
            }


            List<Employee> newJJ = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (var employee in newJJ)
            {

                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Id}\n");

            }


            List<Employee> newjoelist = employees.Where(x => x.Id > 5).ToList();
            foreach (var employee in newjoelist)
            {

                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Id}");

            }


            Console.ReadLine();



        }



    }
}
