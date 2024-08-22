using CsharpCrud.Models;
using CsharpCrud.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CsharpCrud.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ContatoController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            List<Cliente> clientes = _clienteRepository.BuscarTodos();
            return View(clientes); 
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            {
                _clienteRepository.Adicionar(cliente); 
                return RedirectToAction("Index"); 
            }
        }

        public IActionResult Editar(int id)
        {
            Cliente clientes = _clienteRepository.ListarPorId(id);
            return View(clientes);
        }

        [HttpPost]
        public IActionResult Alterar(Cliente cliente)
        {
            {
                _clienteRepository.Atualizar(cliente);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Apagar()
        {
            return View();
        }

    }
}
