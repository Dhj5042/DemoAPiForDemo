using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Model
{
    public class Stack:BaseEntity
    {
        public string Stack_Name { get; set; }

        [ForeignKey("OrganizationId")]
        public OrganizationModel OrganizationModel { get; set; }
        public int OrganizationId { get; set; }



    }
}
