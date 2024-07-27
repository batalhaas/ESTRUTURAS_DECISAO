using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor da base do retângulo:");
        double baseRetangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura do retângulo:");
        double alturaRetangulo = double.Parse(Console.ReadLine());

        double area = baseRetangulo * alturaRetangulo;

        Console.WriteLine($"A área do retângulo é: {area}");

        if (area > 100)
        {
            Console.WriteLine("Terreno grande");
        }
        else
        {
            Console.WriteLine("Terreno pequeno");
        }
    }
}
}
