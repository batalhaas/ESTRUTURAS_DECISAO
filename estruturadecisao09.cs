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

        Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        double imc = CalcularIMC(peso, altura);

        Console.WriteLine($"O IMC da pessoa é: {imc}");

        if (sexo == 'M')
        {
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
        else if (sexo == 'F')
        {
            if (imc < 19)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 19 && imc < 24)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, insira M para masculino ou F para feminino.");
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}
