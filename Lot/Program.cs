using System;
using System.Collections.Generic;

namespace Lot
{

    public static class Tiket
    {
        public static int tiket()
        {
            List<int> t1 = new List<int>() { 4, 6, 8, 10, 12, 14 };
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in t1)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine("\n");
            //foreach (var item in t2)
            //{ 
            //    Console.Write(item + " - ");
            //}
            //Console.WriteLine("\n");
            //foreach (var item in t3)
            //{
            //    Console.Write(item + " - ");
            //}
            return 0;
        }
    }

    public static class Result
    {

        public static int cijfer()
        {
            List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };
            List<int> listChoice = new List<int>();



            Random rnd = new Random();
            int cijfer = 0;

            for (int i = 0; i < 6; i++)
            {
                
                do
                {
                    cijfer = rnd.Next(1, 45);
                    if (cijfer != 44)
                    {
                        Console.WriteLine("niet 44 maar " + cijfer);
                    }
                } while (cijfer != 44);
                var gekozen = listNumbers.Find(match => match == cijfer);

                if (listNumbers.Contains(gekozen))
                {
                    listChoice.Add(gekozen);
                    listNumbers.Remove(gekozen);
                }
                else if(!listNumbers.Contains(gekozen) || gekozen == 0)
                {
                    Console.WriteLine(cijfer);
                    cijfer = rnd.Next(1,45);
                    listChoice.Add(cijfer);
                    listNumbers.Remove(cijfer);
                }
            }


            Console.ForegroundColor = ConsoleColor.Red;
            //listChoice.Sort();
            foreach (int result in listChoice)
            {
                Console.Write(result + " - ");
            }
            Console.WriteLine("\n=========================\n");


            return cijfer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var tiket = Tiket.tiket();
            Console.WriteLine("\n");
            for (int i = 0; i < 1; i++)
            {
                var result = Result.cijfer();
            }
        }
    }
}
