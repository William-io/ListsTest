using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsTest
{
    class Program
    {
        static void Main(string[] args)
        {           

            IEnumerable<ListPayment> payments = new List<ListPayment>();

            payments.ToList(); //Faz a conversão para lista.
        

        }
    }
}
