using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class AddStocks : System.Web.UI.Page
    {
        Stock s = new Stock();
        StockRepository sRepository = new StockRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            s.StockCode = int.Parse(txtCode.Text);
            s.StockName = txtName.Text;
            s.Price = int.Parse(txtPrice.Text);

            sRepository.addStock(s);
        }
    }
}