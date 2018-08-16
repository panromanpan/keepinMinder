using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepinMinder.Models
{
    public class Note
    {
        public int Id { get; set; }

        public IdentityUser User { get; set; }

        public string Content { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
