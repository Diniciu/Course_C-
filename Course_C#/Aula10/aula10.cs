// Enumeradores (enum)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula10
{
    public class aula10
    {
        enum DiasSemana
        {
            Segunda, Terça, Quarta, Quita, Sexta, Sábado, Domingo
        }
        static void Main(string[] args)
        {
            // Dentro da váriavel 'ds' foi armazenado um dia, diretamente associado para esse tipo de enumerador '(enum)'.

            // DiasSemana ds = (DiasSemana) 3;

            // Número pós 'enum' entre parênteses refere-se ao seu índice; exemplo: '2' -> 'Quarta'. 
            // Qualquer valor colocado como índice convertido nos dias da semana retorna o valor do enumerador '(enum)'.

            /*
            int ds = (int)DiasSemana.Sexta; // '(int)' converte o valor em um inteiro pegando o índice do enum (sexta-feira[4]) e armazenando na váriavel 'ds'.
            System.Console.WriteLine(ds);
            */
        }
    }
}