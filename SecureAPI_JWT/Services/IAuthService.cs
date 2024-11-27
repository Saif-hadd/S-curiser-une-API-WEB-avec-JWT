using SecureAPI_JWT.Models;
using System.Threading.Tasks;

namespace SecureAPI_JWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string>AddRoleAsync(AddRoleModel model);
    }
}
