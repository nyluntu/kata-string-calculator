using System;

namespace MerkkijonoLaskinKonsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonolaskin.");

            try
            {
                MerkkijonoLaskin laskin = new MerkkijonoLaskin();
                var vastaus = laskin.Laske("2,-2");
                Console.WriteLine(vastaus);
            }
            catch (MerkkijonoLaskinException ex)
            {
                Console.WriteLine("Ei voitu laskea, koska mukana negatiiviinen luku"); ;
            }
            

        }
    }
}
