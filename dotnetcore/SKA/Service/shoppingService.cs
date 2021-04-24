using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKA.Models;
using SKA.Repo;

namespace SKA.Service
{
    public class shoppingService : IshoppingService
    {
        private readonly List<goods> _goodsList = new List<goods>();
        private readonly IgoodsRepo _goodsRepo;
        public shoppingService(IgoodsRepo goodsRepo)
        {
            _goodsRepo = goodsRepo;

        }
        public void putintoShoppingcart(goods goods)
        {
            if (_goodsList.Contains(goods))
            {
                _goodsList.Where(o => o.Name == goods.Name).First().num++;
            }
            else
            {
                _goodsList.Add(goods);
                _goodsList.Where(o => o.Name == goods.Name).First().num++;
            }
            
        }

        public List<goods> getmygoodinshoppingcart()
        {
            return _goodsList.OrderBy(o=>o.Name).ToList();
        }

        public void deleteMyGoods(string Name)
        {
            var goods = _goodsRepo.GetGoodsByName(Name);
            if (_goodsList.First(o => o.Name == Name).num > 1)
            {
                _goodsList.First(o => o.Name == Name).num--;
            }
            else
            {
                _goodsList.Remove(goods);
            }

        }
    }
}
