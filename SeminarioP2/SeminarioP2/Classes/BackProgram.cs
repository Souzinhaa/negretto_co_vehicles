using SeminarioP2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioP2.Classes
{
    internal class BackProgram
    {
        private static BackProgram instance = null;
        private ConcessionariaFacade concessionariaFacade;
        public BackProgram() 
        { 
            concessionariaFacade = new ConcessionariaFacade();
            concessionariaFacade.iniciarConcessionarias();
        }

        public void comprarCarro(String modelo, String beneficio)
        {
            concessionariaFacade.comprarCarro(modelo, beneficio);
        }

        public void comprarMoto(String modelo, String beneficio)
        {
            concessionariaFacade.comprarMoto(modelo, beneficio);
        }

        public void comprarCaminhao(String modelo, String beneficio)
        {
            concessionariaFacade.comprarCaminhao(modelo, beneficio);
        }

        public IVeiculo venderVeiculo(int id)
        {
            return concessionariaFacade.vendaVeiculo(id);
        }

        public static BackProgram getInstance()
        {

            if (instance == null)
            {
                instance = new BackProgram();
            }


            return instance;
        }
    }
}
