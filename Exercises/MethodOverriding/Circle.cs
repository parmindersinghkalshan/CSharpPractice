﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
     public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle!");
        }
    }
}
