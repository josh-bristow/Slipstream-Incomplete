using System.ComponentModel.DataAnnotations;

public class Address
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Type is required.")]
    public string Type { get; set; }

    [Required(ErrorMessage = "Address Line 1 is required.")]
    public string AddressLine1 { get; set; }

    // Additional address fields
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    [Required(ErrorMessage = "Postal Code is required.")]
    public string PostalCode { get; set; }

    // Foreign key to link with the Client
    public int ClientId { get; set; }
    public Client Client { get; set; }
}
