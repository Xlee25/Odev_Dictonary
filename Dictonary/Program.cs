using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenciler = new Dictionary<int, string>();

            Ogrenciler.Add(1537,"Enes Karatas");
            Ogrenciler.Add(1445,"Mahmut Kaplan");

            foreach (var Ogrenci in Ogrenciler)
            {
                Console.WriteLine(Ogrenci);
            }
        }
    }
}
