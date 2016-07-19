using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC_Autenticacao.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static IEnumerable<User> GetUsers() {
            yield return new User { Id = 1, UserName = "willian", Password = "123" };
            yield return new User { Id = 2, UserName = "barreto", Password = "abc" };
        }
    }
}