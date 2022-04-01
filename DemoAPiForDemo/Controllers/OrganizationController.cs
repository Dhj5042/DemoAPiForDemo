using DemoAPiForDemo.Contracts;
using DemoAPiForDemo.Model;
using DemoAPiForDemo.ViewModel;
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
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationController(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }

        [HttpPost("signup")]
        public async Task<ActionResult<OrganizationModel>> RegisterOrg(OrganizationModel organizationModel)
        {
            if (ModelState.IsValid)
            {
                var res = await organizationRepository.Exist(organizationModel.Id);


                if (res == true)
                {
                    return Conflict("User Already exist");
                }
                else
                {
                    await organizationRepository.RegisterOrg(organizationModel);
                }
            }

            return Ok("Registration Successfully");
        }
        [HttpPost("login")]
        public async Task<ActionResult<OrganizationModel>> LoginOrganization(SignUpOrganizationVM organizationModel)
        {
            if (ModelState.IsValid)
            {
                var res =await organizationRepository.LoginOrg(organizationModel);
                if (res!=null)
                {
                    return Ok(res);
                }
               
            }
            return NotFound("User Not Found");
        }
    }
}
