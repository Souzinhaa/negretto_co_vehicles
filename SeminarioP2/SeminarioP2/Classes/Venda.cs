using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class Venda
    {

        public void venderVeiculo(IVeiculo veiculo)
        {
            Console.WriteLine("Venda realizada com sucesso");
            Console.WriteLine("Beneficio Aplicado: ");
            veiculo.exibeBeneficios();

        }
    }
}
