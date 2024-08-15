using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes
{
    public class Order
    {
        public delegate double CalcDelegate(double LinePrice, double Qnt);
        public delegate void OrderDegreeDelegate(Order Order);
        public event OrderDegreeDelegate OrderDegreeEvent;
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public void OrderDegreeMethod(Order Order)
        {
            OrderDegreeEvent?.Invoke(Order);
        }

        public double CalcMethod(double LinePrice, double Qnt, CalcDelegate del)
        {
            double result = del(LinePrice, Qnt);
            return result;
        }
        public double CalculateTotal(double LinePrice, double Qnt)
        {
            return LinePrice * Qnt;
        }
    }
}
