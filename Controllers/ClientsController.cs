using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

public class ClientsController : ApiController
{
    private readonly List<Client> _clients = new List<Client>(); // Replace this with your data access layer

    // GET api/clients
    [HttpGet]
    [ResponseType(typeof(IEnumerable<Client>))]
    public IHttpActionResult GetClients()
    {
        return Ok(_clients);
    }

    // GET api/clients/{id}
    [HttpGet]
    [ResponseType(typeof(Client))]
    public IHttpActionResult GetClient(int id)
    {
        Client client = _clients.FirstOrDefault(c => c.Id == id);
        if (client == null)
            return NotFound();

        return Ok(client);
    }

    // POST api/clients
    [HttpPost]
    [ResponseType(typeof(Client))]
    public IHttpActionResult AddClient(Client client)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        
        client.Id = _clients.Count + 1;

        _clients.Add(client);

        return CreatedAtRoute("DefaultApi", new { id = client.Id }, client);
    }

    // PUT api/clients/{id}
    [HttpPut]
    [ResponseType(typeof(void))]
    public IHttpActionResult UpdateClient(int id, Client updatedClient)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        Client client = _clients.FirstOrDefault(c => c.Id == id);
        if (client == null)
            return NotFound();

        // Update the client properties with the updatedClient properties
        client.Name = updatedClient.Name;
        client.Gender = updatedClient.Gender;
        // Update other properties as needed

        return StatusCode(HttpStatusCode.NoContent);
    }

    // DELETE api/clients/{id}
    [HttpDelete]
    [ResponseType(typeof(void))]
    public IHttpActionResult DeleteClient(int id)
    {
        Client client = _clients.FirstOrDefault(c => c.Id == id);
        if (client == null)
            return NotFound();

        _clients.Remove(client);

        return Ok();
    }
}
