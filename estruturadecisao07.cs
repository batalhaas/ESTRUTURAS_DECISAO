using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do primeiro lado:");
        double lado1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo lado:");
        double lado2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do terceiro lado:");
        double lado3 = double.Parse(Console.ReadLine());

        if (FormaTriangulo(lado1, lado2, lado3))
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os valores fornecidos não formam um triângulo.");
        }
    }

    static bool FormaTriangulo(double lado1, double lado2, double lado3)
    {
        return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
    }
}
