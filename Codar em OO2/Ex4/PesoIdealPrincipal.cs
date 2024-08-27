using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex4
{
    internal class PesoIdealPrincipal
    {
        public void rodarApp()
        {
            Console.WriteLine("### Bem Vindo(a) ###");
            Console.WriteLine("Antes de tudo, como te identificas? (M para masculino e F para feminino");
            char genero = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Qual sua altura?");
            float altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(altura);
            double resultado;

            switch (genero) {
                case 'M':
                case 'm':
                    PesoIdealHomem pih = new PesoIdealHomem();
                    resultado = pih.getPesoIdeal(altura);
                    Console.WriteLine($"Seu resultado foi de : {resultado}");
                    break;
                case 'F':
                case 'f':
                    PesoIdealMulher pim = new PesoIdealMulher();
                    resultado = pim.getPesoIdeal(altura);
                    Console.WriteLine($"Seu resultado foi de : {resultado}");

                    break;
                default:
                    Console.WriteLine("Não possuímos algoritmo para retornar seu peso ideal. Sentimos muito.");
                    break;

            }
        }
    }
}
