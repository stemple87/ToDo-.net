using Microsoft.AspNet.Mvc;
using System.Linq;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoContext db = new ToDoContext();
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
    }
}