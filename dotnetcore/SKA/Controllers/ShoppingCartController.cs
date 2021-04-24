using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SKA.Repo;
using SKA.Service;

namespace SKA.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IgoodsRepo _goodsRepo;
        private readonly IshoppingService _shoppingService;

        public ShoppingCartController(IgoodsRepo goodsRepo, IshoppingService shoppingService)
        {
            _goodsRepo = goodsRepo;
            _shoppingService = shoppingService;
        }
        public IActionResult Index()
        {
            var goods= _goodsRepo.getGoods();
            return View("Allgoods", goods);
        }

        public IActionResult PutintoShoppingcart(string goodsName)
        {
            var goods = _goodsRepo.GetGoodsByName(goodsName);
            _shoppingService.putintoShoppingcart(goods);
            return RedirectToAction("Index","ShoppingCart");
        }

        public IActionResult ShowgoodsinMyshoppingcart()
        {
            var mygoods = _shoppingService.getmygoodinshoppingcart();

            return View("MyGoods", mygoods);
        }

        public IActionResult deleteMyGoods(string Name)
        {
            
            _shoppingService.deleteMyGoods(Name);
            return RedirectToAction("ShowgoodsinMyshoppingcart","ShoppingCart");
        }
    }
}
