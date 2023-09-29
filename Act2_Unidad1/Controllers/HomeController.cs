using Act2_Unidad1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Act2_Unidad1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ConversionViewModel cvm, string Tipo)
        {
            if (Tipo == "USD")
            {
                cvm.Conversion = (cvm.Cantidad * 18).ToString("$ 00.00 MXN");
                
            }
            else if (Tipo == "MXN")
            {
                //cvm.Conversion = cvm.Cantidad / 18;
                cvm.Conversion = (cvm.Cantidad / 18).ToString("$ 00.00 USD");
            }
            return View(cvm);
        }
    }
}
