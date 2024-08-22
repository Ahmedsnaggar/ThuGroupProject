using ThuGroupProject.Classes.PersonsFolder;

namespace ThuGroupProject.Classes.Interfaces
{
    public interface Interface1
    {
        public bool IsFairTrade { get; set; }
        public void ShowName();
        public List<Person> GetAllPersons();
    }
}
