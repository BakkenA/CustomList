using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class BakkenList<T>
    {
        T[] primeArray;
        int capacity = 4;
        int count = 0; 
        public BakkenList()
        {
           T[] primeArray = new T[capacity];
        }
        public void Add(T newbie)
        {
            T[] birthArray = new T[count+capacity];
            for (int i = 0; i < count; i++)
            {
                birthArray[i] = primeArray[i];
            }
            birthArray[count] = newbie;
            count++;
            primeArray = birthArray;
        }
    }
}
