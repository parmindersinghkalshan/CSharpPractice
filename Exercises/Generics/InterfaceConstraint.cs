using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class InterfaceConstraint<T> where T : IComparable
    {
        public T Max(T inta, T intb)
        {
            return inta.CompareTo(intb) > 0 ? inta : intb;
        }
    }
}
