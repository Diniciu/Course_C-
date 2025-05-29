// Variáveis em C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula03
{
    public class aula03
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, soma;
            num1 = 10;
            num2 = 15;
            num3 = 5;

            soma = num1 + num2 + num3;

            float valor = 5.3f;
            string nome = "Vinícius";
            var aux = nome;

            System.Console.WriteLine("Welcome back, " + aux);
            System.Console.WriteLine(soma);
        }
    }
}