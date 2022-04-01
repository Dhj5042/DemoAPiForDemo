using DemoAPiForDemo.Contracts;
using DemoAPiForDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMateRepositories teamMateRepositories;

        public TeamMemberController(ITeamMateRepositories  teamMateRepositories)
        {
            this.teamMateRepositories = teamMateRepositories;
        }


        [HttpPost("signup")]
        public async Task<ActionResult<User>> RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
              //  var res = await teamMateRepositories.Exist(user.Id.ToString());


                //if (res == true)
                //{
                //    return Conflict("User Already exist");
                //}
                //else
                //{
                   
                //}

                await teamMateRepositories.SignUpAsync(user);
            }

            return Ok("Registration Successfully");
        }
        [HttpPost("sendrequestadmin")]
        public async Task<IActionResult> sendrequestadmin([FromQuery] string uid, [FromQuery] string teamname, [FromQuery] string problemdefination, [FromQuery] int orgId)
        {
            if (ModelState.IsValid)
            {
               

                await teamMateRepositories.SendRequestForTeamLeader(uid,teamname,problemdefination,orgId);
                return Ok("your request send to admin...");
            }

            return Conflict("you are not able to be a team leader...");
        }
    }
}
