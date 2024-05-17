using System.ComponentModel.DataAnnotations;

namespace SemIdentity.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }

         public int Idade { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
