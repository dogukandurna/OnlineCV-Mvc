using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblAdmin
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez")]
    [StringLength(20, ErrorMessage = "Lütfen Kullanıcı Adını 20 karakteri geçmeyecek şekilde giriniz!")]
    public string? KullaniciAd { get; set; }
    [Required(ErrorMessage = "Kullanıcı Şifresi Boş Geçilemez")]
    [StringLength(20, ErrorMessage = "Lütfen Şifrenizi 20 karakteri geçmeyecek şekilde giriniz!")]
    public string? KullaniciSifre { get; set; }
    public string? Role { get; set; }
}
