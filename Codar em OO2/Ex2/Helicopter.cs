using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex2
{
    internal class Helicopter : IFlyingTransport
    {
        public void fly(String origem, String destino, int passageiros)
        {
            Console.WriteLine($"HELICOPTERO:: Sainde de: {origem} Para: {destino} Quantos passageiros: {passageiros}");
        }
    }
}
