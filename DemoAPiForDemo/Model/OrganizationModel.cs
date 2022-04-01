using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Model
{
    public class OrganizationModel:BaseEntity
        {
        [Required]
        [StringLength(255)]
        public string Org_Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]

        public string Event_Name { get; set; }
       
        [Required]
        [DataType(DataType.Date)]
        
        public DateTime Event_Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Event_Key { get; set; }
        
        public string Org_Logo { get; set; }

        [Required]
        [StringLength(11)]
        public string Org_PhoneNo { get; set; }

        [Required]
        [StringLength(11)]
        public string Org_TeleNo { get; set; }


        [MinLength(10)]
        [MaxLength(14)]
        [Required]
        public int Team_Size { get; set; }
    }
}
