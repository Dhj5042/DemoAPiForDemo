using DemoAPiForDemo.Contracts;
using DemoAPiForDemo.Data;
using DemoAPiForDemo.Model;
using DemoAPiForDemo.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Repositories
{
    public class OrganizationRepository : GenericRepository<OrganizationModel>, IOrganizationRepository
    {
        private readonly ApplicationContext context;
        
        public OrganizationRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<OrganizationModel> LoginOrg(SignUpOrganizationVM model)
        {
            model.Password = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(model.Password));
            var res = await context.Tbl_Organization_Master.Where(a => a.Email == model.Email && a.Password == model.Password).FirstOrDefaultAsync();
              return res;
          
         
        }

        public Task<OrganizationModel> RegisterOrg(OrganizationModel model)
        {
           
           model.Password= WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(model.Password));
            var result = AddAsync(model);
            return result;

        }
    }
}
