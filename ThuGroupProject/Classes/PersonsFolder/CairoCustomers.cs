using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{
	public sealed class CairoCustomers : Customers
	{
		private double _Sale;
        public double Sale { get { return _Sale; } set { _Sale = value; } }
    }
}
