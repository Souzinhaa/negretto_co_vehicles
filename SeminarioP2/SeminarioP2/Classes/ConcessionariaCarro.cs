using SeminarioP2.Interface;

namespace SeminarioP2.Classes
{
    public class ConcessionariaMoto : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string beneficio)
        {
            return new VeiculoMoto(beneficio);
        }
    }
}
