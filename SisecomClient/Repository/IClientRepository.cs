using SisecomClient.Models;
using SisecomClient;

namespace SisecomClient.Repository
{
    public interface IClientRepository 
    {
        List<ClientModel> FindAll();
        ClientModel Adicionar(ClientModel client);
    }
}
