using CsharpCrud.Models;

namespace CsharpCrud.Repository
{
    public interface IClienteRepository
    {

        Cliente ListarPorId(int id);

        List<Cliente> BuscarTodos();

        Cliente Adicionar(Cliente cliente);
        Cliente Atualizar(Cliente cliente);

        bool ConfirmarExclusao(int id);
    }
}
