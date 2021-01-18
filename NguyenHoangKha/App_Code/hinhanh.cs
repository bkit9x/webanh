namespace NguyenHoangKha.App_Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hinhanh")]
    public partial class hinhanh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string link { get; set; }
    }
}
