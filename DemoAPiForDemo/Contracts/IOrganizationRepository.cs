using DemoAPiForDemo.Model;
using DemoAPiForDemo.ViewModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Contracts
{
    public interface IOrganizationRepository : IGenericRepository<OrganizationModel>
    {
        Task<OrganizationModel> RegisterOrg(OrganizationModel model);

        Task<OrganizationModel> LoginOrg(SignUpOrganizationVM model);
    }
}
