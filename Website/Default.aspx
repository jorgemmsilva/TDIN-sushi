<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Button ID="Button1" runat="server" Text="GetOrders" OnClick="Button1_Click" />
      <br />
      <br />
      <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>
      <br />
    </form>
</body>
</html>
