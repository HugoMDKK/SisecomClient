using Microsoft.AspNetCore.Mvc;
using SisecomClient.Models;
using SisecomClient.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisecomClient.Controllers
{

    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository) 
        {
            _clientRepository = clientRepository;
        }
        // Sistema de retorno de todos os clientes para a minha tela de clientes
        public IActionResult Index()
        {
            List<ClientModel> Clients = _clientRepository.FindAll();
            return View(Clients);
        }


        public IActionResult Create()
        {
            return View();
        }

        // Ação de retorno de todos os dados dos clientes para página de Edição
        public IActionResult Edit(int id)
        {
            ClientModel client = _clientRepository.ListForId(id);
            return View(client);
        }

        //Sistema de adição de novos clientes
        [HttpPost]
        public IActionResult Create(ClientModel client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clientRepository.Addition(client);
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(client);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos cadastrar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        //Atualização dos dados dos clientes
        [HttpPost]
        public IActionResult Att(ClientModel client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clientRepository.Change(client);
                    TempData["MensagemSucesso"] = "Cliente atualizado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Edit", client);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos atualizar as informações de seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        //Confirmação para apagar o cliente
        public IActionResult DeleteConfirm(int id)
        {
            ClientModel client = _clientRepository.ListForId(id);
            return View(client);          
        }

        public IActionResult Delete(int id)
        {
            try
            {
                bool delet = _clientRepository.Delete(id);

                if (delet)
                {
                    TempData["MensagemSucesso"] = "Informações do cliente apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Não conseguimos apagar as informações de seu cliente!";
                }              
                
                return RedirectToAction("Index");
            }
            catch (System.Exception erro) 
            {
                TempData["MensagemErro"] = $"Não conseguimos apagar as informações de seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            
        }  
    }
}
