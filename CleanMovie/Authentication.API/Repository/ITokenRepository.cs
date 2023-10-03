using Authentication.API.Models;

namespace Authentication.API.Repository
{
    public interface ITokenRepository
    {
        Tokens Authenticate(Users users);
    }
}
