using System;

namespace _12IBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berechnen des IBANs nach EIngabe von Kontonummer und Bankleitzahl
            //Lösungsidee: https://www.hettwer-beratung.de/sepa-spezialwissen/sepa-kontoverbindungsdaten/iban-pr%C3%BCfziffer-berechnung/

            Console.Write("BItte Kontonummer eingeben: ");
            string ktNr = Console.ReadLine();

            while(ktNr.Length < 11)    //11 Stellen für Kontonummer reserviert
            {
                ktNr = "0" + ktNr;
            }

            Console.Write("Bitte geben sie eine Bankleitzahl ein: ");
            string blz = Console.ReadLine();

            string bban = blz + ktNr;

            string laendererkennung = "1029";   // A --> 1 + 9 = 10; T --> 20 + 9 = 29
            laendererkennung += "00";   // 00 laut Lösungsidee

            string summeVorModulo = bban + laendererkennung;
            decimal summeVorModuloD = decimal.Parse(summeVorModulo);

            int pruefziffer = (int)(summeVorModuloD % 97);
            int ibanPruefziffer = 98 - pruefziffer;
            string ibanPruefzifferS = ibanPruefziffer.ToString();
            if(ibanPruefziffer < 10)
            {
                ibanPruefzifferS = "0" + ibanPruefzifferS;
            }

            string iban = "AT" + ibanPruefzifferS + bban;

            Console.WriteLine("IBAN: " + iban);

            for(int i = 0; i < iban.Length; i++)
            {
                if (i % 4 == 0 && i > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(iban[i]);
            }
        }
    }
}


