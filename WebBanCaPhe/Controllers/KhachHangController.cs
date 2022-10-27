using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanCaPhe.Models;

namespace WebBanCaPhe.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyCaPheEntities db = new QuanLyCaPheEntities();
        public ActionResult Index()
        {
            var lstKH = from KH in db.KhachHangs select KH;

            return View(lstKH);
        }
    }
}