using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
