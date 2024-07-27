using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do lado A:");
        double ladoA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado B:");
        double ladoB = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado C:");
        double ladoC = double.Parse(Console.ReadLine());

        if (FormaTrianguloRetangulo(ladoA, ladoB, ladoC))
        {
            Console.WriteLine("Os valores formam um triângulo retângulo.");
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo retângulo.");
        }
    }

    static bool FormaTrianguloRetangulo(double a, double b, double c)
    {
        double maiorLado = Math.Max(a, Math.Max(b, c));

        if (maiorLado == a)
        {
            return Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
        else if (maiorLado == b)
        {
            return Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2);
        }
        else
        {
            return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}