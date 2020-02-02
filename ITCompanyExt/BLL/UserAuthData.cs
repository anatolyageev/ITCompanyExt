using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyExt.BLL
{
    class UserAuthData
    {
        private long id;
        private string userName;
        private string password;

        public UserAuthData(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
