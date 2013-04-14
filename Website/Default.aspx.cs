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
    static int nsushitypes = 1;
    static Dictionary<DropDownList, TextBox> aux;

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
        string address = ConfigurationManager.AppSettings["RemoteAddress"];
        orderObj = (Common.OrderList)Activator.GetObject(typeof(Common.OrderList), address);
        aux = new Dictionary<DropDownList, TextBox>();

        for (int i = 0; i < 7; i++)
        {
            DropDownList ddl = new DropDownList();
            ddl.Items.Add(new ListItem("Chirashizushi", "Chirashizushi"));
            ddl.Items.Add(new ListItem("Inarizushi", "Inarizushi"));
            ddl.Items.Add(new ListItem("Makizushi", "Makizushi"));
            ddl.Items.Add(new ListItem("Narezushi", "Narezushi"));
            ddl.Items.Add(new ListItem("Nigirizushi", "Nigirizushi"));
            ddl.Items.Add(new ListItem("Oshizushi", "Oshizushi"));
            ddl.Items.Add(new ListItem("Western-style sushi", "Western-style sushi"));

            

            Label l = new Label();
            l.Text = "quantity";

            TextBox t = new TextBox();
            if (i > 0)
            {
                ddl.Visible = false;
                l.Visible = false;
                t.Visible = false;
            }
            sushitypes.Controls.Add(ddl);
            sushitypes.Controls.Add(l);
            sushitypes.Controls.Add(t);
            sushitypes.Controls.Add(new LiteralControl("<br />"));
            aux.Add(ddl, t);
        }
        
        

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
        List<Common.OrderItem> orders = new List<Common.OrderItem>();

        float price = 0;

        int i2 = 0;
        foreach (KeyValuePair<DropDownList,TextBox> entry in aux)
        {
            i2++;
            if (entry.Key.Visible && entry.Value.Text!= "")
            {
                orderObj.writeToConsole(i2.ToString());
                int i = Convert.ToInt32(entry.Value.Text);
                orders.Add(new Common.OrderItem(entry.Key.SelectedValue,Convert.ToInt32(entry.Value.Text)));
                price += i*5;
            }
        }
        
        
        Common.Order o = new Common.Order(orderObj.GetCurrentId(), new Common.Client(name, address, creditcard), orders.ToArray(), price);
        orderObj.AddOrder(o);
    }


    /*
     *            <asp:DropDownList runat="server">
     *            <asp:ListItem Selected="True" Value="Chirashizushi"> Chirashizushi </asp:ListItem>
     *            <asp:ListItem Value="Inarizushi"> Inarizushi </asp:ListItem>
     *            <asp:ListItem Value="Makizushi"> Makizushi </asp:ListItem>
     *            <asp:ListItem Value="Narezushi"> Narezushi </asp:ListItem>
     *            <asp:ListItem Value="Nigirizushi"> Nigirizushi </asp:ListItem>
     *            <asp:ListItem Value="Oshizushi"> Oshizushi </asp:ListItem>
     *            <asp:ListItem Value="Western-style sushi"> Western-style sushi </asp:ListItem>
     *            </asp:DropDownList>
     *            <label for="quantity" runat="server">quantity</label><input type="text" class="quantity" runat="server"  />

     */

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
        //string s = "<div ID=\"sushichoices\" runat=\"server\"><div class=\"choice\" runat=\"server\"><select runat=\"server\"><option value=\"Chirashizushi\">Chirashizushi</option><option value=\"Inarizushi\">Inarizushi</option><option value=\"Makizushi\">Makizushi</option><option value=\"Narezushi\">Narezushi</option><option value=\"Nigirizushi\">Nigirizushi</option><option value=\"Oshizushi\">Oshizushi</option><option value=\"Western-style sushi\">Western-style sushi</option></select><label for=\"quantity\" runat=\"server\">quantity</label><input type=\"text\" class=\"quantity\" runat=\"server\"  /><asp:Button class=\"newsushichoice\" text=\"+\" OnClick=\"addSushiChoice\" runat=\"server\"/></div></div><br />";
        //string s = "<asp:DropDownList runat=\"server\"><asp:ListItem Selected=\"True\" Value=\"Chirashizushi\"> Chirashizushi </asp:ListItem><asp:ListItem Value=\"Inarizushi\"> Inarizushi </asp:ListItem><asp:ListItem Value=\"Makizushi\"> Makizushi </asp:ListItem><asp:ListItem Value=\"Narezushi\"> Narezushi </asp:ListItem><asp:ListItem Value=\"Nigirizushi\"> Nigirizushi </asp:ListItem><asp:ListItem Value=\"Oshizushi\"> Oshizushi </asp:ListItem><asp:ListItem Value=\"Western-style sushi\"> Western-style sushi </asp:ListItem></asp:DropDownList><label for=\"quantity\" runat=\"server\">quantity</label><input type=\"text\" class=\"quantity\" runat=\"server\"  />";
        
        //pageSource += "<asp:Button id=\"submitfom\" text=\"Submit Order\" OnClick=\"submitForm\" runat=\"server\" /></form></body></html>";
        /*
        string tmp = "<h3>sushi types</h3>";
        int index = pageSource.IndexOf(tmp) + tmp.Length;
        string p1 = pageSource.Substring(0, index);
        string p2 = pageSource.Substring(index, pageSource.Length-index);
        pageSource = p1;
         * */
        /*
        for (int i = 0; i < sushicount; i++)
        {

            DropDownList ddl = new DropDownList();
            ddl.Items.Add(new ListItem("Chirashizushi", "Chirashizushi"));
            ddl.Items.Add(new ListItem("Inarizushi", "Inarizushi"));
            ddl.Items.Add(new ListItem("Makizushi", "Makizushi"));
            ddl.Items.Add(new ListItem("Narezushi", "Narezushi"));
            ddl.Items.Add(new ListItem("Nigirizushi", "Nigirizushi"));
            ddl.Items.Add(new ListItem("Oshizushi", "Oshizushi"));
            ddl.Items.Add(new ListItem("Western-style sushi", "Western-style sushi"));
            
            sushitypes.Controls.Add(ddl);

        }
        
        */
        //orderObj.writeToConsole(pageSource);
        writer.Write(pageSource);

        // remove the viewstate field from the captured markup
        //string viewStateRemoved =;

        // the page source, without the viewstate field, is in viewStateRemoved
        // do what you like with it
    }


    protected void addSushiChoice(object sender, EventArgs e)
    {
        
        if (nsushitypes < 8)
        {
            bool ddl = false;
            bool lbl = false;
            bool txt = false;
            foreach (Control ctrl in sushitypes.Controls)
            {
                if ((ctrl is DropDownList) && (ctrl.Visible == false) && !ddl)
                {
                    ctrl.Visible = true;
                    ddl = true;
                }
                else
                    if (ctrl is Label && ctrl.Visible == false && !lbl)
                    {
                        ctrl.Visible = true;
                        lbl = true;
                    }
                    else
                        if (ctrl is TextBox && ctrl.Visible == false && !txt)
                        {
                            ctrl.Visible = true;
                            txt = true;
                        }

            }
            nsushitypes++;
        }
    }

    protected void removeSushiChoice(object sender, EventArgs e)
    {
        
        if (nsushitypes > 1)
        {
            int n = 0;
            bool ddl = false;
            bool lbl = false;
            bool txt = false;
            foreach (Control ctrl in sushitypes.Controls)
            {
                if (ctrl is DropDownList)
                {
                    n++;

                    if (n >= nsushitypes && !ddl)
                    {
                        ctrl.Visible = false;
                        ddl = true;
                    }
                }
                else
                    if (ctrl is Label)
                    {
                        if (n >= nsushitypes && !lbl)
                        {
                            ctrl.Visible = false;
                            lbl = true;
                        }
                    }
                    else
                        if (ctrl is TextBox)
                        {
                            if (n >= nsushitypes && !txt)
                            {
                                ctrl.Visible = false;
                                txt = true;
                            }
                        }

            }

            nsushitypes--;
        }
    }
}