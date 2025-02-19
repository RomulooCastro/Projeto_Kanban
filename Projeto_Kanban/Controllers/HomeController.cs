using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Kanban.Models;

namespace Projeto_Kanban.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
