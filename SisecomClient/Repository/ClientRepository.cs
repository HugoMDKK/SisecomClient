using SisecomClient.Data;
using SisecomClient.Models;

namespace SisecomClient.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly BankContext _context;
        public ClientRepository(BankContext bankContext)
        {
            this._context = bankContext;
        }

        //Sistema de retorno de todos os clientes para minha página Index
        public List<ClientModel> FindAll()
        {
            return _context.Clients.ToList();
        }

        //Retorno de dados para nossa página de Editar
        public ClientModel ListForId(int id)
        {
            return _context.Clients.FirstOrDefault(x => x.Id == id);
        }

        // Salvar no banco de dados
        public ClientModel Addition(ClientModel client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();

            return client;
        }

        //Metodo de retorno de dados com e atualização para caso editado!
        public ClientModel Change(ClientModel client)
        {
             ClientModel clientDB = ListForId(client.Id);

            if (clientDB == null) throw new Exception("Ocorreu algum erro com a atualização de contato!");


                clientDB.Nome = client.Nome;
                clientDB.Abreviado = client.Abreviado;
                clientDB.Email = client.Email;
                clientDB.Telefone = client.Telefone;

                _context.Clients.Update(clientDB);
                _context.SaveChanges();

                return clientDB;            
        }

        public bool Delete(int id)
        {
            ClientModel clientDB = ListForId(id);

            if (clientDB == null) throw new System.Exception("Houve um erro na deleção do cliente!");
            
            _context.Clients.Remove(clientDB);
            _context.SaveChanges();

            return true;
        }
    }
}
