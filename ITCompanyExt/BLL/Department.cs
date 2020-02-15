using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyExt.BLL
{
    class Department
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public Employee LeaderOfDepartment { get; set; }
        public Department(long id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
