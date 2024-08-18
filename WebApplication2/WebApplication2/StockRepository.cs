using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class StockRepository
    {
       
        private static Stock[] _stock = new Stock[2];
        private static int index = 0;

        public void addStock(Stock stock)

        {

            _stock[index] = stock;
            index++;
        }

        public Stock[] getAllStocks()

        {

            return _stock;

        }
    }
}