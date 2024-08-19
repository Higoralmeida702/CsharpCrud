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

       
    }
}
