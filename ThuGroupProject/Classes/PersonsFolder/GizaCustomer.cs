using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{
	internal abstract class GizaCustomer : Customers
	{
		private double _ShippingAmount;
        public double ShippingAmount { get{ return _ShippingAmount; } set { _ShippingAmount = value; } }

		public double shippingamountValue()
		{
			return _ShippingAmount; 
		}
		public abstract double calculateAmount();
    }
}
