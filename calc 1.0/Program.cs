using System;

namespace calc_1._0
{
    class Program
    {
        private static string scelta;

        static void Main(string[] args)
        {
            double n1 = Operazioni.Numero();
            double n2 = Operazioni.Numero();
            string scelta = Operazioni.Scelta();
            double risultato = 0;
            switch (scelta)
            {
                case "1":


                    risultato = Operazioni.Somma(n1, n2);
                    break;
                case "2":


                    risultato = Operazioni.Differenza(n1, n2);
                    break;
                case "3":


                    risultato = Operazioni.Moltiplicazione(n1, n2);
                    break;
                case "4":


                    risultato = Operazioni.Divisione(n1, n2);
                    break;

            }
            Console.WriteLine($"{risultato}");
        }
    }
}
