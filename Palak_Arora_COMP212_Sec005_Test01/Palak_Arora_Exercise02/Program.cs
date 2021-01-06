using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palak_Arora_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoiceArray = //invoice array contaning all the parts descriptions
            {
                new Invoice (87, "Eletric Sander",7, 57.98M ),
                new Invoice (24, "Power Saw", 18, 99.99M ),
                new Invoice (7, "Sledge Hammer", 11,21.50M),
                new Invoice (77, "Hammer", 76, 11.99M),
                new Invoice (39, "Lawn Mowner", 3, 79.50M),
                new Invoice (68, "Screw Driver", 106, 6.99M),
                new Invoice (56, "Jig Saw", 21, 11.00M)
            };


            var query1 = from Invoice in invoiceArray
                      
                         let partName = Invoice.PartDescription
                         orderby Invoice.PartNumber
                         select new { Invoice.PartDescription, Invoice.PartNumber};

            Console.WriteLine("\n a) Invoice List in ascending order of part numbers\n\n");
            Console.WriteLine("\t Part No. \t PartDescription ");
            Console.WriteLine("\t******************************************");
            foreach (var i in query1)
            {
                
                Console.WriteLine($"\t {i.PartNumber} \t \t {i.PartDescription} ");
            }

            var query2 = from Invoice in invoiceArray

                         let partName = Invoice.PartDescription
                         orderby Invoice.Quantity descending
                         select new { Invoice.PartDescription, Invoice.Quantity };

            Console.WriteLine("\n b) Invoice List in descending order of quantity\n\n");
            Console.WriteLine("\t Part Description \t Quantity ");
            Console.WriteLine("\t******************************************");
            foreach (var i in query2)
            {

                Console.WriteLine($"\t {i.PartDescription} \t \t {i.Quantity} ");
            }




            Console.ReadLine();
        }//end of main
    }
}
