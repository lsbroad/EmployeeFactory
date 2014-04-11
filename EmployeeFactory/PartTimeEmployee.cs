using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    class PartTimeEmployee : Employee, IEmployee
    {
        int hourlyWage;

        public int HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }

        public override void PrintPay()
        {
            Console.WriteLine("Employee is  paid an hourly wage: " + hourlyWage + " an hour");
        }
    }
}
