using SeminarioP2.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace SeminarioP2.Classes
{
    public class Veiculo : IVeiculo
    {
        [Key]
        public string beneficio { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string beneficio)
        {
            this.beneficio = beneficio;
        }

        public void exibeBeneficios()
        {
            Console.WriteLine("Veiculo:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
