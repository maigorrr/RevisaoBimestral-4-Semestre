using RevisaoBimestral.Models;

namespace RevisaoBimestral.Repository
{
    public interface IEleitorRepository
    {
        string Cadastrar(Eleitor eleitor);

        List<Eleitor> ObterTodos();

        string RegistrarAusencia(Ausencia ausencia);

        List<Ausencia> ObterAusencias();
    }
}