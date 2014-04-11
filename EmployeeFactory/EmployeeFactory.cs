using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    static class EmployeeFactory
    {
        public static Employee getEmployee(employeeType type, EmployeeInput input)
        {
            switch (type)
            {
                case employeeType.fullTime:
                    return new FullTimeEmployee() { FirstName = input.InputFirstName, LastName = input.InputSurname, Type = input.InputType, AnualSalary = Convert.ToInt32(input.InputPay)};
                case employeeType.partTime:
                    return new PartTimeEmployee() { FirstName = input.InputFirstName, LastName = input.InputSurname, Type = input.InputType, HourlyWage = Convert.ToInt32(input.InputPay) };
                case employeeType.temporary:
                    return new TemporaryEmployee() { FirstName = input.InputFirstName, LastName = input.InputSurname, Type = input.InputType, HourlyWage = Convert.ToInt32(input.InputPay), ContractLength = Convert.ToInt32(input.InputContractlength) };
                default:
                    return new Employee() { Type = type };
            }
        }
    }
}
