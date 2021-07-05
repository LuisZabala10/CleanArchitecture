namespace ContactsCL.Domain.Interfaces
{
    using ContactsCL.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetContactsAsync();
    }
}
