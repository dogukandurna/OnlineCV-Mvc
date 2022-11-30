using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models;
using System.Diagnostics;
using MvcCVReal.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace MvcCVReal.Controllers
{
    public class HomeController : Controller
    {
        DbMyCvContext context = new DbMyCvContext();
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var vls = context.TblContacts.ToList();
            return View("Index",vls);
        }

        [HttpPost]
        public IActionResult Contact(TblContact tblContact)
        {
            tblContact.GönderimTarih = DateTime.Now;
            tblContact.IsRead = false;
            context.TblContacts.Add(tblContact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
