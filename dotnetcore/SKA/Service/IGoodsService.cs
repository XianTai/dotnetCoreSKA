using System.Collections.Generic;
using SKA.Models;

namespace SKA.Service
{
    public interface IGoodsService
    {
        void addNewGoods(goods goods);
        void updatePrice(goods goods);
    }
}