﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.directory1 = "MultiShop";
            @ViewBag.directory2 = "Ödeme İşlemleri";
            @ViewBag.directory3 = "Banka/Kredi Kartı İle Ödeme";
            return View();
        }
    }
}
