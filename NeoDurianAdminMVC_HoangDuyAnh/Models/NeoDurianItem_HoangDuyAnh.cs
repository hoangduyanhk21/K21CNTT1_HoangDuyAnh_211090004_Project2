using System.ComponentModel.DataAnnotations;

namespace NeoDurianAdminMVC_HoangDuyAnh.Models
{
    public class NeoDurianItem_HoangDuyAnh
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Giá không được để trống.")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải là số dương.")]
        public decimal Price { get; set; }

        [StringLength(250, ErrorMessage = "Mô tả không được vượt quá 250 ký tự.")]
        public string Description { get; set; }
    }
}
