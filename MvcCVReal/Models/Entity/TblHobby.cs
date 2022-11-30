using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblHobby
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Hobi Başlığı Boş Geçilemez")]
    [StringLength(500, ErrorMessage = "Lütfen Hobinizin başlığını 500 karakteri geçmeyecek şekilde giriniz!")]
    public string? Aciklama1 { get; set; }
    [Required(ErrorMessage = "Hobi Açıklaması Boş Geçilemez")]
    [StringLength(500, ErrorMessage = "Lütfen Hobinizin açıklamasını 500 karakteri geçmeyecek şekilde giriniz!")]
    public string? Aciklama2 { get; set; }
}
