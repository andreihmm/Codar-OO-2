using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex1
{
    internal abstract class Professor
    {

        public Professor(string nome, int matricula, int cargaHoraria, double beneficio)
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
        public string _nome { get; set;  }
        public int _matricula { get; set; }
        public int _cargaHoraria { get; set;  }

        public double _beneficio { get; set;  }

        public abstract void calcularBeneficio();


    }
}
