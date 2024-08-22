using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{
	public class Customers : Person
	{
		private double _StartBalance;
        public double StartBalance { get { return _StartBalance; } set { _StartBalance = value; } }
		public override string Welcome()
		{
			return "Welcome, Customer";
		}
    }
}
