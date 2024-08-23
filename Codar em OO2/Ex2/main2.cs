using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codar_em_OO2.Ex2;
/*
 
 Exercício
• Cenário: Aeroporto Moderno->
Implemente a hierarquia abaixo... E
depois crie uma simples aplicação para
testar a implementação.
 
 */

namespace Codar_em_OO2.Ex2
{
    internal class main2
    {
        static int Main(string[] args)
        {
            Airport a1 = new();
            Helicopter h = new Helicopter();

            a1.accept(h);

            return 0;
        }
    }
}
