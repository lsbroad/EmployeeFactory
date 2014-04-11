using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    public class Employee : IEmployee
    {
        string _firstName;
        string _lastName;
        employeeType type;
        int _pay;

        public int Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }

        public employeeType Type
        {
            get { return type; }
            set { type = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }

            set
            {
                this._firstName = value;
            }
        }

        public virtual void PrintName()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }

        public virtual void PrintPay()
        {
            Console.WriteLine("Default Employee, no payment information");
        }
    }
}
