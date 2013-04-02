using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Common.OrderList orderObj;

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack)                                        // first load in a session
            GridView1.Visible = false;
        string address = ConfigurationManager.AppSettings["RemoteAddress"];
        orderObj = (Common.OrderList)Activator.GetObject(typeof(Common.OrderList), address);
    }

    protected void Button1_Click(object sender, EventArgs e) {
        List<Common.Order> ls = orderObj.GetAllOrders();
  
        GridView1.DataSource = ls;
        GridView1.DataBind();
        GridView1.Visible = true;
    }
}