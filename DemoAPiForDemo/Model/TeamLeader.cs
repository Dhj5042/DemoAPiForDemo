﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.Model
{
    public class TeamLeader : BaseEntity
    {
        public string TeamLeader_Name { get; set; }

        public string userId { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationModel OrganizationModel { get; set; }
        public int OrganizationId { get; set; }

    }
}