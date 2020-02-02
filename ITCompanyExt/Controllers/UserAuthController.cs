using ITCompanyExt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            XDocument xdoc = XDocument.Load("userAuth.xml");
            XElement root = xdoc.Element("UserAuthDataObjects");

            foreach (XElement xe in root.Elements("UserAuthData").ToList())
            {
                if (xe.Element("userName").Value.Equals(userAuthData.userName) && xe.Element("password").Value.Equals(userAuthData.password))
                {
                    return FindEmploeeByIdInXML( Convert.ToInt64(xe.Element("Id").Value));
                }
            }

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

        private static Employee FindEmploeeByIdInXML(long Id)
        {
          //  Employee result = new Employee();
            XDocument xdoc = XDocument.Load("emploee.xml");
            XElement root = xdoc.Element("Employees");

            foreach (XElement xe in root.Elements("Employee").ToList())
            {
                if (Convert.ToInt64(xe.Element("Id").Value) == Id)
                {
                    return new Employee(Convert.ToInt64(xe.Element("Id").Value),
                                        xe.Element("Name").Value,
                                        xe.Element("Position").Value,
                                        Convert.ToDouble(xe.Element("Salary").Value),
                                        xe.Element("Department").Value
                                        );
                }
            }
            return null;
        }
    }
}
