using AgendaApi.Entities;
using AgendaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public static List<Contact>FakeContacts = new List<Contact>()
        {
            new Contact()
            {
                Id = 1,
                CelularNumber = 1111111111,
                Description = "Celu personal",
                Name =  "Profe Pablo"
            },
            new Contact()
            {
                Id=2,
                TelephoneNumber = 456789,
                Description = "Telefono de emergencias",
                Name ="Hospital del pueblo"
            },
        };

        [HttpGet]
        public ActionResult GetAll()
        {

            return Ok(FakeContacts);
        }

        [HttpGet]
        [Route("GetOneById/{Id}")]
        public ActionResult GetOne(int Id)
        {
            return Ok(FakeContacts.Where(x => x.Id == Id));
        }


        [HttpPost]
        public ActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact()
            {
                CelularNumber = createContactDto.CelularNumber,
                Description = createContactDto.Description,
                Name = createContactDto.Name,
                TelephoneNumber = createContactDto.TelephoneNumber,
            };
            FakeContacts.Add(contact);
            return Created("Created",contact);
        }
    }
}
