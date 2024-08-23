using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex1
{
    internal abstract class Professor
    {

        public Professor(String nome, int matricula, int cargaHoraria, double beneficio)
        {
            this._nome = nome;
            this._matricula = matricula;
            this._cargaHoraria = cargaHoraria;
            this._beneficio = beneficio;
        }

        //private String _nome;
        //public  string Nome { 
        //    get => _nome; 
        //    set => _nome = value; 
        //}
        private string _nome {  get; }
        private int _matricula {  get; }
        private int _cargaHoraria {  get; }

        private double _beneficio { get; }

        public abstract void calcularBeneficio();


    }
}
