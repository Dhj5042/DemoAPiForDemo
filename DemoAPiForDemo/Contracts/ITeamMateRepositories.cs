using DemoAPiForDemo.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Contracts
{
    public interface ITeamMateRepositories : IGenericRepository<User>
    {
        Task<IdentityResult> SignUpAsync(User user);
        Task<bool> SendRequestForTeamLeader(string uid,string teamname,string problemdefination,int orgId);
    }
}
