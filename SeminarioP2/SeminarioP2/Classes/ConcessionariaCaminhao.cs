using SeminarioP2.Interface;

namespace SeminarioP2.Classes
{
    public class ConcessionariaCaminhao : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string modelo, string beneficio)
        {
            return new VeiculoCaminhao(modelo, beneficio);
        }
    }
}
