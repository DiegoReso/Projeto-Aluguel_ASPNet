using Aluguel.Data;
using Aluguel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aluguel.Controllers
{
    public class AluguelController : Controller
    {

        readonly private ApplicationDBContext _db;

        public AluguelController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<EmprestimoModels> emprestimos = _db.Emprestimos;
            return View(emprestimos);  
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(EmprestimoModels emprestimos)
        {
            if(ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }


    }
}
