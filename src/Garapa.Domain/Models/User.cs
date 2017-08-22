using System;
using System.Collections.Generic;
using System.Text;
using Garapa.Domain.Core.Models;

namespace Garapa.Domain.Models
{
    public class User : Entity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        protected User() { }
    }
}
