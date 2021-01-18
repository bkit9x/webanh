using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenHoangKha.App_Code
{
    public partial class DBHinhAnh : DbContext
    {
        public DBHinhAnh()
            : base("name=DBHinhAnh")
        {
        }

        public virtual DbSet<hinhanh> hinhanhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<hinhanh>()
                .Property(e => e.id)
                .IsFixedLength();
        }
    }
}
