using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>
            {
                new Circle(),
                new Rectangle()
            };

            var drawing = new Canvas();
            drawing.DrawingShapes(shapes);
        }
    }
}
