using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

public class AddressesController : ApiController
{
    private readonly List<Address> _addresses = new List<Address>(); // Replace with data access layer

    // GET api/addresses
    [HttpGet]
    [ResponseType(typeof(IEnumerable<Address>))]
    public IHttpActionResult GetAddresses()
    {
        return Ok(_addresses);
    }

    // GET api/addresses/{id}
    [HttpGet]
    [ResponseType(typeof(Address))]
    public IHttpActionResult GetAddress(int id)
    {
        Address address = _addresses.FirstOrDefault(a => a.Id == id);
        if (address == null)
            return NotFound();

        return Ok(address);
    }

    // POST api/addresses
    [HttpPost]
    [ResponseType(typeof(Address))]
    public IHttpActionResult AddAddress(Address address)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        address.Id = _addresses.Count + 1;

        _addresses.Add(address);

        return CreatedAtRoute("DefaultApi", new { id = address.Id }, address);
    }

    // PUT api/addresses/{id}
    [HttpPut]
    [ResponseType(typeof(void))]
    public IHttpActionResult UpdateAddress(int id, Address updatedAddress)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        Address address = _addresses.FirstOrDefault(a => a.Id == id);
        if (address == null)
            return NotFound();

        // Update the address properties with the updatedAddress properties
        address.Type = updatedAddress.Type;
        address.AddressLine1 = updatedAddress.AddressLine1;
        

        return StatusCode(HttpStatusCode.NoContent);
    }

    // DELETE api/addresses/{id}
    [HttpDelete]
    [ResponseType(typeof(void))]
    public IHttpActionResult DeleteAddress(int id)
    {
        Address address = _addresses.FirstOrDefault(a => a.Id == id);
        if (address == null)
            return NotFound();

        _addresses.Remove(address);

        return Ok();
    }
}
