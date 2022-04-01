using DemoAPiForDemo.Contracts;
using DemoAPiForDemo.Data;
using DemoAPiForDemo.Model;
using DemoAPiForDemo.ViewModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Repositories
{
    public class TeamMateRepositories : GenericRepository<User>, ITeamMateRepositories
    {
        private readonly ApplicationContext context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public TeamMateRepositories(ApplicationContext context, UserManager<User> userManager,
            SignInManager<User> signInManager) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<bool> SendRequestForTeamLeader(string uid, string teamname, string problemdefination, int orgId)
        {

            var TeamLeader = new TeamLeader()
            {
                userId = uid,
                OrganizationId = orgId,

            };
            await context.Tbl_Team_Leader_Master.AddAsync(TeamLeader);
            await context.SaveChangesAsync();
            int TeamLeaderid = context.Tbl_Team_Leader_Master.Where(x => x.userId == uid).Select(x=> x.Id).FirstOrDefault();
            if (TeamLeaderid !=0)
            {
                var teamMaster = new TeamMaster()
                {
                    
                    OrganizationId = orgId,
                    Team_Name=teamname,
                    TeamLeader_Id=TeamLeaderid

                };
                await context.Tbl_Team_Master.AddAsync(teamMaster);
                await context.SaveChangesAsync();
                var myteam = new MyTeam_Allocation()
                {
                    
                    userId=uid,
                    OrganizationId=orgId,
                    TeamId=TeamLeaderid,
                    Status=false
                };
                await context.Tbl_Team_Allocation_Master.AddAsync(myteam);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
            

        }

        public async Task<IdentityResult> SignUpAsync(User user)
        {
            var users = new User()
            {
                FirstName=user.FirstName,
                LastName=user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                OrganizationId=user.OrganizationId,
                StackId=user.StackId,
                IsAvailable=user.IsAvailable
            };

            var result = await userManager.CreateAsync(user, user.PasswordHash);

           
         
            return result;
        }
    }
}
