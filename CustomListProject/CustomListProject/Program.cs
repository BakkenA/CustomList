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
            //visualizer.combinedList = visualizer.otherList + visualizer.anotherList;
            visualizer.ShowStrings();
            //visualizer.Hold();
            //visualizer.reducedList = visualizer.combinedList - visualizer.anotherList;
            //visualizer.ShowMeMore();
            //visualizer.Hold();
            visualizer.MergeMeNow();
            visualizer.ShowStrings();
            //BakkenList<int> result;
            //result = one + two;
        }
    }
}
