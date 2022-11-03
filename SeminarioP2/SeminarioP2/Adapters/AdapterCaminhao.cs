using System;

namespace SeminarioP2.Classes
{
    public class AdapterCaminhao : Veiculo
    {
        public VeiculoCaminhao caminhao { get; set; }

        public override void exibeDetalhes()
        {
            Console.WriteLine(caminhao.exibeModelo());
            caminhao.exibeBeneficios();
        }
    }
}
