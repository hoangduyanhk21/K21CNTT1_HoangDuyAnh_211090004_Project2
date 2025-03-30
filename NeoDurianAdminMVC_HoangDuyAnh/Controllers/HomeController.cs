using System.Web.Mvc;

namespace NeoDurianAdminMVC_HoangDuyAnh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Trang chủ, hiển thị giao diện hoặc điều hướng
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mô tả về website bán sầu riêng.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Thông tin liên hệ.";
            return View();
        }
    }
}
