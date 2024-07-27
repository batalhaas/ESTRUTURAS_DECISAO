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

        int maior = EncontrarMaior(valor1, valor2);

        Console.WriteLine($"O maior valor é: {maior}");
    }

    static int EncontrarMaior(int a, int b)
    {
        return a > b ? a : b;
    }
}