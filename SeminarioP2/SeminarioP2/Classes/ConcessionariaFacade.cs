using SeminarioP2.Interface;
using System;
using System.Linq;

namespace SeminarioP2.Classes
{
    public class ConcessionariaFacade
    {
        private static ConcessionariaFacade instance = null;

        private static ConcessionariaCarro concessionariaCarro = null;
        private static ConcessionariaMoto concessionariaMoto = null;
        private static ConcessionariaCaminhao concessionariaCaminhao = null;

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

            mostrarLog("- Concessionarias iniciadas com sucesso -");
        }

        public void comprarMoto(String modelo, String beneficio)
        {
            IVeiculo veiculo = null;
            if (veiculo == null)
            {
                veiculo = concessionariaMoto.comprarVeiculo(modelo, beneficio);
                saveChanges(veiculo);
                mostrarLog("------- Moto comprada com sucesso -------");
            }
            else
            {
                mostrarLogWarn();
            }
        }

        public void comprarCarro(String modelo, String beneficio)
        {
            IVeiculo veiculo = null;
            if (veiculo == null)
            {
                veiculo = concessionariaCarro.comprarVeiculo(modelo, beneficio);
                saveChanges(veiculo);
                mostrarLog("------ Carro comprado com sucesso  ------");
            }
            else
            {
                mostrarLogWarn();
            }
        }

        public void comprarCaminhao(String modelo, String beneficio)
        {
            IVeiculo veiculo = null;
            if (veiculo == null)
            {
                veiculo = concessionariaCaminhao.comprarVeiculo(modelo, beneficio);
                saveChanges(veiculo);
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

        public IVeiculo vendaVeiculo(int id)
        {
            using (ConcessionariaEntities ctx = new ConcessionariaEntities())
            {
                if (ctx == null)
                {
                    return null;
                }

                Table itemTable = ctx.Table.Where(x => x.Id == id).SingleOrDefault();

                IVeiculo veiculo = null;

                if (itemTable != null)
                {
                    ctx.Table.Remove(itemTable);
                    ctx.SaveChanges();

                    switch (itemTable.Categoria) {
                        case 1:
                            veiculo = new VeiculoMoto(itemTable.Modelo, itemTable.Beneficio);
                            return veiculo;
                        case 2:
                            veiculo = new VeiculoCarro(itemTable.Modelo, itemTable.Beneficio);
                            return veiculo;
                        case 3:
                            veiculo = new VeiculoCaminhao(itemTable.Modelo, itemTable.Beneficio);
                            return veiculo;
                    }
                }
            }

            return null;
        }

        public void venderVeiculo(IVeiculo veiculo)
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

        public void saveChanges(IVeiculo veiculo) {
            using (ConcessionariaEntities dbContext = new ConcessionariaEntities())
            {
                Table t = new Table();
                t.Beneficio = veiculo.exibeBeneficios();
                t.Modelo = veiculo.exibeModelo();
                t.Categoria = veiculo.getTipo();
                dbContext.Table.Add(t);
                dbContext.SaveChanges();
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
