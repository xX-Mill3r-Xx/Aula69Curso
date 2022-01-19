using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula69Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um numero a ser criado no vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a altura de {n} pessoas.");
            double[] vet = new double[n];
            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vet[i];
            }

            double avg = soma / n;
            Console.WriteLine($"AVERANGE HEIGTH: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
