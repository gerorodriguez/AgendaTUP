using AgendaApi.Entities;
using AgendaApi.Models;
using AgendaApi.Repository.Interfaces;
using AgendaApi.Data;

namespace AgendaApi.Repository.Implementations
{
    public class UserRespository : IUserRepository
    {
        private Context _context;
        public UserRespository(Context context)
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
    }
}
