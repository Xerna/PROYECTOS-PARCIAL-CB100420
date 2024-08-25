using Microsoft.AspNetCore.Mvc;
using MiParcialitoC.Models;

namespace MiParcialitoC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Welcome(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                return View(userModel);
            }

            // Si el modelo no es válido, vuelve a mostrar el formulario.
            return View("Index");
        }
    }
}
