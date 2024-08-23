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
        public bool accept(IFlyingTransport veiculo)
        {
            if (veiculo != null)
            {
                return true;
            }
            return false;
        }
    }
}
