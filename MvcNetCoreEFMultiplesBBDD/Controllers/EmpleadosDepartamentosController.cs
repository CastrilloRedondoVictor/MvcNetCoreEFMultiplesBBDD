using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEFMultiplesBBDD.Models;
using MvcNetCoreEFMultiplesBBDD.Repositories;

namespace MvcNetCoreEFMultiplesBBDD.Controllers
{
    public class EmpleadosDepartamentosController : Controller
    {
        IRepositoryEmpleados repo;

        public EmpleadosDepartamentosController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        
        public async Task<IActionResult> Index()
        {
            List<EmpleadoDepartamento> empleados = await this.repo.GetEmpleadosDepartamentosAsync();
            return View(empleados);
        }

        public async Task<IActionResult> Details(int id)
        {
            EmpleadoDepartamento empleado = await this.repo.FindEmpleadoDepartamentoAsync(id);
            return View(empleado);
        }
    }
}
