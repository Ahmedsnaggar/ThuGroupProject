using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject
{
    public struct Coffee
    {
        
        int _strength; 
        string _bean; 
        string _origin;

        public int strength { get{ return _strength; } set { _strength = value; } }
        public string bean { get { return _bean; } set { _bean = value; } }
        public string origin { get { return _origin; } set { _origin = value; } }
        public Coffee(int strength, string bean, string origin)
        {
            _strength = strength;
            _bean = bean;
            _origin = origin;
        }

    }


    public struct beverages
    {
        public int ID;
        public string Name;

    }
    public struct Menu
    {
        public  List<beverages> beveragesList = new List<beverages>();
        public beverages this[int index]
        {
            get { return this.beveragesList[index]; }
            set { this.beveragesList[index] = value; }
        }

        public Menu()
        {
            for (int i = 1; i <= 10; i++)
            {
                beverages curpeverage = new beverages() { ID = i, Name = $"Beverage {i}"};
                beveragesList.Add(curpeverage);
            } 
        }

    }
}
