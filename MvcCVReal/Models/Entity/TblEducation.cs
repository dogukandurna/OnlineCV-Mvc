using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblEducation
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Okul Adı Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Okul Adını 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? OkulAdı { get; set; }
    [Required(ErrorMessage = "Okul Türü Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Okul Türünü 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? OkulTür { get; set; }
    [Required(ErrorMessage = "Ünvan Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Ünvanınızı 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? Ünvan { get; set; }
    [Required(ErrorMessage = "Ortalama Boş Geçilemez")]
    [StringLength(50, ErrorMessage = "Lütfen Ortalamanızı 50 karakteri geçmeyecek şekilde giriniz!")]
    public string? Ortalama { get; set; }
    [Required(ErrorMessage = "Tarih Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Tarihi 100 karakteri geçmeyecek şekilde yazı olarak giriniz!")]
    public string? Tarih { get; set; }
}
