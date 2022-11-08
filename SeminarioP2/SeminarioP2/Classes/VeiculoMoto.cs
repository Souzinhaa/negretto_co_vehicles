using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoMoto : IVeiculo
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public string modelo { get; set; }
        public string beneficio { get; set; }

        public VeiculoMoto()
        {
        }

        public VeiculoMoto(string modelo, string beneficio)
        {
            this.tipo = 1;
            this.modelo = modelo;
            this.beneficio = beneficio;
        }

        public string exibeBeneficios()
        {
            return this.beneficio;
        }

        public string exibeModelo()
        {
            return modelo + " Moto";
        }
        public int getTipo()
        {
            return this.tipo;
        }
    }
}
