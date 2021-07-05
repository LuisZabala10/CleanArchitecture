namespace ContactsCL.Domain.Entities
{
    using System.Collections.Generic;
    public class Contact : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<TelephoneNumber> TelephoneNumbers { get; set; }
            = new List<TelephoneNumber>();
    }
}
