using System.Security.Claims;

namespace JwtWebAPI.Services.UserService
{
    public class UserService : IUser
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string GetName()
        {
            var result = string.Empty;  
            if (this.httpContextAccessor.HttpContext != null)
            {
                result = this.httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);

            }
            return result;  
        }
    }
}
