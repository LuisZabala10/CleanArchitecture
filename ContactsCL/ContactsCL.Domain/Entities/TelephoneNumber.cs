﻿namespace ContactsCL.Domain.Entities
{
    public class TelephoneNumber: BaseEntity
    {
        public string Number { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
