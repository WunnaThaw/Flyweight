﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            int NumObjs = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);

            Console.ReadKey();
        }
    }
}
