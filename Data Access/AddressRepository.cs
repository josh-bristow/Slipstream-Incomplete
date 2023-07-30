using System.Collections.Generic;
using System.Linq;

public class AddressRepository
{
    private readonly List<Address> _addresses = new List<Address>();

    public IEnumerable<Address> GetAllAddresses()
    {
        return _addresses;
    }

    public Address GetAddressById(int id)
    {
        return _addresses.FirstOrDefault(a => a.Id == id);
    }

    public void AddAddress(Address address)
    {
       
        address.Id = _addresses.Count + 1;

        _addresses.Add(address);
    }

    public void UpdateAddress(Address address)
    {
        Address existingAddress = _addresses.FirstOrDefault(a => a.Id == address.Id);
        if (existingAddress != null)
        {
            existingAddress.Type = address.Type;
            existingAddress.AddressLine1 = address.AddressLine1;

        }
    }

    public void DeleteAddress(int id)
    {
        Address address = _addresses.FirstOrDefault(a => a.Id == id);
        if (address != null)
        {
            _addresses.Remove(address);
        }
    }
}
