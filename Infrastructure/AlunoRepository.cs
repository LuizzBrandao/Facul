using Facul.Domain.Entities;
using Facul.Domain.Interfaces;

namespace Facul.Infrastructure
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public void Add(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public List<Aluno> GetAll()
        {
            return alunos;
        }

        public Aluno GetByEmail(string email)
        {
            return alunos.FirstOrDefault(a => a.Email == email);
        }
    }
}