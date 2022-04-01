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
    public class TeamLeaderController : ControllerBase
    {
        private readonly ITeamLeaderRepositories teamLeaderRepositories;

        public TeamLeaderController(ITeamLeaderRepositories teamLeaderRepositories)
        {
            this.teamLeaderRepositories = teamLeaderRepositories;
        }


       [HttpPost("RequestSend")]
        public async Task<ActionResult<TeamLeader>> RegisterOrg(int TeamMate)
        {
            //if (ModelState.IsValid)
            //{
            //    var res = await organizationRepository.Exist(organizationModel.Id);


            //    if (res == true)
            //    {
            //        return Conflict("User Already exist");
            //    }
            //    else
            //    {
            //        await organizationRepository.RegisterOrg(organizationModel);
            //    }
            //}

            return Ok("Registration Successfully");
        }
    }
}
