using CsharpCrud.Data;
using CsharpCrud.Models;

namespace CsharpCrud.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepository(BancoContext bancoContext)  
        {
            _bancoContext = bancoContext;
        }
        public List<Cliente> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
        public Cliente Adicionar(Cliente cliente)
        {
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public Cliente ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            Cliente contatoDb = ListarPorId(cliente.Id);

            if (contatoDb == null) throw new System.Exception("Houve um erro na atualização do cliente");
            contatoDb.Nome = cliente.Nome;
            contatoDb.Email = cliente.Email;
            contatoDb.Telefone = cliente.Telefone;

            _bancoContext.Clientes.Update(contatoDb);
            _bancoContext.SaveChanges();
            return contatoDb;
        }

        public bool ConfirmarExclusao(int id)
        {
            Cliente contatoDb = ListarPorId(id);
            if (contatoDb == null) throw new System.Exception("Houve um erro na exclusao do cliente");

            _bancoContext.Clientes.Remove(contatoDb);
            _bancoContext.SaveChanges();

            return true;

        }
    }
}
