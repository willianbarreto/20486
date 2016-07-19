using DemoMVC.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Digite um nome")]
        public string Nome { get; set; }
        [DisplayName("Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ValidaPar(ErrorMessage="A idade deve ser par")]
        public int Idade { get; set; }

        //public IEnumerable<Cliente> GetClientes()
        //{
        //    yield return new Cliente { Id = 1, Nome = "Willian", DataNascimento = new DateTime(1987, 11, 24), Email = "ws.barreto@hotmail.com", Idade = 28 };
        //    yield return new Cliente { Id = 2, Nome = "Edson", DataNascimento = new DateTime(1965, 09, 24), Email="xxx@example.com", Idade=21 };
        //    yield return new Cliente { Id = 3, Nome = "Isabele", DataNascimento = new DateTime(2009, 01, 16), Email="" };
        //    yield return new Cliente { Id = 4, Nome = "Mikaelle", DataNascimento = new DateTime(2005, 04, 20), Email = "" };
        //    yield return new Cliente { Id = 5, Nome = "Miguel", DataNascimento = new DateTime(2000, 07, 02), Email = "" };
        //    yield return new Cliente { Id = 6, Nome = "Henrique", DataNascimento = new DateTime(2002, 08, 11), Email = "" };
        //}

    }
}