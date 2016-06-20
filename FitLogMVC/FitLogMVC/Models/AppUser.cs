using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitLogMVC.Models
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int InitialWeight { get; set; }
        public int Age { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}