using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static Common.OrderList orderObj;
    static int sushicount;

    /*
     <!--
    <form id="form1" runat="server">
      <asp:Button ID="Button1" runat="server" Text="Listar todas as ordens" OnClick="Button1_Click" />
      <br />
      <br />
      <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>
      <br />
    </form>
    -->
     */


    protected void Page_Load(object sender, EventArgs e) {
        //if (!IsPostBack)                                        // first load in a session
        //    GridView1.Visible = false;
        if (sushicount == 0)
            sushicount = 1;
        string address = ConfigurationManager.AppSettings["RemoteAddress"];
        orderObj = (Common.OrderList)Activator.GetObject(typeof(Common.OrderList), address);

    }
    /*
    protected void Button1_Click(object sender, EventArgs e) {
        List<Common.Order> ls = orderObj.GetAllOrders();
  
        GridView1.DataSource = ls;
        GridView1.DataBind();
        GridView1.Visible = true;
    }
    */
    protected void submitForm(object sender, EventArgs e)
    {
        string name = Name.Text; // Request.Form["Name"];
        string address = Address.Text;
        string creditcard = Creditcard.Text;
        Console.WriteLine(name + " " + address + " " + creditcard);
        Common.Order o = new Common.Order(0, new Common.Client(name,address,creditcard), null, 0);
        orderObj.AddOrder(o);
    }


    protected override void Render(HtmlTextWriter writer)
    {
        // setup a TextWriter to capture the markup
        TextWriter tw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(tw);

        // render the markup into our surrogate TextWriter
        base.Render(htw);

        // get the captured markup as a string
        string pageSource = tw.ToString();
        
        // render the markup into the output stream verbatim
        string s = "<div ID=\"sushichoices\" runat=\"server\"><div class=\"choice\" runat=\"server\"><select ID=\"sushitypes\" runat=\"server\"><option value=\"Chirashizushi\">Chirashizushi</option><option value=\"Inarizushi\">Inarizushi</option><option value=\"Makizushi\">Makizushi</option><option value=\"Narezushi\">Narezushi</option><option value=\"Nigirizushi\">Nigirizushi</option><option value=\"Oshizushi\">Oshizushi</option><option value=\"Western-style sushi\">Western-style sushi</option></select><label for=\"quantity\" runat=\"server\">quantity</label><input type=\"text\" class=\"quantity\" runat=\"server\"  /><asp:Button class=\"newsushichoice\" text=\"+\" OnClick=\"addSushiChoice\" runat=\"server\"/></div></div><br />";
        //pageSource += "<asp:Button id=\"submitfom\" text=\"Submit Order\" OnClick=\"submitForm\" runat=\"server\" /></form></body></html>";

        string tmp = "<h3>sushi types</h3>";
        int index = pageSource.IndexOf(tmp) + tmp.Length;
        string p1 = pageSource.Substring(0, index);
        string p2 = pageSource.Substring(index, pageSource.Length-index);
        pageSource = p1;
        for (int i = 0; i < sushicount; i++)
        {
            pageSource += s;
        }
            pageSource += p2;
        //orderObj.writeToConsole(pageSource);
        writer.Write(pageSource);

        // remove the viewstate field from the captured markup
        //string viewStateRemoved =;

        // the page source, without the viewstate field, is in viewStateRemoved
        // do what you like with it
    }


    protected void addSushiChoice(object sender, EventArgs e)
    {

        ++sushicount;
    }

    protected void removeSushiChoice(object sender, EventArgs e)
    {
        if(sushicount > 1)
            sushicount--;

    }
}