<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orderstatus.aspx.cs" Inherits="Orderstatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Awaiting preparation</h3><br />
        <asp:GridView ID="waiting" runat="server" >
            <Columns>
            <asp:TemplateField HeaderText="Client">
                     <ItemTemplate>
                        <asp:Label runat="server" Text='<%# ((Common.Order)Container.DataItem).client.name %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

        <h3>Preparating</h3><br />
        <asp:GridView ID="preparation" runat="server" >
            <Columns>
            <asp:TemplateField HeaderText="Client">
                     <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# ((Common.Order)Container.DataItem).client.name %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

        <h3>Ready</h3><br />
        <asp:GridView ID="ready" runat="server">
            <Columns>
            <asp:TemplateField HeaderText="Client">
                     <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# ((Common.Order)Container.DataItem).client.name %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

        <h3>Delivery</h3><br />
        <asp:GridView ID="delivery" runat="server" >
            <Columns>
            <asp:TemplateField HeaderText="Client">
                     <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# ((Common.Order)Container.DataItem).client.name %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

        <h3>Finished</h3><br />
        <asp:GridView ID="finished" runat="server" >
            <Columns>
            <asp:TemplateField HeaderText="Client">
                     <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# ((Common.Order)Container.DataItem).client.name %>'></asp:Label>
                    </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

    </div>
    </form>
</body>
</html>
