using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoCaminhao : IVeiculo
    {
        public string beneficio { get; set; }

        public VeiculoCaminhao()
        {
        }

        public VeiculoCaminhao(string beneficio)
        {
            this.beneficio = beneficio;
        }

        public void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Caminhao Beneficios:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
