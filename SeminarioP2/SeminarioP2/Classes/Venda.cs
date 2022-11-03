using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class Venda
    {
        public bool venderVeiculo(Veiculo veiculo)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("------ Venda realizada com sucesso ------");
            veiculo.exibeDetalhes();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            return true;
        }
    }
}
