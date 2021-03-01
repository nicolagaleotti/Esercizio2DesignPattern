using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizio2DesignPattern;

namespace TestEsercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabili che servono per generare stringhe casuali
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[100];
            var random = new Random();

            // creo il libro
            Libro libro = new Libro();

            // creo 30 pagine per il libro
            for(int j = 0; j<30;j++)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars);

                libro.CreaPagina(finalString);
            }

            // stampo da pagina 10 a 20
            for(int i = 9; i < 20; i++)
            {
                Console.Write($"Pagina {i + 1} : {libro.Pagine[i].StampaPagina()}");
            }

            Console.ReadLine();
        }
    }
}
