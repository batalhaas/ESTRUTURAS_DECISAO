using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para entrar com as notas P1 e P2
        Console.Write("Digite a nota da P1: ");
        double p1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da P2: ");
        double p2 = Convert.ToDouble(Console.ReadLine());

        // Calcula a média conforme a fórmula dada
        double media = (p1 + 2 * p2) / 3;

        // Exibe a média calculada
        Console.WriteLine($"Média do aluno: {media:F2}");

        // Determina a situação final do aluno com base na média de aprovação
        if (media >= 5.0)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}