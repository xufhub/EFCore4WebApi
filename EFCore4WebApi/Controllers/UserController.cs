using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService;

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
        [ActionName("getuserbyname")]
        [HttpGet]
        public async Task<ActionResult> GetUserByName(string name)
        {
            return new JsonResult(await _userService.GetUserByName(name));
        }
        [ActionName("testbulkadd")]
        [HttpGet]
        public async Task<ActionResult> TestBulkAdd(string name)
        {
            await _userService.BatchInsertUser();
            return Ok();
        }
        [ActionName("testbulkupdate")]
        [HttpGet]
        public async Task<ActionResult> TestBulkUpdate(string name)
        {
            await _userService.BatchUpdateUser();
            return Ok();
        }
    }
}
