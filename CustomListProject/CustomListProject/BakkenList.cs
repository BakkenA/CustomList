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
            primeArray = freshArray;
        }
        //public int GetIndex(T item)
        //{
        //    int index = 0;
        //    for (int i = 0; i < count; i++)
        //    {
                
        //        return index;
        //    }
        //}
        public void RemoveAt(int index)
        {

        }
        public void Remove()
        {
            T[] birthArray = new T[count + capacity];
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public void Zipper()
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
