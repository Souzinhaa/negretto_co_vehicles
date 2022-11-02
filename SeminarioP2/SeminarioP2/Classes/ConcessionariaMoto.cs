using SeminarioP2.Interface;
namespace SeminarioP2.Classes
{
    public class ConcessionariaCarro : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string beneficio)
        {
            return new VeiculoCarro(beneficio);
        }
    }
}
