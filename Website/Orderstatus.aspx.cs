using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Orderstatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string address = ConfigurationManager.AppSettings["RemoteAddress"];
        Common.OrderList orderObj = (Common.OrderList)Activator.GetObject(typeof(Common.OrderList), address);
        
        waiting.DataSource = orderObj.GetOrderWithStatus(Common.status.encomendada);
        waiting.DataBind();

        preparation.DataSource = orderObj.GetOrderWithStatus(Common.status.preparacao); ;
        preparation.DataBind();

        ready.DataSource = orderObj.GetOrderWithStatus(Common.status.pronta); ;
        ready.DataBind();

        delivery.DataSource = orderObj.GetOrderWithStatus(Common.status.entrega); ;
        delivery.DataBind();

        finished.DataSource = orderObj.GetOrderWithStatus(Common.status.concluida); ;
        finished.DataBind();

    }
}