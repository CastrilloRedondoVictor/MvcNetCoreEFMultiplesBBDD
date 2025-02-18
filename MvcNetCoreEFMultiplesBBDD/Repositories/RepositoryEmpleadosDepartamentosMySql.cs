using Microsoft.EntityFrameworkCore;
using MvcNetCoreEFMultiplesBBDD.Data;
using MvcNetCoreEFMultiplesBBDD.Models;

namespace MvcNetCoreEFMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosDepartamentosMySql : IRepositoryEmpleados
    {
        public HospitalContext context;

        public RepositoryEmpleadosDepartamentosMySql(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<EmpleadoDepartamento>> GetEmpleadosDepartamentosAsync()
        {
            return await this.context.EmpleadosDepartamentos.FromSqlRaw("CALL SP_ALL_EMPLEADOS()").ToListAsync();
        }



        public async Task<EmpleadoDepartamento> FindEmpleadoDepartamentoAsync(int id)
        {
            return await this.context.EmpleadosDepartamentos.FindAsync(id);
        }
    }
}
