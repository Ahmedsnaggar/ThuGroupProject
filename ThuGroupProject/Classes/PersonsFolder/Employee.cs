using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{
	public class Employee : Person
	{
		private double _Salary;
		private double _Detiction;
		private double _Bonus;
        public double Salary { get { return _Salary; } set { _Salary = value; } }
		public double Detiction { get { return _Detiction; } set { _Detiction = value; } }
		public double Bonus { get { return _Bonus; } set { _Bonus = value; } }
		sealed public override string Welcome()
		{
			
			return "Welcome, Employee";
		}
        public Employee()
        {
            
        }
        public Employee(string name, DateTime dob, string city, string address, string phoneNumber, string idNumber, GenderEnum gender) : base(name, dob , city, address, phoneNumber, idNumber,gender)
        {
            base.Name = name;
        }
    }
}
