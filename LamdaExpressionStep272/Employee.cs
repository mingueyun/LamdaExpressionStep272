using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionStep272
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Employee()
        {


        }
        public override string ToString()
        {
            return "firstname: " + FirstName + " lastname: " + LastName + " id: " + Id;
        }


    }
}
