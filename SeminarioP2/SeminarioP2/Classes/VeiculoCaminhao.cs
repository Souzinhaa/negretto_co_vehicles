using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class VeiculoCaminhao : IVeiculo
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public string modelo { get; set; }
        public string beneficio { get; set; }

        public VeiculoCaminhao()
        {
        }

        public VeiculoCaminhao(string modelo, string beneficio)
        {
            this.tipo = 3;
            this.modelo = modelo;
            this.beneficio = beneficio;
        }

        public string exibeBeneficios()
        {
            return this.beneficio;
        }
        public string exibeModelo()
        {
            return modelo + " Caminhao";
        }
        public int getTipo()
        {
            return this.tipo;
        }
    }
}
