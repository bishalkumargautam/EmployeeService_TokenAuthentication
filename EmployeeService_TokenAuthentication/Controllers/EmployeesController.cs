using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDAL;

namespace EmployeeService_TokenAuthentication.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<EmployeesTokenExampleTable> Get()
        {
            using(EmployeeDBEntities entities= new EmployeeDBEntities())
            {
                return entities.EmployeesTokenExampleTables.ToList();

            }
        }
    }

}
  