using DemoAPiForDemo.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<OrganizationModel> Tbl_Organization_Master { get; set; }
        public DbSet<Stack> Tbl_Stack_Master { get; set; }
        public DbSet<Defination> Tbl_Defination_Master { get; set; }
        public DbSet<TeamLeader> Tbl_Team_Leader_Master { get; set; }
        public DbSet<TeamMaster> Tbl_Team_Master { get; set; }
        public DbSet<MyTeam_Allocation> Tbl_Team_Allocation_Master { get; set; }
    }
}
