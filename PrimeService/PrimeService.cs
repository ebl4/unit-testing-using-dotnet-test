using System;

namespace Prime.Service
{
    public class PrimeService
    {
        public bool IsPrime(int numero)
        {
            if (numero < 2) return false;

            for(var divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
            {
                if (numero % divisor == 0) return false;
            }

            return true;
        }
    }
}
