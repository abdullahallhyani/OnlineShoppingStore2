using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult PaymentViwe()
        {
            return View();
        }
        public ActionResult Payment() { return Redirect("Index"); }

        public ActionResult SuccessView() {
            return View();
        }
    }
}