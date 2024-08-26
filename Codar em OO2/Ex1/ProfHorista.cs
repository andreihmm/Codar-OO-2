using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex1
{
    internal class ProfHorista : Professor
    {
        public double valorHora { get; set; }

        public ProfHorista(double valorHora, string nome, int matricula, int cargaHoraria, double beneficio)
    : base(nome, matricula, cargaHoraria, beneficio) // Call to base class constructor
        {
            this.valorHora = valorHora;
        }

        public override void calcularBeneficio()
        {
            double aux = _beneficio * valorHora;
            Console.WriteLine($"\n{aux}");
        }
    }
}
