using Facul.Domain.Entities;
using Facul.Domain.Interfaces;

namespace Facul.Application
{
    public class AlunoService
    {
        private readonly IAlunoRepository _repository;

        public AlunoService(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public void Matricular(Aluno aluno)
        {
            if (string.IsNullOrEmpty(aluno.FirstName))
                throw new Exception("FirstName não pode ser vazio");

            if (aluno.FirstName.Length > 50)
                throw new Exception("FirstName deve ter no máximo 50 caracteres");

            if (!aluno.Email.EndsWith("@faculdade.edu"))
                throw new Exception("Email deve terminar com @faculdade.edu");

            var alunoExistente = _repository.GetByEmail(aluno.Email);

            if (alunoExistente != null)
                throw new Exception("Email já cadastrado");

            _repository.Add(aluno);
        }

        public List<Aluno> Listar()
        {
            return _repository.GetAll();
        }
    }
}