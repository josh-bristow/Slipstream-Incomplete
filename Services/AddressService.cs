public class AddressService
{
    private readonly AddressRepository _addressRepository;

    public AddressService(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public IEnumerable<Address> GetAllAddresses()
    {
        return _addressRepository.GetAllAddresses();
    }

    public Address GetAddressById(int id)
    {
        return _addressRepository.GetAddressById(id);
    }

    public void AddAddress(Address address)
    {
        _addressRepository.AddAddress(address);
    }

    public void UpdateAddress(Address address)
    {
        _addressRepository.UpdateAddress(address);
    }

    public void DeleteAddress(int id)
    {
        _addressRepository.DeleteAddress(id);
    }
}
