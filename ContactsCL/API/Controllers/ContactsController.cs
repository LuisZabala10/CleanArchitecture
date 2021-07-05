using AutoMapper;
using ContactsCL.Application.Dtos;
using ContactsCL.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ContactsController : BaseController
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService,IMapper mapper)
        {
           _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
           _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetContactsAsync()
        {
            var contacts = await _contactService.GetContactsWithNumbersAsync();

            var contactsToReturn = _mapper.Map<IEnumerable<ContactDto>>(contacts);

            return Ok(contactsToReturn);
        }
    }
}
