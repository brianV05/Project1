namespace Contact.Models;
public class Contact
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; }

    public string Address { get; set; }

    public long PhoneNumber { get; set; }

    public IEnumerable<Occupation> jobDetail {get; set;}

    
}
