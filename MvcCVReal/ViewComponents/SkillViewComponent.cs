using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;

namespace MvcCVReal.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        DbMyCvContext context = new DbMyCvContext();
        public IViewComponentResult Invoke()
        {
            var sklvalues = context.TblSkills.ToList();
            return View(sklvalues);
        }
    }
}
