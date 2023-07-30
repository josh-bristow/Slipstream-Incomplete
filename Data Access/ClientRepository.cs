using System.Collections.Generic;
using System.Linq;

public class ClientRepository
{
    private readonly List<Client> _clients = new List<Client>();

    public IEnumerable<Client> GetAllClients()
    {
        return _clients;
    }

    public Client GetClientById(int id)
    {
        return _clients.FirstOrDefault(c => c.Id == id);
    }

    public void AddClient(Client client)
    {
        
        client.Id = _clients.Count + 1;

        _clients.Add(client);
    }

    public void UpdateClient(Client client)
    {
        Client existingClient = _clients.FirstOrDefault(c => c.Id == client.Id);
        if (existingClient != null)
        {
            existingClient.Name = client.Name;
            existingClient.Gender = client.Gender;
         
        }
    }

    public void DeleteClient(int id)
    {
        Client client = _clients.FirstOrDefault(c => c.Id == id);
        if (client != null)
        {
            _clients.Remove(client);
        }
    }
}
