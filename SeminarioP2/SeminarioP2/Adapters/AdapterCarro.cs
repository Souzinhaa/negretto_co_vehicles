using System;
namespace SeminarioP2.Classes
{
    public class AdapterCarro : VeiculoCarro
    {
        public string beneficio { get; set; }

        public virtual void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Carro toma:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
