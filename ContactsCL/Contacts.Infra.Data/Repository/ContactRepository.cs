namespace Contacts.Infra.Data.Repository
{
    using Contacts.Infra.Data.Context;
    using ContactsCL.Domain.Entities;
    using ContactsCL.Domain.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ContactRepository : IContactRepository
    {
        private readonly ContactsDbContext _context;

        public ContactRepository(ContactsDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Contact>> GetContactsAsync()
        {
            return await _context.Contacts.Include(c => c.TelephoneNumbers).ToListAsync();
        }
    }
}
