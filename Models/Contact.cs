using System.ComponentModel.DataAnnotations;

public class Contact
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Type is required.")]
    public string Type { get; set; }

    [Required(ErrorMessage = "Value is required.")]
    public string Value { get; set; }

    // Foreign key to link with the Client
    public int ClientId { get; set; }
    public Client Client { get; set; }
}
