using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ViewStocks : System.Web.UI.Page
    {
        private static Stock[] stock;
        private static List<Stock> stockList;
        private static StockRepository sRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            sRepository = new StockRepository();
            stock = sRepository.getAllStocks();
            //Response.Write(stock[0].StockName);
            GridView1.DataSource = stock;
            GridView1.DataBind();
            

        }
    }
}