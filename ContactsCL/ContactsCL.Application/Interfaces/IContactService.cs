namespace ContactsCL.Application.Interfaces
{
    using ContactsCL.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetContactsWithNumbersAsync();
    }
}
