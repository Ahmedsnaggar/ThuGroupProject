using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThuGroupProject.Classes.PersonsFolder
{

    public class Person
    {
        #region Fields
        private int _id;
        private string _Name;
        private DateTime _DOB;
        private string _City;
        private string _Address;
        private string _PhoneNumber;
        private string _IdNumber;
        private GenderEnum _Gender;
        #endregion

        #region Properties
        public int id { get { return _id; } set { _id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public DateTime DOB { get { return _DOB; } set { _DOB = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }
        public string IdNumber { get { return _IdNumber; } set { _IdNumber = value; } }
        public GenderEnum Gender { get { return _Gender; } set { _Gender = value; } }
        #endregion


        #region Constructors
        /// <summary>
        /// constructor
        /// </summary>
        public Person()
        {
            _id = 0;
            _Name = "New Horaizons";
            _DOB = new DateTime(2000, 10, 5);
            _City = "Cairo";
            _Address = "Nasr City";
            _PhoneNumber = "115588";
            _IdNumber = "12345";
            _Gender = GenderEnum.Male;
        }
        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="name">Enter Person Name</param>
        /// <param name="dob"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="idNumber"></param>
        /// <param name="gender"></param>
        public Person(string name, DateTime dob, string city, string address, string phoneNumber, string idNumber, GenderEnum gender)
        {

            _Name = name;
            _DOB = dob;
            _City = city;
            _Address = address;
            _PhoneNumber = phoneNumber;
            _IdNumber = idNumber;
            _Gender = gender;
        }

        public Person(Person person)
        {
            _Name = person.Name;
            _DOB = person.DOB;
            _City = person.City;
            _Address = person.Address;
            _PhoneNumber = person.PhoneNumber;
            _IdNumber = person.IdNumber;
            _Gender = person.Gender;
        }
        #endregion

        #region Methods
        /// <summary>
        /// To get person name
        /// </summary>
        /// <returns> Person Name</returns>
        public string ShowName()
        {
            return _Name;
        }

        public static int Calc()
        {
            return 50;
        }

        public virtual string Welcome()
        {
            return "Welcome, Person";
        }
        #endregion
    }
}
