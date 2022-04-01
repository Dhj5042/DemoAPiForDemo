using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Model
{
    public class User : IdentityUser
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("OrganizationId")]
        public OrganizationModel OrganizationModel { get; set; }
        public int OrganizationId { get; set; }
        [ForeignKey("StackId")]
        public Stack Stack { get; set; }
        public int StackId { get; set; }

        [ForeignKey("Defination_Id")]
        public Defination Defination { get; set; }
        public int Defination_Id { get; set; }

    }
}
