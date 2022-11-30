using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;

namespace MvcCVReal.ViewComponents
{
    public class SocialMediaViewComponent : ViewComponent
    {
        DbMyCvContext context = new DbMyCvContext();
        public IViewComponentResult Invoke()
        {
            var cvsocial = context.TblSocialMediaAccs.Where(x => x.SosyalMedyaDurum == true).ToList();
            return View(cvsocial);
        }
    }
}
