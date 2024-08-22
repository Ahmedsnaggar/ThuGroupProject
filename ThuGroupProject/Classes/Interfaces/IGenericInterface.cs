using ThuGroupProject.Classes.PersonsFolder;

namespace ThuGroupProject.Classes.Interfaces
{
    public interface IGenericInterface<T>
    {
        public List<T> GetAll();
        public T GetById(T id);
        public T Add(T item);
        public T Update(T item);
        public void Delete(int id);
    }
}
