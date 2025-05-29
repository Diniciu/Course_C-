// Constantes em C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula07
{
    public class aula07
    {
        /*
            Na variável, é possível inicializar um valor e posteriormente alterar.
            Em uma constante, uma vez atribuído um valor, não pode mais ser modificado.
        */
        static void Main(string[] args)
        {
            //'const' não é uma variável, mas segue as mesmas regras: informar o tipo, o nome e atribuir um valor a constante.
            const string firstName = "Vinícius";
            const string lastName = "Ferreira";
            const double pi = 3.1415;

            /* O compilador gera um erro pois não permite alteração do valor atribuído.
                name = "Fred"; - aula07.cs(23,13): error CS0131: O lado esquerdo de uma atribuição deve ser uma variável, uma propriedade ou um indexador
            */

            System.Console.WriteLine("First name: {0}\nLast name: {1}\nValue of Pi: {2}", firstName, lastName, pi);

            // Algumas vezes, ao longo dos programas, será utilizado a constante(const) para proteger as variáveis contra alterações.
        }
    }
}