using Microsoft.AspNetCore.Identity;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSec.Models
{
    public class User : IdentityUser<int>
    {
        public virtual ICollection<UserClaim> Claims { get; set; }
        public virtual ICollection<UserLogin> Logins { get; set; }
        public virtual ICollection<UserToken> Tokens { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }

    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }

    public class UserRole : IdentityUserRole<int>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }

    public class UserClaim : IdentityUserClaim<int>
    {
        public virtual User User { get; set; }
    }

    public class UserLogin : IdentityUserLogin<int>
    {
        public virtual User User { get; set; }
    }

    public class RoleClaim : IdentityRoleClaim<int>
    {
        public virtual Role Role { get; set; }
    }

    public class UserToken : IdentityUserToken<int>
    {
        public virtual User User { get; set; }
    }
}
