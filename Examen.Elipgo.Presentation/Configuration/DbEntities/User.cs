using System;
using System.Collections.Generic;

namespace Examen.Elipgo.Presentation.Configuration.DbEntities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationToken { get; set; }
        public DateTime LastAccess { get; set; }
        public bool IsActiveSession { get; set; }
        public ICollection<Permissions> Permissions{ get; set; }
    }
}
