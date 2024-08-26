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

        public ProfDE(string nome, int matricula, int cargaHoraria, double beneficio)
    : base(nome, matricula, cargaHoraria, beneficio) // Call to base class constructor
        {
            // Additional initialization specific to ProfDE if needed
        }



        public override void calcularBeneficio()
        {
            
            Console.WriteLine($"\nOlá()");
        }
    }
}
