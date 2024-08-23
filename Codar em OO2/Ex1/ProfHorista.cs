using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex1
{
    internal class ProfHorista : Professor
    {
        private double valorHora;

        public override void calcularBeneficio()
        {
            double aux = getBeneficio() * valorHora;
            Console.WriteLine($"\n{aux}");
        }
    }
}
