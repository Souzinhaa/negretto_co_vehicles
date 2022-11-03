using System;
namespace SeminarioP2.Classes
{
    public class AdapterMoto : Veiculo
    {
        public VeiculoMoto moto { get; set; }

        public override void exibeDetalhes()
        {
            Console.WriteLine(moto.exibeModelo());
            moto.exibeBeneficios();
        }
    }
}
