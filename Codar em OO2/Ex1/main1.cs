using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Exercício
• Cenário: UVV Acadêmico -> Implemente a hierarquia abaixo... E depois crie uma
simples aplicação para testar a implementação. 

 */

namespace Codar_em_OO2.Ex1
{
    internal class main1
    {
        static int Main(string[] args)
        {
            ProfDE profDE = new ProfDE("andrei", 123, 20, 40);

            Console.WriteLine($"PROFDE: {profDE._nome}");

            profDE._nome = "ola";

            Console.WriteLine($"PROFDE: {profDE.Nome}");


            return 0;
        }
    }
}
