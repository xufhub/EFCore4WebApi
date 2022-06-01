using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore4WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [ActionName("getuserbyid")]
        [HttpGet]
        public ActionResult GetUserById(int id)
        {
            return new JsonResult(_userService.GetUserById(id));
        }
    }
}
