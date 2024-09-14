using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 36: Par ou Ímpar

            // Descrição:
            // Este exercício consiste em desenvolver um programa que leia um número inteiro
            // e informe se ele é par ou ímpar.

            // Passo a Passo:

            // 1. Entrada de Dados:
            //    - Solicite ao usuário que insira um número inteiro.
            //    - Aguarde a entrada do usuário.
            Console.WriteLine("Insira um número inteiro: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            // 2. Processamento:
            //    - Verifique se o número fornecido é par ou ímpar.
            if (num % 2 == 0)
            {
                Console.WriteLine("Número Par");
            } else
            {
                Console.WriteLine("Número Ímpar");
            }
            // 3. Saída de Dados:
            //    - Apresente se o número é par ou ímpar.

            // Exemplos:

            // - Exemplo 1:
            //   - Entrada: 7
            //   - Saída: Ímpar

            // - Exemplo 2:
            //   - Entrada: 10
            //   - Saída: Par

            // - Exemplo 3:
            //   - Entrada: -5
            //   - Saída: Ímpar

            // Exemplo em Pseudocódigo:
            // ENTRADA: numero
            // PROCESSAMENTO:
            //   - SE numero % 2 == 0 ENTÃO
            //     - EXIBIR "Par"
            //   - SENÃO
            //     - EXIBIR "Ímpar"
            Console.ReadKey();
        }
    }
}
