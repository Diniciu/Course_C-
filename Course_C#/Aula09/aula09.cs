//Operações de Bitwise

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula09
{
    public class aula09
    {
        static void Main(string[] args)
        {
            // << - Bitwise para esquerda vai dobrar o valor da variável.
            // >> - Bitwise para a direita vai diminuir pela metade o valor da variável.

            int num = 20;

            num = num << 2;

            System.Console.WriteLine(num); 
        }
    }
}