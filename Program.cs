using System;
 
namespace poslednya_cifra
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            string chislo_string = Convert.ToString(chislo);

            Console.WriteLine("Последняя цифра этого числа: " + chislo_string[chislo_string.Length - 1]);
        }
    }
}
