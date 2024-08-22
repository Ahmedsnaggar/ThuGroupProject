using ThuGroupProject.Classes.Interfaces;
using ThuGroupProject.Classes.PersonsFolder;

namespace ThuGroupProject.Classes.Implementations
{
    public class PersonCrudClass : IPersonCrudInterface, Interface1
    {
        private List<Person> _persons = new List<Person>();        
        bool IPersonCrudInterface.IsFairTrade { get; set; }
        bool Interface1.IsFairTrade { get; set; }
        public PersonCrudClass()
        {
            DateTime date = new DateTime(1999, 09, 30);
            for (int i = 1; i <= 50; i++)
            {
                date = date.AddDays(1);
                Person person = new Person();
                person.id = i;
                person.Name = $"Person {i}";
                person.DOB = date;
                person.City = $"City {i}";
                person.Address = $"Address {i}";
                person.PhoneNumber = $"PhoneNumber {i}";
                person.IdNumber = $"IdNumber {i}";
                _persons.Add(person);
            }
        }
        public Person AddPerson(Person person)
        {
            _persons.Add (person);
            return person;
        }

        public void DeletePerson(int id)
        {
            var person = GetPersonById(id);
            _persons.Remove(person);
        }

        public List<Person> GetAllPersons()
        {
            return _persons;
        }

        public Person GetPersonById(int id)
        {
            return _persons.FirstOrDefault(p=> p.id == id);
        }

        public Person UpdatePerson(Person person)
        {
            var currentPerson = GetPersonById(person.id);
            currentPerson.Name = person.Name;
            currentPerson.DOB = person.DOB;
            currentPerson.Address = person.Address;
            return currentPerson;
        }
        public string GetMessage()
        {
            return "Hello, From Crud Class";
        }

        public void ShowName()
        {
            throw new NotImplementedException();
        }
        public void ShowAddress() { }
    }
}
