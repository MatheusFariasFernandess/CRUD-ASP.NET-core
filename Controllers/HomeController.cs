using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
using System.Linq;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar(int? id)
        {
            var user = new Usuario();
            if (id.HasValue && user.ExibirListagem.Any(u => u.Id == id))
            {
                user = user.ExibirListagem.Single(u => u.Id == id);
              return View(user);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {

            Usuario.Salvar(usuario);

            return RedirectToAction("Usuarios");
        }
        public IActionResult Usuarios()
        {
            var user = new Usuario();
            return View(user.ExibirListagem);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            var user = new Usuario();
            if (id.HasValue && user.ExibirListagem.Any(u => u.Id == id))
            {
                user = user.ExibirListagem.Single(u => u.Id == id);
              return View(user);
            }
            return RedirectToAction("Usuarios");
        }
        [HttpPost]
        public IActionResult Excluir(Usuario user)
        {
             Usuario.Excluir(user.Id);
            return RedirectToAction("Usuarios");
        }
    }
}