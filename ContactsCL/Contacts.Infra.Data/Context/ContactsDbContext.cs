namespace Contacts.Infra.Data.Context
{
    using ContactsCL.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {

        }
    }
}
