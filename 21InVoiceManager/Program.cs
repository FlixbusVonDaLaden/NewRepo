using System;

namespace _21InVoiceManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv1 = new Invoice("R-2022-001", 99.9, DateTime.Now, 7);
            Invoice inv2 = new Invoice("R-2022-002", 10.5, DateTime.Now, 9);
            Invoice inv3 = new Invoice("R-2021-454", 124, new DateTime(2021, 12, 31), 5);
            Invoice inv4 = new Invoice("R-2022-004", 100000, DateTime.Now, 31);


            Console.WriteLine(inv1.Info);
            Console.WriteLine(inv1.InfoShort);

            Console.WriteLine(inv2.Info);
            Console.WriteLine(inv2.InfoShort);

            Console.WriteLine(inv3.Info);
            Console.WriteLine(inv3.InfoShort);

            Console.WriteLine(inv4.Info);
            Console.WriteLine(inv4.InfoShort);

            InvoiceManager manager = new InvoiceManager("Umbrellla Corporation");

            manager.addInvoice(inv1);
            manager.addInvoice(inv2);
            manager.addInvoice(inv3);
            manager.addInvoice(inv4);

            manager.printInvoices();
            manager.printInvoicesShort();
        }
    }
}
