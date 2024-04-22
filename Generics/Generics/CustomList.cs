using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }
       
        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove(int index)
        {
            T itemToRemove = this.data[index];
            this.data.RemoveAt(index);
            return itemToRemove;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public bool Contains(T item)
        {
            return this.data.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
