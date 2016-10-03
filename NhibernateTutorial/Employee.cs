using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NhibernateTutorial
{
    class Employee
    {

        int _empId;
        int _age;
        string _empname;
        string _city;
        int _salary;
       



        public virtual int empId
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public virtual int age { get; set; }

        

        public virtual string empName
        {
            get { return _empname; }
            set { _empname = value; }
        }

        public virtual string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public virtual int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}
