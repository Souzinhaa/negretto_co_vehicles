using SeminarioP2.Interface;
namespace SeminarioP2.Classes
{
    public class Concessionaria : IConcessionaria
    {
        public IVeiculo comprarVeiculo(string modelo, string beneficio)
        {
            return new Veiculo(modelo, beneficio);
        }
    }
}
