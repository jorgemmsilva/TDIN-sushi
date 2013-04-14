<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Sushi Order</h2>
    <form id="sushiform" runat="server" method="post">
        <label for="Name">Name</label>
        <asp:TextBox ID="Name" runat="server"   />
        <br />
        <label for="Address">Address</label>
        <asp:TextBox ID="Address" runat="server" />
        <br />
        <label for="Creditcard" >Credit Card</label>
        <asp:TextBox ID="Creditcard" runat="server"  />
        <br />
        <h3>sushi types</h3>


        <div id="sushitypes" runat="server">
        </div>


        <asp:Button ID="newsushichoice" text="+" OnClick="addSushiChoice" runat="server"/>
        <asp:Button ID="removesushichoice" text="-" OnClick="removeSushiChoice" runat="server"/>
        <br />
        <asp:Button id="submitfom" text="Submit Order" OnClick="submitForm" runat="server" />
    </form>

</body>
</html>
