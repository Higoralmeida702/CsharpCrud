using CsharpCrud.Models;

namespace CsharpCrud.Repository
{
    public interface IClienteRepository
    {
        List<Cliente> BuscarTodos();

        Cliente Adicionar(Cliente cliente);
    }
}
