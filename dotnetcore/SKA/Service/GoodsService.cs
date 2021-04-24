using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKA.Models;
using SKA.Repo;

namespace SKA.Service
{
    public class GoodsService : IGoodsService
    {
        private readonly IgoodsRepo _goodsRepo;

        public GoodsService(IgoodsRepo goodsRepo)
        {
            _goodsRepo = goodsRepo;
        }
        public void addNewGoods(goods goods)
        {

           _goodsRepo.addGoods(goods);
        }

        public void editPrice(goods goods)
        {
            _goodsRepo.updatePrice(goods goods);
        }
    }
}
