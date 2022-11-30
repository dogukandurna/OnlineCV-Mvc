using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblContact
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Ad Soyad Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Adınızı 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? GönderenAdSoyad { get; set; }
    [Required(ErrorMessage = "Mail Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Mailinizi 100 karakteri geçmeyecek şekilde giriniz!")]
    [EmailAddress(ErrorMessage = "Düzgün bir mail adresi giriniz!")]
    public string? GönderenMail { get; set; }
    [Required(ErrorMessage = "Mesaj Konusu Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Mesajınızın Konusunu 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? GönderenMesajKonu { get; set; }
    [Required(ErrorMessage = "Mesaj Boş Geçilemez")]
    [StringLength(1000, ErrorMessage = "Lütfen Mesajınızı 1000 karakteri geçmeyecek şekilde giriniz!")]
    public string? GönderenMesaj { get; set; }
    [Required(ErrorMessage = "Göderim Tarihi Boş Geçilemez")]
    public DateTime? GönderimTarih { get; set; }
    [Required(ErrorMessage = "Okunma Bilgisi Boş Geçilemez")]
    public bool? IsRead { get; set; }
}
