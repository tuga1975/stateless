﻿using Stateless.DotGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugTrackerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bug = new Bug("Incorrect stock count");

            bug.Assign("Joe");
            bug.Defer();
            bug.Assign("Harry");
            bug.Assign("Fred");
            bug.Close();

            Console.WriteLine();
            Console.WriteLine("State machine:");
            Console.WriteLine(bug.ToDotGraph());

            Console.ReadKey(false);
        }
    }
}
