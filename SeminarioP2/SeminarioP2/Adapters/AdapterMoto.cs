using System;
namespace SeminarioP2.Classes
{
    public class AdapterMoto : VeiculoMoto
    {
        public string beneficio { get; set; }

        public virtual void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Moto toma:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
