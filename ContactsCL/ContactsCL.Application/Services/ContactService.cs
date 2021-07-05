namespace ContactsCL.Application.Services
{
    using ContactsCL.Application.Interfaces;
    using ContactsCL.Domain.Entities;
    using ContactsCL.Domain.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository ??
                throw new ArgumentNullException(nameof(contactRepository));
        }
        public async Task<IEnumerable<Contact>> GetContactsWithNumbersAsync()
        {
            var contancts = await _contactRepository.GetContactsAsync();
            return contancts;
        }
    }
}
