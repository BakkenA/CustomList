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
        public int capacity = 1;
        public int count = 0;
        private static BakkenList<T> comboArray;

        public BakkenList()
        {
           T[] primeArray = new T[capacity];
        }

        public static BakkenList<T> operator +(BakkenList<T> a1, BakkenList<T> a2)
        {
            comboArray = new BakkenList<T>();
            foreach (T item in a1)
            {
                comboArray.Add(item);
            }
            foreach (T item in a2)
            {
                comboArray.Add(item);
            }
            return comboArray;
        }
        public static BakkenList<T> operator -(BakkenList<T> a1, BakkenList<T> a2)
        {
            BakkenList<T> smallerArray = a1;
            for (int i = 0; i < a2.count; i++)
            {               
                    smallerArray.Remove(a2.primeArray[i]);   
            }
            return smallerArray;
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
            StringBuilder myStringBuilder = new StringBuilder("This list contains: ");
            for (int i = 0; i < count; i++)
            {
                myStringBuilder.AppendFormat("{0} ", primeArray[i]);
            }
            return myStringBuilder.ToString();
        }
        public BakkenList<T> Zippering(BakkenList<T> a1)
        {
            BakkenList<T> mergedList = new BakkenList<T>();
            BakkenList<T> tempList = this;
            int smallest = Math.Min(tempList.count, a1.count);
            for (int i = 0; i < smallest; i++)
            {
                mergedList.Add(tempList.ReturnIndex(i));
                mergedList.Add(a1.ReturnIndex(i));
            }
            return mergedList;
        }
        public T ReturnIndex(int index)
        {
            return primeArray[index];
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return primeArray[i];
            }
        }
    }
}
