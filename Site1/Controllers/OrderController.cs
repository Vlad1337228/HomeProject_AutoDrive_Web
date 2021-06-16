using Microsoft.AspNetCore.Mvc;
using Site1.Data.Interfaces;
using Site1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Controllers
{
    public class OrderController :Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders app, ShopCart sc)
        {
            allOrders = app;
            shopCart = sc;
        }

        public IActionResult Checkout()
        {

            return View();
        }
    }
}
