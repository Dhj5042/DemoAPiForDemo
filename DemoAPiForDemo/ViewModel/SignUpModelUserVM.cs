using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPiForDemo.ViewModel
{
    public class SignUpModelUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int OrganizationId { get; set; }
        public int StackId { get; set; }
        public int? Defination_Id { get; set; }
        public bool IsAvailable { get; set; }
    }
}
