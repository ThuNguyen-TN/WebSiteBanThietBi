using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteThietBiDienTu.Models
{
    [Table("GOPY")]
    public partial class Gopy
    {
        [Key]
        [Column("MaGY")]
        public int MaGy { get; set; }
        [Column("MaMH")]
        public int MaMh { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Column("NgayGY", TypeName = "date")]
        public DateTime NgayGy { get; set; }
        [StringLength(50)]
        public string HoTen { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [ForeignKey(nameof(MaMh))]
        [InverseProperty(nameof(Sanpham.Gopy))]
        public virtual Sanpham MaMhNavigation { get; set; }
    }
}
