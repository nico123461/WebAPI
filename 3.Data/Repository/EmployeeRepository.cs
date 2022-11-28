using Data.DataBase;
using Infrastructure.Models;
using Infrastructure.Repository;
using Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private MainContext mainContext;
        public EmployeeRepository(MainContext mainContext)
        {
            this.mainContext = mainContext;
        }

        public Employee Find(Func<Employee, bool> func)
        {
            return mainContext.Employee.FirstOrDefault(func);
        }

        public IList<Employee> FindAll(Func<Employee, bool> func)
        {
            return mainContext.Employee.Where(func).ToList();
        }
    }
}
