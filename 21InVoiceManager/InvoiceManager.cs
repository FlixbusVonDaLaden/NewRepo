using System;
using System.Collections.Generic;
using System.Text;

namespace _21InVoiceManager
{
    public class InvoiceManager
    {
        public string CompanyName { get; set; }
        private Invoice[] invoices;
        private int nrOfInvoices = 0;

        public InvoiceManager(string companyName)
        {
            this.CompanyName = companyName;
            invoices = new Invoice[100];
        }

            public void addInvoice(Invoice invoice)
            {
                this.invoices[nrOfInvoices] = invoice;
                nrOfInvoices++;
            }

            public void printInvoices()
            {
                Console.WriteLine(this.CompanyName);
                Console.WriteLine("*************************");
                for(int i = 0; i < this.nrOfInvoices; i++)
                {
                    Console.WriteLine(invoices[i].Info);
                }
            }
        public void printInvoicesShort()
        {
            Console.WriteLine(this.CompanyName);
            Console.WriteLine("*************************");
            for (int i = 0; i < this.nrOfInvoices; i++)
            {
                Console.WriteLine(invoices[i].InfoShort);
            }
        }
    }

    }

