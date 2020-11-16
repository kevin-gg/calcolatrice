using System;

namespace calc_1._0
{
    public class Operazioni
    {
        public static string Scelta()

        {
            
            Console.WriteLine("Per eseguire:\nsomma digita 1 \ndifferenza digita 2 \nmoltiplicazione digita 3 \ndivisione digita 4 ");
            string scelta = Console.ReadLine();
            return scelta;
        }

            public static double Numero()
        {
            Console.WriteLine("inserisci un numero");
            double n1 = Convert.ToDouble(Console.ReadLine());
            return n1;
        }
        public static double Somma(double n1, double n2)
        {

            return n1 + n2;
        }
        public static double Differenza(double n1, double n2)
        {

            return n1 - n2;

        }
        public static double Moltiplicazione(double n1, double n2)
        {
            return n1 * n2;

        }
        public static double Divisione(double n1, double n2)
        {
            return n1 / n2;

        }

    }
}
