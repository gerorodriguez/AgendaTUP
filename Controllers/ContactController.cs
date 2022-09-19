using AgendaApi.Entities;
using AgendaApi.Models;
using AgendaApi.Data.Repository.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactController : ControllerBase
    {
        private ContactRepository _contactRepository { get; set; }

        public ContactController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {

            return Ok(_contactRepository.GetAll());
        }

        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetOne(int Id)
        {
            return Ok(_contactRepository.GetAll().Where(x => x.Id == Id));
        }


        [HttpPost]
        public ActionResult CreateContact(CreateContactDto createContactDto)
        {
            try
            {
                _contactRepository.Create(createContactDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Created("Created", createContactDto);
        }


    }
}
