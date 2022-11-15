using Domain.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string FreeData()
        {
            return "This is site of shimisakht.ir";
        }

        [HttpGet]
        [Authorize(Roles = RoleAccess.Admin)]
        public string AdminData()
        {
            return "This is site of shimisakht.ir";
        }

        [HttpGet]
        [Authorize(Roles = RoleAccess.Admin_Author)]
        public string AdminAuthorData()
        {
            return "This is site of shimisakht.ir";
        }


        [HttpGet]
        [Authorize(Roles = RoleAccess.AllUser)]
        public string AllUserData()
        {
            return "This is site of shimisakht.ir";
        }
    }
}
