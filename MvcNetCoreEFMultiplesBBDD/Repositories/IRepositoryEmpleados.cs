using MvcNetCoreEFMultiplesBBDD.Models;

namespace MvcNetCoreEFMultiplesBBDD.Repositories
{
    public interface IRepositoryEmpleados
    {
        Task<List<EmpleadoDepartamento>> GetEmpleadosDepartamentosAsync();
        Task<EmpleadoDepartamento> FindEmpleadoDepartamentoAsync(int id);
    }
}
