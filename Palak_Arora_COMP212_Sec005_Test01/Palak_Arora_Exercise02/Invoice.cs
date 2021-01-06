using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palak_Arora_Exercise02
{
    class Invoice
    {
        //Properties
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //Constructor
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            this.PartNumber = partNumber;
            this.PartDescription = partDescription;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}
