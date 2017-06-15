using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace Tests
{
    class Goods
    {

        #region fields
        public string GoodsName { get; set; }
        public DateTime OrderDate { get; set; }
        public Money Price { get; set; }
        public int GoodsCount { get; set; }
        public int Documentation { get; set; }
        #endregion
        #region ctor's
        public Goods() { }

        public Goods(string goodsName, DateTime date,int count,int docs, Money price)
        {
            GoodsName = goodsName;
            OrderDate = date;
            Price = price;
            GoodsCount = count;
            Documentation = docs;
        }
        #endregion

        public override string ToString()
        {
            return String.Format($"The price is:{Price}");
        }

        public void IncreasePrice(Money delta)
        {
            Price += delta;
        }
        public Money DecreasePrice(long r,int k)
        {
            Money newPrice = new Money();
            newPrice = Price - new Money(r, k);
            return newPrice;
        }

        public Money GetFinalPrice()
        {
            return Price*GoodsCount;
        }

        public Money DevideSumMoney(Money m1, Money m2)
        {
            return m1/m2;
        }

        public Money DevideByInt(Money m, int dev)
        {
            return m/dev;
        }




    }
}
