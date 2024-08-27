using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex4
{
    internal class PesoIdealHomem : PesoIdealPessoa
    {
        public override double getPesoIdeal(float h)
        {
            return 72.7 * h - 58;
        }
    }
}
