using RevisaoBimestral.Models;

namespace RevisaoBimestral.Repository
{
    public class EleitorRepository : IEleitorRepository
    {
        private static List<Eleitor> eleitores = new List<Eleitor>();

        private static List<Ausencia> ausencias = new List<Ausencia>();


        public string Cadastrar(Eleitor eleitor)
        {
            var eleitorExistente = eleitores
                .FirstOrDefault(e => e.CPF == eleitor.CPF);

            if (eleitorExistente != null)
            {
                return "Já existe um eleitor cadastrado com este CPF.";
            }

            eleitores.Add(eleitor);

            return "Eleitor cadastrado com sucesso.";
        }


        public List<Eleitor> ObterTodos()
        {
            return eleitores;
        }


        public string RegistrarAusencia(Ausencia ausencia)
        {
            var eleitor = eleitores
                .FirstOrDefault(e => e.CPF == ausencia.CPF);

            if (eleitor == null)
            {
                return "Eleitor não encontrado. A ausência não pode ser registrada.";
            }

            var ausenciaExistente = ausencias
                .FirstOrDefault(a =>
                    a.CPF == ausencia.CPF &&
                    a.Turno == ausencia.Turno);

            if (ausenciaExistente != null)
            {
                return "Este eleitor já possui uma ausência registrada neste turno.";
            }

            ausencias.Add(ausencia);

            return "Ausência registrada com sucesso.";
        }


        public List<Ausencia> ObterAusencias()
        {
            return ausencias;
        }
    }
}