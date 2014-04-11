using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    public enum employeeType
    {
        fullTime = 1,
        temporary,
        partTime
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[3];

            for (int i = 1; i < 4; i++)
            {
                EmployeeInput input = new EmployeeInput();

                Console.WriteLine("Employee [" + i + "]");

                Console.Write("Please enter Employee's type (1 - Permenant, 2 - Temporary, 3 - Part Time) : ");
                int typeEntered = Convert.ToInt32(Console.ReadLine());
                input.InputType = (employeeType)typeEntered;

                Console.Write("Please enter Employee's First Name : ");
                input.InputFirstName = (string)Console.ReadLine();

                Console.Write("Please enter Employee's Last Name  : ");
                input.InputSurname = (string)Console.ReadLine();

                Console.Write("Please enter Employee's Pay : ");
                input.InputPay = (string)Console.ReadLine();

                Console.Write("Please enter Employee's contract Term : ");
                input.InputContractlength = (string)Console.ReadLine();

                Console.Clear();

                empArr[i - 1] = EmployeeFactory.getEmployee((employeeType)i, input);
            }

            foreach (Employee e in empArr)
            {
                Console.WriteLine("Employee: " + e.Type);
                e.PrintName();
                e.PrintPay();
                Console.ReadLine();
            }
        }
    }
}
