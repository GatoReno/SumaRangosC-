using System;

namespace SumaDeRango
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido! por favor ingresa el valor de i,j y k");
            Console.WriteLine("valor de i");
            var a = Console.ReadLine();
            Console.WriteLine("valor de j");
            var b = Console.ReadLine();
            Console.WriteLine("valor de k");
            var c= Console.ReadLine();
                 
            //ordenar();
			calcular(long.Parse(a), long.Parse(b), long.Parse(c));
		}

        private static void ordenar(long a, long b, long c)
        {
            Console.WriteLine($"Tus valores de entrada son a:{a} b:{b} c:{c}");

			long nmaj;
			long nmin;
			long mid;

			if (a > b && a > c)
			{
				nmaj = a;
			}
			else if (b > a && b > c)
			{
				nmaj = b;
			}
			else
			{
				nmaj = c;
			}

			if (a < b && a < c)
			{
				nmin = a;
			}
			else if (b < a && b < c)
			{
				nmin = b;
			}
			else
			{
				nmin = c;
			}

			if (a > nmin && a < nmaj)
			{
				mid = a;
			}
			else if (b > nmin && b < nmaj)
			{
				mid = b;
			}
			else
			{
				mid = c;
			}

			Console.WriteLine($"mayor a menor {nmaj} , {mid}, {nmin}");

			calcular(nmaj, mid, nmin);
		}

        private static void calcular(long ni, long nj, long nk)
        {
			Console.WriteLine("\n --------- \n");
			long sumx = 0;
            for (long i = ni; i <= nj; i++)
            {
                //Console.WriteLine(i);
                sumx += i;

            }

            for (long i = nj - 1; i >= nk; i--)
			{
			  	//Console.WriteLine(i);
				sumx += i;

			}


			Console.WriteLine(sumx);

			Console.ReadKey();
			
		}
    }
}
