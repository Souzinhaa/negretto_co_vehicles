using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoCarro : IVeiculo
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public string modelo { get; set; }
        public string beneficio { get; set; }

        public VeiculoCarro()
        {
        }
        public VeiculoCarro(string modelo, string beneficio)
        {
            this.tipo = 2;
            this.modelo = modelo;
            this.beneficio = beneficio;
        }

        public string exibeBeneficios()
        {
            return this.beneficio;
        }
        public string exibeModelo()
        {
            return modelo + " Carro";
        }
        public int getTipo()
        {
            return this.tipo;
        }
    }
}
