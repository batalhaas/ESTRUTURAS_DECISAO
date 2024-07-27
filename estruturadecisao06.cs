using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o peso da pessoa em kg:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da pessoa em metros:");
        double altura = double.Parse(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);

        Console.WriteLine($"O IMC da pessoa é: {imc}");

        if (imc < 20)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc >= 20 && imc < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do peso");
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}
