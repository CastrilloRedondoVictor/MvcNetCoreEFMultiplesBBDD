using System.Data;
using Microsoft.EntityFrameworkCore;
using MvcNetCoreEFMultiplesBBDD.Data;
using MvcNetCoreEFMultiplesBBDD.Models;
using Oracle.ManagedDataAccess.Client;

namespace MvcNetCoreEFMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosDepartamentosOracle : IRepositoryEmpleados
    {
        HospitalContext context;
        public RepositoryEmpleadosDepartamentosOracle(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<EmpleadoDepartamento>> GetEmpleadosDepartamentosAsync()
        {
            string sql = "begin SP_ALL_EMPLEADOS (:p_cursor_empleados); end;";
            OracleParameter pamCursor = new OracleParameter();
            pamCursor.ParameterName = "p_cursor_empleados";
            pamCursor.Value = null;
            pamCursor.Direction = ParameterDirection.Output;
            pamCursor.OracleDbType = OracleDbType.RefCursor;
            var consulta = this.context.EmpleadosDepartamentos.FromSqlRaw(sql, pamCursor);
            return await consulta.ToListAsync();
        }

        public async Task<EmpleadoDepartamento> FindEmpleadoDepartamentoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
