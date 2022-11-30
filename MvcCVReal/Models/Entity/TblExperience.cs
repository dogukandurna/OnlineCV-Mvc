using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblExperience
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "İş Yeri Adı Boş Geçilemez")]
    [StringLength(50, ErrorMessage = "Lütfen İş Yeri Adını 50 karakteri geçmeyecek şekilde giriniz!")]
    public string? İşYeriAdı { get; set; }
    [Required(ErrorMessage = "Ünvan Boş Geçilemez")]
    [StringLength(50, ErrorMessage = "Lütfen Ünvanı 50 karakteri geçmeyecek şekilde giriniz!")]
    public string? Ünvan { get; set; }
    [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
    public string? Aciklama { get; set; }
    [Required(ErrorMessage = "Tarih Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Tarihi 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? Tarih { get; set; }
}
