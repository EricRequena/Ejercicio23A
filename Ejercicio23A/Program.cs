using System;
namespace Ejercicio23A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MSGInt = "Selecciona una opció";
            const string MSGInt1Option = "Introdueix el tamany del costat del quadrat";
            const string MSGInt2Option = "Introdueix el tamany dels dos costats del rectangle";
            const string MsgInt3Option = "Introdueix el radi del cercle";
            const string MsgInt4Option0 = "Introdueix el costat del pentagon";
            const string MsgInt4Option1 = "Introdueix el apotema del pentagon";

            int option, OneVal, SecondVal;

            double pi = Math.PI; // Corrected: Math.PI is the correct way to access the value of pi.

            Console.WriteLine(MSGInt);
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(MSGInt1Option);
                    OneVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Cuadrat(OneVal));
                    break;

                case 2:
                    Console.WriteLine(MSGInt2Option);
                    OneVal = Convert.ToInt32(Console.ReadLine());
                    SecondVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Rectangle(OneVal, SecondVal));
                    break;

                case 3:
                    Console.WriteLine(MsgInt3Option);
                    OneVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Cercle(OneVal, pi)); // Corrected: Pass pi as an argument.
                    break;

                case 4:
                    Console.WriteLine(MsgInt4Option0);
                    OneVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgInt4Option1);
                    SecondVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Penta(OneVal, SecondVal));
                    break;
            }
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