using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Codar_em_OO2.Ex1;


namespace Codar_em_OO2.Ex1
{
    internal class ProfDE : Professor
    {

        public ProfDE(String nomeP, int matricula, int cargaHoraria, double beneficio)
        {
            Professor(nomeP, matricula, cargaHoraria, beneficio);
        }


        public override void calcularBeneficio()
        {
            
            Console.WriteLine($"\n{}()");
        }
    }
}
