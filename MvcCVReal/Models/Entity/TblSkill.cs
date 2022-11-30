using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcCVReal.Models.Entity;

public partial class TblSkill
{
    [Required(ErrorMessage = "Id Boş Geçilemez")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Yetenek Adı Boş Geçilemez")]
    [StringLength(100, ErrorMessage = "Lütfen Yeteneğinizin adını 100 karakteri geçmeyecek şekilde giriniz!")]
    public string? Yetenekler { get; set; }
}
