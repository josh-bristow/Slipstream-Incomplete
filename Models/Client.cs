using Slipstream.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Client
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }

    // Additional basic details
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }

    // Navigation property to link with Addresses
    public List<Address> Addresses { get; set; }

    // Navigation property to link with Contacts
    public List<Contact> Contacts { get; set; }
}
