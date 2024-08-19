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

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

    }
}
