using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblSocialMediaAcc
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Sosyal Medya İsmi Boş Geçilemez")]
    [StringLength(30, ErrorMessage = "Lütfen Sosyal Medya İsmini 30 karakteri geçmeyecek şekilde giriniz!")]
    public string? SosyalMedyaIsim { get; set; }
    [Required(ErrorMessage = "Sosyal Medya Urli Boş Geçilemez")]
    [StringLength(120, ErrorMessage = "Lütfen Sosyal Medya Urlini 120 karakteri geçmeyecek şekilde giriniz!")]
    public string? SosyalMedyaUrl { get; set; }
    [Required(ErrorMessage = "Sosyal Medya Ikon Adı Boş Geçilemez")]
    [StringLength(30, ErrorMessage = "Lütfen Sosyal Medya Ikonunun adını 30 karakteri geçmeyecek şekilde giriniz!")]
    public string? SosyalMedyaIkon { get; set; }
    [Required(ErrorMessage = "Gösterim Boş Geçilemez")]
    public bool? SosyalMedyaDurum { get; set; }
}
