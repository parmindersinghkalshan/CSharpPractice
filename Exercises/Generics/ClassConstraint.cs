using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ClassConstraint<T> where T : Product
    {
        public void Display(T product)
        {
            product.ProductName = "10";
        }
    }
}
