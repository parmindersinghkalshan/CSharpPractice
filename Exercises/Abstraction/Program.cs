using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(),
                new Rectangle()
            };

            // we can not create an instance of abstract class
            //var shape = new Shape();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
