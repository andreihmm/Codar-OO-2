using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex4
{
    internal class PesoIdealMulher : PesoIdealPessoa
    {
        public override double getPesoIdeal(float h)
        {
            return (62.1 * h) - 44.7;
        }
    }
}
