using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SKA.Models;
using SKA.Service;

namespace SKA.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoodsService _goodsService;
        public GoodsController(IGoodsService goodsService)
        {
            _goodsService = goodsService;
        }

        public IActionResult AddGoodsView()
        {
            return View("AddGoods");
        }
        public IActionResult AddGoods(goods goods)
        {
            _goodsService.addNewGoods(goods);
            return RedirectToAction("Index","ShoppingCart");
        }
    }
}
