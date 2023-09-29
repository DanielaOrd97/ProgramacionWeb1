using Act1_U1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Act1_U1.Controllers
{
    public class HomeController : Controller
    {

        PerfilViewModel perfil = new PerfilViewModel();
        public IActionResult Index()
        {
            perfil.Materia = "Programación web";
            perfil.Semestre = 7;
            perfil.Periodo = "Ago - Dic 2023";
            perfil.Nombre = "Daniela Gpe.Ordónez Barron";
            return View(perfil);
        }

        public IActionResult Perfil()
        {
            perfil.Nombre = "Daniela Gpe.Ordónez Barron";
            perfil.NumControl = "201G0272";
            perfil.Telefono = "81 1185 5777";
            perfil.Ciudad = "Nueva Rosita";
            perfil.Carrera = "Sistemas Computacionales";
            perfil.Correo = "201G0272@rcarbonifera.tecnm.mx";
            return View(perfil);
        }
    }
}
