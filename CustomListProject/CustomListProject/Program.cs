using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller visualizer = new Controller();
            ////visualizer.CheckFunctionality();
            ////visualizer.CheckList();
            ////visualizer.ReportIndex();
            ////visualizer.ModifyList();
            ////visualizer.CheckList();
            ////visualizer.SeeCount();
            ////visualizer.RemoveMany();
            ////visualizer.SeeCount();
            ////visualizer.CheckList();
            ////visualizer.CheckIteration();
            visualizer.PopulateOther();
            ////visualizer.CheckOther();
            ////visualizer.ShowStrings();
            visualizer.PopulateAnother();
            visualizer.combinedList = visualizer.otherList + visualizer.anotherList;
            visualizer.DisplayStrings();
            visualizer.Hold();
            visualizer.reducedList = visualizer.combinedList - visualizer.anotherList;
            visualizer.ShowMeMore();
            visualizer.Hold();
            //BakkenList<int> one = new BakkenList<int>() { 1, 2, 3 };
            //BakkenList<int> two = new BakkenList<int>() { 4, 5, 6 };
            //BakkenList<int> result;
            //result = one + two;
        }
    }
}
