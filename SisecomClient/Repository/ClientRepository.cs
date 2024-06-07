using SisecomClient.Data;
using SisecomClient.Models;

namespace SisecomClient.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly BankContext _bankContext;
        public ClientRepository(BankContext bankContext) 
        {
            _bankContext = bankContext;
        }

        public List<ClientModel> FindAll() 
        {
            return _bankContext.Clients.ToList();
        }

        // Salvar no banco de dados
        public ClientModel Adicionar(ClientModel client)
        {
            _bankContext.Clients.Add(client);
            _bankContext.SaveChanges();

            return client;
        }
    }
}
