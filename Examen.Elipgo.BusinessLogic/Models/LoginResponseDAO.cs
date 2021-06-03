using System;
using System.Collections.Generic;

namespace Examen.Elipgo.BusinessLogic.Models
{
    public class LoginResponseDAO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Expiration { get; set; }
        public List<string> RoleName { get; set; }
        public List<PermissionsDAO> Permissions { get; set; }
        public string Token { get; set; }
    }

    public class PermissionsDAO
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
