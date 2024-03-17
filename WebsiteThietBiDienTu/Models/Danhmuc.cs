using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteThietBiDienTu.Models
{
    [Table("DANHMUC")]
    public partial class Danhmuc
    {
        public Danhmuc()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        [Column("MaDM")]
        public int MaDm { get; set; }
        [Required]
        [StringLength(100)]
        public string Ten { get; set; }

        [InverseProperty("MaDmNavigation")]
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
