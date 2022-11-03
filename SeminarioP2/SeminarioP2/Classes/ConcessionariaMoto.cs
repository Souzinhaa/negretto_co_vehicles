using SeminarioP2.Interface;
namespace SeminarioP2.Classes
{
    public class ConcessionariaCarro : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string modelo, string beneficio)
        {
            return new VeiculoMoto(modelo, beneficio);
        }
    }
}
