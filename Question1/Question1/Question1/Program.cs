using System;
using System.Collections;
using System.Text;

namespace csdeneme
{
    class Program
    {
        static void Main()
        {
            int n = 2520;

            back:

            for (int i = 1; i <= 20; i++)
            {
                if (n % i != 0)
                {
                    n++;
                    goto back;
                }
            }
            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}