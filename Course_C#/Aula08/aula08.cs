// Lendo valores do teclado 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula08
{
    public class aula08
    {
        static void Main(string[] args)
        {
            string nome;
            int valor1, valor2, valor3, soma, media;

            System.Console.Write("Digite seu nome: ");
            nome = Console.ReadLine(); // Console.ReadLine() | Console.Read() - armazenam um valor que é lido pelo teclado após digitado pelo indivíduo.

            System.Console.WriteLine("Digite um valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 - método que converte o que vem como parâmetro de 'string' em inteiro (int) e guarda na variável.

            System.Console.WriteLine("Digite um segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine()); // O método de conversão é usado novamente para lê um segundo valor.

            System.Console.WriteLine("Digite um terceiro valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine()); // Por último, o programa pede outro valor para converter e armazenar.

            soma = valor1 + valor2 + valor3; // Uma vez vazia, a variável 'soma' é usada para armazenar os 3 valores (valor1, valor2, valor3).
            media = (valor1 + valor2 + valor3) / 3; // A variável 'media' recebe os 3 valores somados e os divide por 3.

            // Na linha abaixo, é imprimido o nome do usuário(a) e os números digitados.
            System.Console.WriteLine("Olá {0}, os números que você digitou é: {1}, {2}, {3}.", nome, valor1, valor2, valor3);
            System.Console.WriteLine("Somados, o valor é {0}. Caso queira a média, o resultado é {1}.", soma, media);
            // Na linha acima, é mostrado o valor somado entre eles usando a variável 'soma' e depois sua 'media' em resultado da divisão.
        }
    }
}