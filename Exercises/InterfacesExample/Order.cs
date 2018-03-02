using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public class Order
    {
        public Shipment Shipment { get; set; }

        public float TotalPrice { get; set; }

        public bool IsShipped => Shipment != null;
    }
}
