using AgendaApi.Entities;
using AgendaApi.Models;
using AgendaApi.Repository.Interfaces;

namespace AgendaApi.Repository.Implementations
{
    public class UserRespository : IUserRepository
    {
        public User? GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            if (authRequestBody.UserType == "guest")
                return _context.Students.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
            return _context.Professors.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }
    }
}
