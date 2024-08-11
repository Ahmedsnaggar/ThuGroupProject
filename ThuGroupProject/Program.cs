using System.Collections;
using ThuGroupProject.Classes;
#region PersonList
DateTime date = new DateTime(1999, 09, 30);
List<Person> personsList = new List<Person>();
for (int i = 1; i <= 10; i++)
{
    date = date.AddDays(1);
    Person person = new Person();
    person.Name = $"Name {i}";
    person.DOB = date;
    person.City = $"City {i}";
    person.Address = $"Address {i}";
    person.PhoneNumber = $"PhoneNumber {i}";
    person.IdNumber = $"IdNumber {i}";
    personsList.Add(person);
}


foreach (Person person in personsList)
{
    string str = $"Person's Name : {person.Name}, Person's BirthDate : {person.DOB.ToShortDateString()}, Person's City = {person.City}, Person's Address : {person.Address}, Person's Phone : {person.PhoneNumber}, Person's Id :{person.IdNumber}";
    Console.WriteLine(str);
}
#endregion






Console.ReadLine();