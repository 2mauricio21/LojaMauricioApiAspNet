using LojaMauricio.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaMauricio.WebAPI.Controllers
{
    [Route("v1/api")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public ActionResult<dynamic> Authenticate([FromBody] Model.User loginParams) 
        {
            var user = Dal.User.Get(loginParams.UserName!, loginParams.Password!);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenServices.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }

    }
}
