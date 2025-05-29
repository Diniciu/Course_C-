// Formatando a saída no console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula06
{
    public class aula06
    {
        static void Main(string[] args)
        {
            /*
            int n1 = 10, n2 = 20, n3 = 30;

            //System.Console.WriteLine($"N1 {n1}, N2 {n2}, N3 {n3}");
            System.Console.WriteLine("\nN1 = {0}, \nN2 = {1}, \nN3 = {2}\n", n1, n2, n3); // \n - Gera as quebra de linha.
            System.Console.WriteLine("\nN1 =\t{0}, \nN2 =\t{1}, \nN3 =\t{2}\n", n1, n2, n3); // \t - Gera uma tabulação, afastando o conteúdo entre si.
            */

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            System.Console.WriteLine("Produto...........: {0, 15}", produto); // {0, 15} - '15' refere-se ao tamanho do espaço que será adicionado entre a string (produto) e o valor da váriavel.
            System.Console.WriteLine("Val.Compra........: {0, 15:c}", valorCompra); // {0, 15:c} - ':c' indica um formato de saída monetário.
            System.Console.WriteLine("Lucro.............: {0, 15:p}", lucro); // {0, 15:p} - ':p' indica uma formatação de saída em porcentagem.
            System.Console.WriteLine("Val.Venda.........: {0, 15:c}", valorVenda);
        }
    }
}