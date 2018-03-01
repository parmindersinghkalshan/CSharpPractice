using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void InterfaceComparer()
        {
            var interfaceConstraint = new InterfaceConstraint<int>();
            interfaceConstraint.Max(10, 30);
        }

        static void ClassConstr()
        {
            var classConstraint = new ClassConstraint<Product>();
            classConstraint.Display(new Product());
        }

        static void ValueType()
        {
            var valueType = new ValueTypeConstraint<int>();
        }

        static void ReferenceType()
        {
            var refType = new ReferenceTypeConstraint<string>();

            var refType1 = new ReferenceTypeConstraint<Product>();
        }

        static void DefaultConstructor()
        {
            var defaultConstructor = new ObjectWithDefaultConstructor<Product>();
        }
    }
}
