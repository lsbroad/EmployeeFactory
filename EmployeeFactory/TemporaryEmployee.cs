using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    class TemporaryEmployee : Employee, IEmployee
    {
        double hourlyWage;
        int contractLength;

        public int ContractLength
        {
            get { return contractLength; }
            set { contractLength = value; }
        }

        public double HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }

        public override void PrintPay()
        {
            Console.WriteLine("Employee is paid an hourly wage: " + hourlyWage + " an hour.\nThis is a temp contract for " + contractLength + " months");
        }
    }
}
