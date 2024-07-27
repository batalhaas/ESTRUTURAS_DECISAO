using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        int valor3 = int.Parse(Console.ReadLine());

        int maior = EncontrarMaior(valor1, valor2, valor3);
        Console.WriteLine($"O(s) maior(es) valor(es) é(são): {maior}");
    }

    static string EncontrarMaior(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            return a.ToString();
        }
        else if (b > a && b > c)
        {
            return b.ToString();
        }
        else if (c > a && c > b)
        {
            return c.ToString();
        }
        else if (a == b && b == c)
        {
            return $"{a}, {b} e {c} são iguais";
        }
        else if (a == b)
        {
            return $"{a} e {b} são iguais";
        }
        else if (a == c)
        {
            return $"{a} e {c} são iguais";
        }
        else if (b == c)
        {
            return $"{b} e {c} são iguais";
        }
        else
        {
            return $"{a}, {b} e {c} são iguais";
        }
    }
}