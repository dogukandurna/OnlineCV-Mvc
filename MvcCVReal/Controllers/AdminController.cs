using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MvcCVReal.Models.Entity;
using MvcCVReal.Repositories;
using System.Runtime.ConstrainedExecution;

namespace MvcCVReal.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        [Route("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimda()
        {
            GenericRepository<TblAbout> repository = new GenericRepository<TblAbout>();
            var tblAboutval = repository.AllList();
            return View(tblAboutval);
        }

        public IActionResult Deneyimlerim()
        {
            DeneyimRepository repository = new DeneyimRepository();
            var explist = repository.AllList();
            return View(explist);
        }
        public IActionResult Egitimlerim()
        {
            GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
            var edulist = repository.AllList();
            return View(edulist);
        }
        public IActionResult Yeteneklerim()
        {
            GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
            var sklllist = repository.AllList();
            return View(sklllist);
        }
        public IActionResult IlgiAlanlarim()
        {
            GenericRepository<TblHobby> repository = new GenericRepository<TblHobby>();
            var hbblist = repository.AllList();
            return View(hbblist);
        }
        public IActionResult Sertifikalarim()
        {
            GenericRepository<TblCertification> repository = new GenericRepository<TblCertification>();
            var crtlist = repository.AllList();
            return View(crtlist);
        }
        public IActionResult Iletisim()
        {
            GenericRepository<TblContact> repository = new GenericRepository<TblContact>();
            var contlist = repository.AllList();
            return View(contlist); ;
        }
        public IActionResult SosyalMedyaHesaplarim()
        {
            GenericRepository<TblSocialMediaAcc> repository = new GenericRepository<TblSocialMediaAcc>();
            var soclist = repository.AllList();
            return View(soclist); ;
        }

        public IActionResult YeniDeneyimEkle()
        {
            return View();
        }

        public IActionResult DeneyimGüncelle(int id)
        {
            GenericRepository<TblExperience> repository = new GenericRepository<TblExperience>();
            TblExperience tblExperience = repository.Find(x => x.Id == id);
            return View(tblExperience);
        }

        public IActionResult DeneyimSil(int id)
        {
            DeneyimRepository repository = new DeneyimRepository();
            TblExperience tblExperience = repository.Find(x => x.Id == id);
            repository.ListRemove(tblExperience);
            return RedirectToAction("Deneyimlerim");
        }

        public IActionResult YeniEgitimEkle()
        {
            return View();
        }

        public IActionResult EgitimGüncelle(int id)
        {
            GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
            TblEducation tblEducation = repository.Find(x => x.Id == id);
            return View(tblEducation);
        }

        public IActionResult EgitimSil(int id)
        {
            GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
            TblEducation tblEducation = repository.Find(x => x.Id == id);
            repository.ListRemove(tblEducation);
            return RedirectToAction("Egitimlerim");
        }

        public IActionResult YeniYetenekEkle()
        {
            return View();
        }

        public IActionResult YetenekGüncelle(int id)
        {
            GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
            TblSkill tblSkill = repository.Find(x => x.Id == id);
            return View(tblSkill);
        }

        public IActionResult YetenekSil(int id)
        {
            GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
            TblSkill tblSkill = repository.Find(x => x.Id == id);
            repository.ListRemove(tblSkill);
            return RedirectToAction("Yeteneklerim");
        }

        public IActionResult YeniIlgiAlaniEkle()
        {
            return View();
        }

        public IActionResult IlgiAlaniGüncelle(int id)
        {
            GenericRepository<TblHobby> repository = new GenericRepository<TblHobby>();
            TblHobby tblhbb = repository.Find(x => x.Id == id);
            return View(tblhbb);
        }

        public IActionResult IlgiAlaniSil(int id)
        {
            GenericRepository<TblHobby> repository = new GenericRepository<TblHobby>();
            TblHobby tblhbb = repository.Find(x => x.Id == id);
            repository.ListRemove(tblhbb);
            return RedirectToAction("IlgiAlanlarim");
        }

        public IActionResult YeniSertifikaEkle()
        {
            return View();
        }

        public IActionResult SertifikaGüncelle(int id)
        {
            GenericRepository<TblCertification> repository = new GenericRepository<TblCertification>();
            TblCertification cert = repository.Find(x => x.Id == id);
            return View(cert);
        }

        public IActionResult SertifikaSil(int id)
        {
            GenericRepository<TblCertification> repository = new GenericRepository<TblCertification>();
            TblCertification cert = repository.Find(x => x.Id == id);
            repository.ListRemove(cert);
            return RedirectToAction("Sertifikalarim");
        }

        public IActionResult SosyalMedyaEkle()
        {
            return View("SosyalMedyaHesaplarim");
        }

        public IActionResult SosyalMedyaGüncelle(int id)
        {
            GenericRepository<TblSocialMediaAcc> repository = new GenericRepository<TblSocialMediaAcc>();
            TblSocialMediaAcc soc=repository.Find(x => x.Id == id);
            return View(soc);
        }

        [HttpPost]
        public IActionResult Hakkimda(TblAbout about)
        {
            if (!ModelState.IsValid)
            {
                return View("Hakkimda", about);
            }
            GenericRepository<TblAbout> repository = new GenericRepository<TblAbout>();
            var tblAboutval = repository.Find(x => x.Id == 1);
            tblAboutval.Ad = about.Ad;
            tblAboutval.Soyad = about.Soyad;
            tblAboutval.Adres = about.Adres;
            tblAboutval.Telefon = about.Telefon;
            tblAboutval.Açıklama = about.Açıklama;
            repository.ListUpdate(tblAboutval);
            return RedirectToAction("Hakkimda");
        }

        [HttpPost]
        public IActionResult YeniDeneyimEkle(TblExperience experience)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniDeneyimEkle", experience);
            }
            DeneyimRepository repository = new DeneyimRepository();
            repository.ListAdd(experience);
            return RedirectToAction("Deneyimlerim");
        }

        [HttpPost]
        public IActionResult DeneyimGüncelle(TblExperience experience)
        {
            if (!ModelState.IsValid)
            {
                return View("DeneyimGüncelle", experience);
            }
            DeneyimRepository repository = new DeneyimRepository();
            TblExperience tblExperience = repository.Find(x => x.Id == experience.Id);
            tblExperience.İşYeriAdı = experience.İşYeriAdı;
            tblExperience.Ünvan = experience.Ünvan;
            tblExperience.Aciklama = experience.Aciklama;
            tblExperience.Tarih = experience.Tarih;
            repository.ListUpdate(tblExperience);
            return RedirectToAction("Deneyimlerim");
        }

        [HttpPost]
        public IActionResult YeniEgitimEkle(TblEducation education)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniEgitimEkle", education);
            }
            GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
            repository.ListAdd(education);
            return RedirectToAction("Egitimlerim");
        }


        [HttpPost]
        public IActionResult EgitimGüncelle(TblEducation education)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimGüncelle", education);
            }
            GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
            TblEducation tblEducation = repository.Find(x => x.Id == education.Id);
            tblEducation.OkulAdı = education.OkulAdı;
            tblEducation.OkulTür = education.OkulTür;
            tblEducation.Ünvan = education.Ünvan;
            tblEducation.Ortalama = education.Ortalama;
            tblEducation.Tarih = education.Tarih;
            repository.ListUpdate(tblEducation);
            return RedirectToAction("Egitimlerim");
        }

        [HttpPost]
        public IActionResult YeniYetenekEkle(TblSkill skill)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniYetenekEkle", skill);
            }
            GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
            repository.ListAdd(skill);
            return RedirectToAction("Yeteneklerim");
        }

        [HttpPost]
        public IActionResult YetenekGüncelle(TblSkill skill)
        {
            if (!ModelState.IsValid)
            {
                return View("YetenekGüncelle", skill);
            }
            GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
            TblSkill tblSkill = repository.Find(x => x.Id == skill.Id);
            tblSkill.Yetenekler = skill.Yetenekler;
            repository.ListUpdate(tblSkill);
            return RedirectToAction("Yeteneklerim");
        }

        [HttpPost]
        public IActionResult YeniIlgiAlaniEkle(TblHobby hbb)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniIlgiAlaniEkle", hbb);
            }
            GenericRepository<TblHobby> repository = new GenericRepository<TblHobby>();
            repository.ListAdd(hbb);
            return RedirectToAction("IlgiAlanlarim");
        }

        [HttpPost]
        public IActionResult IlgiAlaniGüncelle(TblHobby hbb)
        {
            if (!ModelState.IsValid)
            {
                return View("IlgiAlaniGüncelle", hbb);
            }
            GenericRepository<TblHobby> repository = new GenericRepository<TblHobby>();
            TblHobby tblhbb = repository.Find(x => x.Id == hbb.Id);
            tblhbb.Aciklama1 = hbb.Aciklama1;
            tblhbb.Aciklama2 = hbb.Aciklama2;
            repository.ListUpdate(tblhbb);
            return RedirectToAction("IlgiAlanlarim");
        }

        [HttpPost]
        public IActionResult YeniSertifikaEkle(TblCertification certi)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniSertifikaEkle", certi);
            }
            GenericRepository<TblCertification> repository = new GenericRepository<TblCertification>();
            repository.ListAdd(certi);
            return RedirectToAction("Sertifikalarim");
        }
        [HttpPost]
        public IActionResult SertifikaGüncelle(TblCertification certi)
        {
            if (!ModelState.IsValid)
            {
                return View("SertifikaGüncelle", certi);
            }
            GenericRepository<TblCertification> repository = new GenericRepository<TblCertification>();
            TblCertification cert = repository.Find(x => x.Id == certi.Id);
            cert.SertifikaAd = certi.SertifikaAd;
            repository.ListUpdate(cert);
            return RedirectToAction("Sertifikalarim");
        }

        [HttpPost]
        public IActionResult SosyalMedyaEkle(TblSocialMediaAcc acc)
        {
            GenericRepository<TblSocialMediaAcc> repository = new GenericRepository<TblSocialMediaAcc>();
            repository.ListAdd(acc);
            return RedirectToAction("SosyalMedyaHesaplarim");
        }

        [HttpPost]
        public IActionResult SosyalMedyaGüncelle(TblSocialMediaAcc soci)
        {
            if (!ModelState.IsValid)
            {
                return View("SosyalMedyaGüncelle", soci);
            }
            GenericRepository<TblSocialMediaAcc> repository = new GenericRepository<TblSocialMediaAcc>();
            TblSocialMediaAcc soc= repository.Find(x=> x.Id == soci.Id);
            soc.SosyalMedyaIsim = soci.SosyalMedyaIsim;
            soc.SosyalMedyaUrl = soci.SosyalMedyaUrl;
            soc.SosyalMedyaIkon = soci.SosyalMedyaIkon;
            soc.SosyalMedyaDurum = soci.SosyalMedyaDurum;
            repository.ListUpdate(soc);
            return RedirectToAction("SosyalMedyaHesaplarim");
        }
    }
}
