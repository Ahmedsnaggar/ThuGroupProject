using System.Collections;
using ThuGroupProject.Classes.Interfaces;

namespace ThuGroupProject.Classes.Implementations
{
    public class GenericClass<T> : IGenericInterface<T>, IEnumerable<T> //where T : class
    {
         
        private List<T> ListOfItems  = new List<T>();
     
        public T Add(T item)
        {
            ListOfItems.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return ListOfItems;
        }

        public T GetById(T id)
        {
            return ListOfItems.Find(o=> o.Equals(id));
        }
   public T Update(T item)
        {
            throw new NotImplementedException();
        }


        public IEnumerator<T> GetEnumerator()
        {
           return ListOfItems.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
