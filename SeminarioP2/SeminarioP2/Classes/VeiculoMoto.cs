using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoMoto : IVeiculo
    {
        public string beneficio { get; set; }

        public VeiculoMoto()
        {
        }

        public VeiculoMoto(string beneficio)
        {
            this.beneficio = beneficio;
        }

        public void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Moto toma:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
