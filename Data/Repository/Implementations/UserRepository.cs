using AgendaApi.Entities;
using AgendaApi.Models;
using AgendaApi.Data;
using AgendaApi.Data.Repository.Interfaces;

namespace AgendaApi.Data.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private AgendaContext _context;
        public UserRepository(AgendaContext context)
        {
            _context = context;
        }
        public User? GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
