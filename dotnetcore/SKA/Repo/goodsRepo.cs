using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKA.Models;

namespace SKA.Repo
{
    public interface IgoodsRepo
    {
        IEnumerable<goods> getGoods();
        goods GetGoodsByName(string name);
        void addGoods(goods goods);
    }

    public class goodsRepo : IgoodsRepo 
    {
        private  List<goods> goodsList = new()
        {
            new goods
            {
                Name = "pen",
                Price = 20,
                num = 0
            },

            new goods
            {
                Name = "eraser",
                Price = 10,
                num = 0
            }

        };

        public IEnumerable<goods> getGoods()
        {
            return goodsList;
        }

        public goods GetGoodsByName(string name)
        {
            return goodsList.FirstOrDefault(o => o.Name == name);
        }

        public void addGoods(goods goods)
        {

            goodsList.Add(goods);
            
        }

        public void updatePrice(goods goods)
        {

            goodsList.First(o => o.Name == goods.Name).Price = goods.Price;
        }

    }
}
