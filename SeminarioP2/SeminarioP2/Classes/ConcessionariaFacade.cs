using System;

namespace SeminarioP2.Classes
{
    public class ConcessionariaFacade
    {
        private static ConcessionariaFacade instance = null;
        private static Concessionaria concessionaria = null;
        private static Veiculo veiculo = null;
        private static Venda venda = null;

        public ConcessionariaFacade()
        {

        }

        public void iniciarConcessionaria()
        {
            concessionaria = new Concessionaria();
            veiculo = new Veiculo();
            venda = new Venda();
        }

        public static ConcessionariaFacade getInstance()
        {

            if (instance == null)
            {
                instance = new ConcessionariaFacade();

                Console.WriteLine("Criando um novo objeto de Concessionaria Facade");
            }
            else
            {
                Console.WriteLine("Usando o objeto Concessionaria Facade ja existente!");
            }


            return instance;
        }
    }
}
