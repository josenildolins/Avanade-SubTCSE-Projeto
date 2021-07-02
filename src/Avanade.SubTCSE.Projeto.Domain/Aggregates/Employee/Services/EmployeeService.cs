using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Services
{
    class EmployeeService : IEmployeeService
    {
        public async Task<Employee.Entities.Employee> AddEmployee(Employee.Entities.Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}