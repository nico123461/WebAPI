using Infrastructure.Models;
using Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IEmployeeRepository: IGet<Employee>
    {

    }
}
