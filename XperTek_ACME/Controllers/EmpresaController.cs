using Microsoft.AspNetCore.Mvc;
using Models.ACME;
using Services.ACME;

namespace XperTek_ACME.Controllers
{
    public class EmpresaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Listar las empresas
            EmpresaService empresaService = new EmpresaService();
            List<EmpresaEntidad>? listaEmpresaEntidad;
            
            listaEmpresaEntidad = empresaService.Listar();
            return View(listaEmpresaEntidad);
        }
    }
}
