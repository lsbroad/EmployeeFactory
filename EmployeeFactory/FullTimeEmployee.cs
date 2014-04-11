using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    class FullTimeEmployee : Employee, IEmployee
    {
        int anualSalary;

        public int AnualSalary
        {
            get { return anualSalary; }
            set { anualSalary = value; }
        }

        public override void PrintPay()
        {
            Console.WriteLine("Employee is paid an anual salary: " + anualSalary);
        }
    }
}
