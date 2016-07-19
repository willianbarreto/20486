using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DemoDB") { }
        //public Contexto(string strConnection) : base(strConnection) { }
        public DbSet<Cliente> Clientes { get; set; }

    }
}