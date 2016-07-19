using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC_AJAX.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public static IEnumerable<Usuario> GetAll() {
            yield return new Usuario { Id = 1, Nome = "Willian", Senha = "123" };
            yield return new Usuario { Id = 2, Nome = "Edson", Senha = "456" };
        }
    }
}