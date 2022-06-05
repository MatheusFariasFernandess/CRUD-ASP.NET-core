using System.Collections.Generic;
namespace CRUD.Models
{
    public  class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        private static List<Usuario> listagem = new List<Usuario>();

        public IQueryable<Usuario> ExibirListagem
        {
            get { return listagem.AsQueryable(); }
        }

        static Usuario()
        {
            listagem.Add(new Usuario() { Id = 1, Nome = "Matheus",Email="matheus@outlook.com" });
            listagem.Add(new Usuario() { Id = 2, Nome = "Vítoria",Email="vitoria@outlook" });
            listagem.Add(new Usuario() { Id = 3, Nome = "Karol",Email="Karol@outlook" });
            listagem.Add(new Usuario() { Id = 4, Nome = "Elves",Email="elves@outlook" });
        }
    }



}