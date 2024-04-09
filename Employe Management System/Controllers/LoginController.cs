using Ems.Models;
using Ems.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employe_Management_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginServices loginServices;
        public LoginController(LoginServices loginServices)
        {
            this.loginServices = loginServices;
        }
        /*[HttpGet]
        public List<LoginDetails> GetLoginDetails()
        {
            return loginServices.GetLoginDetails();
        }*/
        [HttpPost]
        public string AddLoginDetails(LoginDetails details)
        {
            return loginServices.AddLoginDetails(details);
        }
        [HttpPut]
        public bool VerifyUser(LoginDetails details)
        {
            return loginServices.VerifyUser(details);
        }
    }
}
