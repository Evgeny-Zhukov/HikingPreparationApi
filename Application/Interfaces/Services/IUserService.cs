using Application.DTO;
using System.Transactions;
using System.Net;

namespace Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<Guid> CreateUser(CreateUserVM createUserVM);
        Task<UserVM> GetUser(Guid userId);
        Task<HttpStatusCode> UpdateUser(UpdateUserVM updateUserVM);
        Task<HttpStatusCode> DeleteUser(Guid userId);
        Task<IEnumerable<UserVM>> GetAllUsers();
        Task<UserVM> GetUserByEmail(string email);
    }
}
