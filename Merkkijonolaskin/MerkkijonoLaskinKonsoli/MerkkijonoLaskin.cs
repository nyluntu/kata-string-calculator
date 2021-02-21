using System;

namespace MerkkijonoLaskinKonsoli
{
    public class MerkkijonoLaskin
    {
        public MerkkijonoLaskin()
        {
        }

        public int Laske(string numerot)
        {
            if(string.IsNullOrEmpty(numerot))
            {
                return 0;
            }

            var yksittaisetNumerot = numerot.Split(",");

            int summa = 0;
            foreach (string numero in yksittaisetNumerot)
            {
                // Tänne se koodi
                int luku = int.Parse(numero);

                if(luku < 0)
                {
                    throw new MerkkijonoLaskinException("Luku oli negatiiviinen");
                }

                summa += luku;
            }
            return summa;
        }
    }


    public class MerkkijonoLaskinException : Exception
    {
        public MerkkijonoLaskinException(string message) : base(message)
        {
        }
    }
}