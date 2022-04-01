using DemoAPiForDemo.Contracts;
using DemoAPiForDemo.Data;
using DemoAPiForDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Repositories
{
    public class TeamLeaderRepositories : GenericRepository<TeamLeader>, ITeamLeaderRepositories
    {
        public TeamLeaderRepositories(ApplicationContext context) : base(context)
        {

        }
    }
}
