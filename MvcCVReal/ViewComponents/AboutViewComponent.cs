using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;

namespace MvcCVReal.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        DbMyCvContext context = new DbMyCvContext();
        public IViewComponentResult Invoke()
        {
            var cvabout = context.TblAbouts.ToList();
            return View(cvabout);
        }
    }
}
