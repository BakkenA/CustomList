using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class BakkenList<T> : IEnumerable
    {
        public StringBuilder myStringBuilder = new StringBuilder("This list contains: ");
        public T[] primeArray;
        public int capacity = 4;
        public int count = 0; 
        public BakkenList()
        {
           T[] primeArray = new T[capacity];
        }
        public void Add(T item)
        {
            T[] freshArray = new T[count+capacity];
            for (int i = 0; i < count; i++)
            {
                freshArray[i] = primeArray[i];
            }
            freshArray[count] = item;
            count++;
            capacity = count;
            primeArray = freshArray;
        }
        public int GetIndex(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (primeArray[i].Equals(item))
                {
                    return i;
                }                
            }
            return index;
        }
        public void RemoveAt(int index)
        {
            T[] freshArray = new T[count + capacity];
            int itemRemoved = 0;
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    freshArray[i - itemRemoved] = primeArray[i];
                }
                else
                {
                    itemRemoved++;
                }
            }
            primeArray = freshArray;
            count -= itemRemoved;
        }
        public void Remove(T item)
        {
            T[] freshArray = new T[count + capacity];
            int index = GetIndex(item);
            while (index >= 0)
            {
                if (index == GetIndex(item))
                {
                    RemoveAt(index);
                }
                index = GetIndex(item);
            }
        }
        public int Count()
        {
            return count;
        }
        public override string ToString()
        {
            foreach (T item in primeArray)
            {
                myStringBuilder.AppendFormat("{0:C} ",item);
            }
            return myStringBuilder.ToString();
        }//Ask an instructor about this.
        public void Zipper()
        {

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return primeArray[i];
            }
            yield return "End of List";
        }
    }
}
