using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC_WebAPI.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public static IEnumerable<Pessoa> Pessoas()
        {
            yield return new Pessoa { Id = 1, Nome = "Paulo", Email = "paulopilao@hotmail.com", Idade = 40 };
            yield return new Pessoa { Id = 2, Nome = "Thales", Email = "thalespilao@hotmail.com", Idade = 20 };
            yield return new Pessoa { Id = 3, Nome = "Agnes", Email = "agnespilao@hotmail.com", Idade = 11 };
        }
    }
}