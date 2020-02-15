using System;
using System.Collections.Generic;
using System.Linq;
using ITCompanyExt.BLL;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITCompanyExt.Controllers
{
    class DepartmentController
    {


        private static List<Department> GetAllDepartments(long Id)
        {
            List<Department> deps = new List<Department>();
            XDocument xDeps = XDocument.Load("Departments.xml");

            //var dep = from xe in xDeps.Element("Departmens").Elements("Department")
            //          select new Department
            //          {
            //              Id = Convert.ToInt64(xe.Element("ID").Value),
            //              Name = xe.Element("Name").Value,
            //          };

            //foreach (Department item in dep)
            //{
            //    deps.Add(item);
            //}
            return deps;
        }
    }
}
