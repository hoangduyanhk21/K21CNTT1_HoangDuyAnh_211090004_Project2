using System.Data.Entity;

namespace NeoDurianAdminMVC_HoangDuyAnh.Models
{
    public class NeoDurianContext_HoangDuyAnh : DbContext
    {
        // Sử dụng connection string có tên "NeoDurianDB" được khai báo trong Web.config.
        public NeoDurianContext_HoangDuyAnh() : base("NeoDurianDB")
        {
        }

        // DbSet đại diện cho bảng NeoDurianItems_HoangDuyAnh trong database.
        public DbSet<NeoDurianItem_HoangDuyAnh> NeoDurianItems { get; set; }
    }
}
