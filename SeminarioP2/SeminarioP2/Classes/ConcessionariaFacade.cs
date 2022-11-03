using SeminarioP2.Interface;
using System;

namespace SeminarioP2.Classes
{
    public class ConcessionariaFacade
    {
        private static ConcessionariaFacade instance = null;

        private static CadastroEntities dbContext = null;

        private static ConcessionariaCarro concessionariaCarro = null;
        private static ConcessionariaMoto concessionariaMoto = null;
        private static ConcessionariaCaminhao concessionariaCaminhao = null;

        private static IVeiculo veiculo = null;

        private static Venda venda = null;

        public ConcessionariaFacade()
        {

        }

        public void iniciarConcessionarias()
        {
            concessionariaCarro = new ConcessionariaCarro();
            concessionariaMoto = new ConcessionariaMoto();
            concessionariaCaminhao = new ConcessionariaCaminhao();
            venda = new Venda();

            dbContext = CadastroEntities.getInstance();

            mostrarLog("- Concessionarias iniciadas com sucesso -");
        }

        public void comprarMoto(String modelo, String beneficio)
        {
            if (veiculo == null)
            {
                veiculo = concessionariaMoto.comprarVeiculo(modelo, beneficio);
                mostrarLog("------- Moto comprada com sucesso -------");
            }
            else
            {
                mostrarLogWarn();
            }
        }

        public void comprarCarro(String modelo, String beneficio)
        {
            if (veiculo == null)
            {
                veiculo = concessionariaCarro.comprarVeiculo(modelo, beneficio);
                mostrarLog("------ Carro comprado com sucesso  ------");
            }
            else
            {
                mostrarLogWarn();
            }
        }

        public void comprarCaminhao(String modelo, String beneficio)
        {
            if (veiculo == null)
            {
                veiculo = concessionariaCaminhao.comprarVeiculo(modelo, beneficio);
                mostrarLog("----- Caminhao comprado com sucesso -----");
            }
            else
            {
                mostrarLogWarn();
            }
        }

        public void mostrarLog(String log)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine(log);
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }

        public void mostrarLogWarn()
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("! Voce precisa vender o veiculo antes de comprar outro !");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();
        }

        public void venderVeiculo()
        {
            switch (veiculo.getTipo())
            {
                case 1:
                    AdapterMoto adapterMoto = new AdapterMoto();
                    adapterMoto.moto = (VeiculoMoto)veiculo;
                    if (venda.venderVeiculo(adapterMoto))
                        veiculo = null;
                    break;
                case 2:
                    AdapterCarro adapterCarro = new AdapterCarro();
                    adapterCarro.carro = (VeiculoCarro)veiculo;
                    if (venda.venderVeiculo(adapterCarro))
                        veiculo = null;
                    break;
                case 3:
                    AdapterCaminhao adapterCaminhao = new AdapterCaminhao();
                    adapterCaminhao.caminhao = (VeiculoCaminhao)veiculo;
                    if (venda.venderVeiculo(adapterCaminhao))
                        veiculo = null;
                    break;
            }
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
