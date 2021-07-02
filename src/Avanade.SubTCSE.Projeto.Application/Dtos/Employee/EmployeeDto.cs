using Avanade.SubTCSE.Projeto.Application.Dtos.Base;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string PrimeiroNome { get; set; }

        public string Sobrenome { get; set; }

        public System.DateTime Aniversario { get; set; }

        public bool Ativo { get; set; }

        public decimal Salario { get; set; }

        public EmployeeRole.EmployeeRoleDto Cargo { get; set; }
    }
}
