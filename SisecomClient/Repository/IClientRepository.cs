using SisecomClient.Models;
using SisecomClient;

namespace SisecomClient.Repository
{
    public interface IClientRepository 
    {
        ClientModel ListForId(int id);
        List<ClientModel> FindAll();
        ClientModel Addition(ClientModel client);
        ClientModel Change(ClientModel client);

        bool Delete(int id);
    }
}
