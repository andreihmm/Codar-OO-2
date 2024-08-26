using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codar_em_OO2.Ex2;

namespace Codar_em_OO2.Ex2
{
    

    internal class Airport
    {
        IFlyingTransport? Vehicle { get; set; }
        public bool accept(IFlyingTransport veiculo, string origem, string destino, int passageiros)
        {
            if (Vehicle != null)
            {
                Console.WriteLine("Airport ocupado!!!");
                return false;
            }
            Vehicle = veiculo;
            Vehicle.fly(origem, destino, passageiros);
            return true;
        }
        public void Clean()
        {
            Vehicle = null;
        }
    }
}
