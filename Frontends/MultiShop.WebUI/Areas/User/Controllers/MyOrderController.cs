﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.Interfaces;
using MultiShop.WebUI.Services.OrderServices.OrderOrderingServices;

namespace MultiShop.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class MyOrderController : Controller
    {
        private readonly IOrderOrderingServices _orderOrderingService;
        private readonly IUserService _userService;

        public MyOrderController(IOrderOrderingServices orderOrderingService, IUserService userService)
        {
            _orderOrderingService = orderOrderingService;
            _userService = userService;
        }

        public async Task<IActionResult> MyOrderList()
        {
            var userInfo = await _userService.GetUserInfo();
            var values = await _orderOrderingService.GetOrderingByUserId(userInfo.Id);
            return View(values);
        }
    }
}
