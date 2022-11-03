using System;
namespace SeminarioP2.Classes
{
    public class AdapterCarro : Veiculo
    {
        public VeiculoCarro carro { get; set; }

        public override void exibeDetalhes()
        {
            Console.WriteLine(carro.exibeModelo());
            carro.exibeBeneficios();
        }
    }
}
