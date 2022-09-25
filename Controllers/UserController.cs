using AgendaApi.Data.Repository.Implementations;
using AgendaApi.Entities;
using AgendaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : Controller
    {
        private UserRepository _userRepository { get; set; }
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userRepository.GetAll());
            //try
            //{
            //    return Ok(_userRepository.GetAll());
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetOneById(int Id)
        {
            try
            {
                return Ok(_userRepository.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateUser(CreateAndUpdateUserDto dto)
        {
            try
            {
                _userRepository.Create(dto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Created("Created", dto);
        }

        [HttpPut]
        public IActionResult UpdateUser(CreateAndUpdateUserDto dto)
        {
            try
            {
                _userRepository.Update(dto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("{Id}")]
        public IActionResult DeleteUser(int Id)
        {
            try
            {
                _userRepository.Delete(Id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}
