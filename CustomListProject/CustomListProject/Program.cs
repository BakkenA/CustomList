﻿using System;
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
            visualizer.CheckFunctionality();
            visualizer.CheckList();
            visualizer.ReportIndex();
            visualizer.ModifyList();
            visualizer.CheckList();
            visualizer.RemoveMany();
            visualizer.CheckList();
            visualizer.CheckIteration();
        }
    }
}
