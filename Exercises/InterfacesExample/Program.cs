using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());

            Order order = new Order
            {
                TotalPrice = 100f
            };

            orderProcessor.Process(order);
        }
    }
}
