using System.Collections.Generic;
using SKA.Models;

namespace SKA.Service
{
    public interface IshoppingService
    {
        void putintoShoppingcart(goods goods);
        List<goods> getmygoodinshoppingcart();
        void deleteMyGoods(string Name);
    }
}