namespace ContactsCL.Application.Dtos
{
    using System.Collections.Generic;
    public class ContactDto
    {
        public int Id { get; set; }
        public string Contact { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<TelephoneNumberDto> TelephoneNumbers { get; set; }
    }
}
