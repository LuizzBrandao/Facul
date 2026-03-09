using Facul.Domain.Entities;

namespace Facul.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        void Add(Aluno aluno);

        List<Aluno> GetAll();

        Aluno GetByEmail(string email);
    }
}