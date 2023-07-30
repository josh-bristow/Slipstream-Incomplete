public class ClientService
{
    private readonly ClientRepository _clientRepository;

    public ClientService(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public IEnumerable<Client> GetAllClients()
    {
        return _clientRepository.GetAllClients();
    }

    public Client GetClientById(int id)
    {
        return _clientRepository.GetClientById(id);
    }

    public void AddClient(Client client)
    {
        _clientRepository.AddClient(client);
    }

    public void UpdateClient(Client client)
    {
        _clientRepository.UpdateClient(client);
    }

    public void DeleteClient(int id)
    {
        _clientRepository.DeleteClient(id);
    }
}
