using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class ClienteRepositorio
    {
        private Contexto db = new Contexto();
        public Cliente Buscar(int id){
            return db.Clientes.Find(id);
        }

        public Cliente Adicionar(Cliente cliente){
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return cliente;
        }

        public void Editar(Cliente cliente){
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Cliente> Listar(){
            return db.Clientes;
        }

        public void Deletar(int id){
            var cliente = Buscar(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }

        public IEnumerable<Cliente> BuscarClientePorIdade(int idade){
            var query = from c in db.Clientes
                        where c.Idade == idade
                        select c;
            return query;
        }

        public IEnumerable<Cliente> BuscarClientePorNome(string nome)
        {
            var query = from c in db.Clientes
                        where c.Nome.ToLower().Contains(nome.ToLower())
                        select c;
            return query;
        }
    }
}