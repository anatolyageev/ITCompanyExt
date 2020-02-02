using ITCompanyExt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyExt.Controllers
{
    class UserAuthController
    {
        public static Employee Register(string username, string pass)
        {
            //Authorization data = new Authorization(username, pass);
            //what happens next?

            return null;
        }
        public static Employee Authenticate(UserAuthData userAuthData)
        {

            return null;
        }
        public static void ChangePassword(int userid, string oldpass, string newpass)
        {
            //what happens next?
        }
        public static void RecoverPassword(int userid, string username)
        {
            //what happens next? 
        }
    }
}
