using System;
namespace Ejercicio23A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static int Rectangle(int OneVal, int SecondVal)
        {
            int resultat;

            resultat = OneVal * SecondVal;
            return resultat;
        }
        public static int Cuadrat(int OneVal)
        {
            int resultat;

            resultat = OneVal * OneVal;
            return resultat;
        }
        public static double Cercle(int OneVal, double pi) // Corrected: Change return type to double.
        {
            double resultat;

            resultat = pi * (OneVal * OneVal);
            return resultat;
        }
        public static int Penta(int OneVal, int SecondVal)
        {
            int resultat;

            resultat = (((OneVal * 5) * SecondVal) / 2);
            return resultat;
        }
    }
}