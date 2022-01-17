using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Validation
    {
        public static string NameRegex = @"^[A-Z][a-z]+[\s]?[A-Z][a-z]+([\s]?[A-Z][a-z]+)?$";
        public static string UsernameRegex = @"^[a-zA-Z][\w]+$";
        public static string PhoneNumberRegex = @"^[0][6][\d]{7,8}$";
        public static string EmailRegex = @"^[a-zA-Z0-9]+[.+_]{0,1}?[a-zA-Z0-9]+[@][a-zA-Z]+[\.][a-zA-Z]{2,3}[\.]?([a-zA-Z]{2,3})?$";
        public static string PasswordRegex = "^[a-zA-Z0-9]{6,16}";
        public static string AddressRegex = @"^[A-Z][A-Za-z0-9 ]+$";
        public static string RoleRegex = "^[A-Z][a-z]+$";
        public static string ManagerIdRegex = "^[1][0-9]{1,2}$";
    }
}
