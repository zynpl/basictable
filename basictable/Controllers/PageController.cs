using basictable.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basictable.Controllers
{
    public class PageController : Controller
    {
        private readonly Context _con;

        public PageController(Context con)
        {
            _con = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            var values = _con.exams.ToList();
            return View(values);
        }

        public IActionResult tDelete(int id)
        {
            var table = _con.exams.Find(id);
            _con.exams.Remove(table);
            _con.SaveChanges();
            return RedirectToAction("Table");

        }

        public IActionResult tableShow(int id)
        {
            var t = _con.exams.Find(id);
            return View("tableShow",t);
        }
        public IActionResult tUpdate(Exam e)
        {
            var table = _con.exams.Find(e.id);
    
            table.name = e.name;
            table.surname = e.surname;

            _con.SaveChanges();
            return RedirectToAction("Table");
        }

    }
}
