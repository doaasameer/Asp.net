using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationDB2019.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
      
        public IEnumerable<Employee> Get()
        {
            using (DatabaseEmployeeEntities entities = new DatabaseEmployeeEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (DatabaseEmployeeEntities entities = new DatabaseEmployeeEntities())
            {
                return entities.Employees.Find(id);
            }
        }
    }
}
