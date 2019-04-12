using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ant_ratu.Models
{
    public class User
    {

        public User()
        {

        }

        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string SlackId { get; set; }

        public string PhoneNumber  { get; set; }

        public string CarPlates { get; set; }

        public string MainOffice { get; set; }

        public string Role { get; set; }

    }

}
