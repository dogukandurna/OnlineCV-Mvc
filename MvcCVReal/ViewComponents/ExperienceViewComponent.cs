using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;

namespace MvcCVReal.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        DbMyCvContext context = new DbMyCvContext();
        public IViewComponentResult Invoke()
        {
            var expvalues = context.TblExperiences.ToList();
            return View(expvalues);
        }
    }
}
