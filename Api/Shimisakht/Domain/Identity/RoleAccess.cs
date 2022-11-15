using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity
{
    public class RoleAccess
    {
        public const string Admin =
            $"{UserRolesData.Admin}";

        public const string Admin_Author =
            $"{UserRolesData.Admin},{UserRolesData.Author}";

        public const string BasicUser = 
            $"{UserRolesData.BasicUser}";

        public const string AllUser =
            $"{UserRolesData.Admin},{UserRolesData.Author},{UserRolesData.BasicUser}";
    }
}
