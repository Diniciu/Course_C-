// Operadores e operações

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula05
{
    public class aula05
    {
        static void Main(string[] args)
        {
            // int resultado = (10 + 5) * 2; - Uso de parênteses para impor precedência na operação matemática.

            /*   
                bool resultadoUm = 10 < 5; - Operador 'menor que'; FALSE. 
                bool resultado1 = 10 > 5; - Operador 'maior que'; TRUE.

                bool resultadoDois = 10 != 5; - Operador 'diferente de'; TRUE.
                bool resultado2 = 10 != 10; - FALSE
            */

            /*
                int numero = 10;
                numero ++; - Incrementa o número uma vez. -> Funciona exclusivamente quando o incremento é apenas com o número '1' <- 

                numero += 2;  Incrementa o número duas vezes. 
                numero -= 2;  Decrementa o número duas vezes. 
                numero *= 2;  Multiplica o número duas vezes. 
                numero /= 2;  Divide o número duas vezes. 
            */

            /*
                bool condicaoOu1 = (5 > 3) || (10 > 5); || = (OR/OU) - Retorna 'true' se uma das condições forem 'true'.
                bool condicaoOu2 = (5 > 7) || (10 > 5); || = (OR/OU) - Do contrário, retorna 'false'.

                bool condicaoAnd1 = (18 > 9) && (27 < 54); && = (AND/E) - Retorna 'true' quando todas as condições são 'true'.
                bool condicaoAnd2 = (12 > 4) && (31 > 74);  && = (AND/E) - Senão, toda a condição é 'false'.
            */

            System.Console.WriteLine();
        }
    }
}