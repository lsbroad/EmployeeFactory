using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFactory
{
    class EmployeeInput
    {
        string _inputFirstName;
        string _inputSurname;
        string _inputContractlength;
        string _inputPay;
        employeeType _inputType;

        public employeeType InputType
        {
            get { return _inputType; }
            set { _inputType = value; }
        }

        public string InputPay
        {
            get { return _inputPay; }
            set { _inputPay = value; }
        }

        public string InputContractlength
        {
            get { return _inputContractlength; }
            set { _inputContractlength = value; }
        }

        public string InputSurname
        {
            get { return _inputSurname; }
            set { _inputSurname = value; }
        }

        public string InputFirstName
        {
            get { return _inputFirstName; }
            set { _inputFirstName = value; }
        }
    }
}
