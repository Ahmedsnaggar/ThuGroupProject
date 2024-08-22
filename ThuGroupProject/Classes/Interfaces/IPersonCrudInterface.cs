using ThuGroupProject.Classes.PersonsFolder;

namespace ThuGroupProject.Classes.Interfaces
{
    public interface IPersonCrudInterface
    {
        public bool IsFairTrade { get; set; }
        public List<Person> GetAllPersons();
        public Person GetPersonById(int id);
        public Person AddPerson(Person person);
        public Person UpdatePerson(Person person);
        public void DeletePerson(int id);
        public string GetMessage()
        {
            return "Hello";
        }
        public string GetCity()
        {
            return "Hello1";
        }
    }
}
