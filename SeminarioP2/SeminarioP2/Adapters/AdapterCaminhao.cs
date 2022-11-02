using System;

namespace SeminarioP2.Classes
{
    public class AdapterCaminhao : VeiculoCaminhao
    {
        public string beneficio { get; set; }

        public virtual void exibeBeneficios()
        {
            Console.WriteLine("Veiculo Caminhao toma:");
            Console.WriteLine("benefio 1: " + this.beneficio);
        }
    }
}
