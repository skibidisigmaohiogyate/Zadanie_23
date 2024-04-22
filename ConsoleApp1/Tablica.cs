using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablica
    {
        public void Wyswietl(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]+ ", ");
            }

        }
        public int[] Tworzenie_tablicy()
        {
            Console.WriteLine("Ile znakow ma miec tablica?");
            int dl = int.Parse(Console.ReadLine());
            int[] ints = new int[dl];

            for (int i = 0; i < dl; i++)
            {
                Console.Write("Podaj kolejny element:");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
    }
}

