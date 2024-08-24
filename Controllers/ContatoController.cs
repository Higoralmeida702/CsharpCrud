using CsharpCrud.Models;
using CsharpCrud.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteRepository.Adicionar(cliente);
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }
            catch (System.Exception Error)
            {
                TempData["MensagemErro"] = $"Não foi possível cadastrar seu contato, tente novamente, detalhe do erro: {Error.Message}";
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
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteRepository.Atualizar(cliente);
                    TempData["MensagemSucesso"] = $"Contato alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", cliente);
            }
            catch (System.Exception Error)
            {
                TempData["MensagemErro"] = $"Não foi possível alterar dados do seu cliente, tente novamente, detalhe do erro: {Error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ConfirmarExclusao(int id)
            {
            try
            {
                bool apagado = _clienteRepository.ConfirmarExclusao(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = $"Contato deletado com sucesso!";
                }
                else {

                    TempData["MensagemErro"] = "Não foi possível deletar os dados do seu cliente";

                }
                return RedirectToAction("Index");

            }
            catch (System.Exception Error)
            {
                TempData["MensagemErro"] = $"Não foi possível deletar os dados do seu cliente, tente novamente, detalhe do erro: {Error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Apagar(int id)
        {
            Cliente clientes = _clienteRepository.ListarPorId(id);
            return View(clientes);
        }

    }
}
