using Microsoft.AspNetCore.Mvc;
using MvcCVReal.Models.Entity;

namespace MvcCVReal.ViewComponents
{
    public class CertificationViewComponent : ViewComponent
    {
        DbMyCvContext context = new DbMyCvContext();
        public IViewComponentResult Invoke()
        {
            var crtvalues = context.TblCertifications.ToList();
            return View(crtvalues);
        }
    }
}
