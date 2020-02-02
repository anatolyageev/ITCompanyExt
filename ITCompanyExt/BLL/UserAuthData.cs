using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyExt.BLL
{
    class UserAuthData
    {
        public long id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public UserAuthData(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
