using SeminarioP2.Interface;

namespace SeminarioP2.Classes
{
    public class ConcessionariaCaminhao : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string beneficio)
        {
            return new VeiculoCaminhao(beneficio);
        }
    }
}
