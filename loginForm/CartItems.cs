using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForm
{
    internal class CartItems
    {
        public String ProductName { get; set; }
        public String ProductSize { get; set; }

        public int Quantity { get; set; }

        public decimal unitPrice { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
