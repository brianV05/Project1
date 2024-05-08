using Microsoft.EntityFrameworkCore;
using Contact.Models;

namespace Contact.Data;

public class ContactDbContext : DbContext{
    public ContactDbContext() : base(){}

    public ContactDbContext(DbContextOption options) : base(options){}

    public Dbset<Contact> contact {get; set; }
    //public Dbset<Occupation> occupation {get; set; }

}