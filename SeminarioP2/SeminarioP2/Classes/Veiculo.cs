using SeminarioP2.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace SeminarioP2.Classes
{
    public class Veiculo : IVeiculo
    {
        public int id { get; set; }
        public int tipo { get; set; }
        public string modelo { get; set; }
        public string beneficio { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string modelo, string beneficio)
        {
            this.tipo = 0;
            this.modelo = modelo;
            this.beneficio = beneficio;
        }

        public Veiculo(int id, int tipo, string modelo, string beneficio)
        {
            this.id = id;
            this.tipo = tipo;
            this.modelo = modelo;
            this.beneficio = beneficio;
        }

        public string exibeBeneficios()
        {
            return this.beneficio;
        }

        public string exibeModelo()
        {
            return modelo;
        }
        public string getModelo()
        {
            return modelo;
        }
        public virtual void exibeDetalhes()
        {
            Console.WriteLine(exibeModelo());
            exibeBeneficios();
        }
        public int getTipo()
        {
            return this.tipo;
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
        }
    }
}
