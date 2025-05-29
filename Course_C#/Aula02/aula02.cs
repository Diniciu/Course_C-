// Primeiro programa no padrão C# .NET

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_C_.Aula02
{
    public class aula02
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hi man, what's up?");

            if (args.GetLength(0) > 0)
            {
                System.Console.WriteLine(args.GetValue(0));
            }
        }
    }
}