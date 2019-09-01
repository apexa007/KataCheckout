using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckoutKata
{
    class Class1
    {
        public static void Main()
        {
            Checkout chOut = new Checkout();
            chOut.Scan('A');
            chOut.Scan('A');
            chOut.Scan('A');
            chOut.Scan('A');
            chOut.Scan('B');
            chOut.Scan('B');


            Console.WriteLine("Total price: " + chOut.Total);
            Console.ReadLine();

        }
    }
}
