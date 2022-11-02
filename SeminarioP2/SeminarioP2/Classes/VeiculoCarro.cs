using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoCarro : IVeiculo
    {
        public string beneficio { get; set; }

        public VeiculoCarro()
        {
        }
        public VeiculoCarro(string beneficio)
        {
            this.beneficio = beneficio;
        }

        public void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Carro Beneficios:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
