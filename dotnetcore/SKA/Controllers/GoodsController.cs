using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SKA.Models;
using SKA.Repo;
using SKA.Service;

namespace SKA.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoodsService _goodsService;
        private readonly IgoodsRepo _goodsRepo;

        public GoodsController(IGoodsService goodsService,IgoodsRepo goodsRepo)
        {
            _goodsService = goodsService;
            _goodsRepo = goodsRepo;
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

        public IActionResult editPricePartialView(goods goods)
        {
            return PartialView("editpricePartialView",goods);
        }

        public IActionResult editPriceView()
        {
            var goods = _goodsRepo.getGoods();
            //ViewBag.goods = goods;
            //return View("AddGoods");
            
            return View("editprice", goods);
        }

        public IActionResult editPrice(goods goods)
        {
            _goodsService.updatePrice(goods);
            return RedirectToAction("Index", "ShoppingCart");
        }

    }
}
