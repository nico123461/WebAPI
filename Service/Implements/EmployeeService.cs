using Infrastructure.Models;
using Infrastructure.Repository;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implements
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.FindAll(x=>true).Cast<Employee>().ToList();
        }
    }
}
