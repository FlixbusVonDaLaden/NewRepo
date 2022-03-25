using System;
using System.Collections.Generic;
using System.Text;

namespace _21InVoiceManager
{
    public class Invoice
    {
        public string InvoiceNr { get; set; }   //Rechnungsnummer

        public double Amount { get; set; }  //rechnungsbetrag

        public DateTime InvoiceDate { get; }    //Rechnungsdatum

        public DateTime DueDate { get; }    //Fälligkeitsdatum

        public Invoice(string InvoiceNr, double Amount, DateTime InvoiceDate, int timeToPay)    //Time to pay --> Zeit bis fälligkeitsdatum     
        {
            this.InvoiceNr = InvoiceNr;
            this.Amount = Amount;
            this.InvoiceDate = InvoiceDate;
            this.DueDate = this.InvoiceDate.AddDays(timeToPay);
            //Fölligkeitsdatum auf Samstag oder Sonntag --> dann setzen wir das Fälligkeitsdatum auf den nächsten Werkstag (Montag)
            if (this.DueDate.DayOfWeek == DayOfWeek.Saturday) //day of week --< Enumerationen mit genau 7 Werten
            {
                this.DueDate = this.DueDate.AddDays(2);
            }
            else if(this.DueDate.DayOfWeek == DayOfWeek.Sunday)
            {
                this.DueDate = this.DueDate.AddDays(1);
            }
        }

        public string Info
        {
            get
            {
                return this.InvoiceNr + "; " + this.Amount + " Euro; Rechnungsdatum: " + this.InvoiceDate.ToShortDateString() + "; Fälligkeitsdatum: " + this.DueDate.ToLongDateString();
            }
        }
        public string InfoShort
        {
            get
            {
                return this.InvoiceNr + "; Fälligkeitsdatum: " + this.DueDate.ToLongDateString();
            }
        }
    }
}
