using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
     public class Canvas
    {
        public void DrawingShapes(List<Shapes> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();   
            }
        }
    }
}
