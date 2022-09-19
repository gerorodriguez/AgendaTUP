using AgendaApi.Entities;
using AgendaApi.Models;

namespace AgendaApi.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        public User? ValidateUser(AuthenticationRequestBody authRequestBody);
        public User? GetUserById(int userId);
    }
}
