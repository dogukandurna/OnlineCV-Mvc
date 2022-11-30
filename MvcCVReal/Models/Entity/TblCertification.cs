using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblCertification
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Sertifika Adı Boş Geçilemez")]
    [StringLength(250, ErrorMessage = "Lütfen Sertifika adını 250 karakteri geçmeyecek şekilde giriniz!")]
    public string? SertifikaAd { get; set; }
}
