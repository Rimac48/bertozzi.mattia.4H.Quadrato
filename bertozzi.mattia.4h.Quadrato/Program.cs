using System;
using bertozzi.mattia._4h.Quadrato.Models;

namespace bertozzi.mattia._4h.Quadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Quadrato di Mattia Bertozzi");

            //10,5 sono i valori x e y del punto, 25 è il lato
            Q Q1 = new Q(10,5,25);

            Console.WriteLine(Q1.OutPunto());

            Q Q2 = new Q(0,0,15);

            Console.WriteLine("Dati Quadrato Q1");
            Console.WriteLine($"\tArea:\t\t{Q1.CArea()}");
            Console.WriteLine($"\tPerimetro:\t{Q1.CPerimetro()}");
            Console.WriteLine($"\tDiagonale:\t{Q1.CDiagonale()}");

            Console.WriteLine("Dati Quadrato Q2");
            Console.WriteLine($"\tArea:\t\t{Q2.CArea()}");
            Console.WriteLine($"\tPerimetro:\t{Q2.CPerimetro()}");
            Console.WriteLine($"\tDiagonale:\t{Q2.CDiagonale()}");

            Console.WriteLine("Eseguo Confronto tra i Quadrati");

            if (Q1>Q2)
            {
                Console.WriteLine("il Quadrato Q1 è più grande");
            }
            else
            {
                Console.WriteLine("il Quadrato Q2 è più grande");
            }

        }
    }
}
