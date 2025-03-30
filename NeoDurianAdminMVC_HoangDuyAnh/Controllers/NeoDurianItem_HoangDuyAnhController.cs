using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using NeoDurianAdminMVC_HoangDuyAnh.Models;

namespace NeoDurianAdminMVC_HoangDuyAnh.Controllers
{
    public class NeoDurianItem_HoangDuyAnhController : Controller
    {
        private NeoDurianContext_HoangDuyAnh db = new NeoDurianContext_HoangDuyAnh();

        // GET: NeoDurianItem_HoangDuyAnh
        public ActionResult Index()
        {
            // Lấy danh sách sản phẩm từ database và trả về View
            var items = db.NeoDurianItems.ToList();
            return View(items);
        }

        // GET: NeoDurianItem_HoangDuyAnh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // Trả về lỗi 400 Bad Request
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Tìm sản phẩm theo id
            NeoDurianItem_HoangDuyAnh item = db.NeoDurianItems.Find(id);
            if (item == null)
            {
                // Nếu không tìm thấy, trả về 404 Not Found
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: NeoDurianItem_HoangDuyAnh/Create
        public ActionResult Create()
        {
            // Trả về form thêm sản phẩm
            return View();
        }

        // POST: NeoDurianItem_HoangDuyAnh/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Price,Description")] NeoDurianItem_HoangDuyAnh item)
        {
            if (ModelState.IsValid)
            {
                // Thêm sản phẩm vào database
                db.NeoDurianItems.Add(item);
                db.SaveChanges();
                // Quay về trang danh sách
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: NeoDurianItem_HoangDuyAnh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeoDurianItem_HoangDuyAnh item = db.NeoDurianItems.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: NeoDurianItem_HoangDuyAnh/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Price,Description")] NeoDurianItem_HoangDuyAnh item)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật sản phẩm
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: NeoDurianItem_HoangDuyAnh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NeoDurianItem_HoangDuyAnh item = db.NeoDurianItems.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: NeoDurianItem_HoangDuyAnh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NeoDurianItem_HoangDuyAnh item = db.NeoDurianItems.Find(id);
            db.NeoDurianItems.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
