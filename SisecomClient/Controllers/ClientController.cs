using Microsoft.AspNetCore.Mvc;
using SisecomClient.Models;
using SisecomClient.Repository;

namespace SisecomClient.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository) 
        {
            _clientRepository = clientRepository;
        }
        public IActionResult Index()
        {
            List<ClientModel> Clients = _clientRepository.FindAll();
            return View(Clients);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientModel client)
        {
            _clientRepository.Adicionar(client);
            return RedirectToAction("Index");
        }
    }
}
