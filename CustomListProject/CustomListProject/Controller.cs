using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class Controller
    {
        BakkenList<string> adamsList = new BakkenList<string>();
        BakkenList<double> otherList = new BakkenList<double>();

        public void CheckFunctionality()
        {
            adamsList.Add("Fox");
            adamsList.Add("Archaeopteryx");
            adamsList.Add("Wyrm");
            adamsList.Add("Hawk");
            adamsList.Add("Pheasant");
        }
        public void CheckList()
        {
            foreach (string thing in adamsList.primeArray) 
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
        public void ReportIndex()
        {
            Console.WriteLine(adamsList.GetIndex("Hawk"));
            Console.ReadLine();
        }
        public void ModifyList()
        {
            adamsList.RemoveAt(3);
            adamsList.Add("Phoenix");
            adamsList.RemoveAt(4);
            adamsList.Add("Styracasaurus");
            adamsList.Add("Hawk");
            adamsList.Add("Hawk");
            adamsList.Add("Phoenix");
            adamsList.Add("Wyvern");
            adamsList.Add("Titan");
            adamsList.Add("Hunter");
            adamsList.Add("Hawk");
            adamsList.Add("Warlock");
        }
        public void RemoveMany()
        {
            adamsList.Remove("Hawk");
        }
        public void SeeCount()
        {
            Console.WriteLine(adamsList.Count());
            Console.ReadLine();
        }
        public void CheckIteration()
        {
            foreach (string thing in adamsList)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
        public void Hold()
        {
            Console.ReadLine();
        }
        public void ShowStrings()
        {
            Console.WriteLine(otherList.ToString());
            Console.ReadLine();
        }
        public void PopulateOther()
        {
            otherList.Add(5.27);
            otherList.Add(6.38);
            otherList.Add(7.49);
            Console.ReadLine();
        }
        public void CheckOther()
        {
            Console.WriteLine(otherList.Count());
            Console.ReadLine();
        }
    }
}
