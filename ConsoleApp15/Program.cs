using System;

namespace Tashoglo15High
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число 1234:");
            int a = int.Parse(Console.ReadLine());
            Reverse(a);
            Console.ReadKey();
        }

        static void Reverse(int chislo)
        {
            int revchislo = chislo % 10;
            Console.Write(revchislo);
            chislo /= 10;

            if (chislo > 0)
                Reverse(chislo);
        }
    }
}
