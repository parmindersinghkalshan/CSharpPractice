﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draing a circle!");
        }
    }
}
