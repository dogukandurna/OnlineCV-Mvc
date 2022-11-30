using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblAbout
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Ad Boş Geçilemez")]
    [StringLength(25, ErrorMessage = "Lütfen Adınızı 25 karakteri geçmeyecek şekilde giriniz!")]
    public string? Ad { get; set; }
    [Required(ErrorMessage = "Soyad Boş Geçilemez")]
    [StringLength(30, ErrorMessage = "Lütfen Soyadınızı 30 karakteri geçmeyecek şekilde giriniz!")]
    public string? Soyad { get; set; }
    [Required(ErrorMessage = "Adres Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Adresinizi 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? Adres { get; set; }
    [Required(ErrorMessage = "Telefon No Boş Geçilemez")]
    [StringLength(20, ErrorMessage = "Lütfen Telefon numaranızı 20 karakteri geçmeyecek şekilde giriniz!")]
    public string? Telefon { get; set; }
    [Required(ErrorMessage = "Mail Boş Geçilemez")]
    [StringLength(50, ErrorMessage = "Lütfen Mail adresinizi 50 karakteri geçmeyecek şekilde giriniz!")]
    [EmailAddress(ErrorMessage = "Düzgün bir mail adresi giriniz!")]
    public string? Mail { get; set; }
    [Required(ErrorMessage = "Açıklama(Hakkında) Boş Geçilemez")]
    public string? Açıklama { get; set; }

    public string? Resim { get; set; }
}
