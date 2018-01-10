<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="apteka.ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="212px" Width="190px" AutoPostBack="true" style="float: left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Kurier</asp:ListItem>
            <asp:ListItem Value="1">Poczta</asp:ListItem>
            <asp:ListItem Value="2">Paczkomat</asp:ListItem>
        </asp:RadioButtonList>
        <div style="height: 277px">
            <asp:BulletedList ID="cartList" runat="server" Height="244px"  style="float: left" Width="184px">
            </asp:BulletedList>
            <asp:BulletedList ID="itemsAddList" runat="server" Height="244px"  style="margin-left: 0px; float: left" Width="43px" DisplayMode="LinkButton" OnClick="itemsAddList_Click">
            </asp:BulletedList>
            <asp:BulletedList ID="itemListSubtract" runat="server" Height="244px"  style="margin-left: 0px; float: left" DisplayMode="LinkButton" Width="35px" OnClick="itemListSubtract_Click" >
            </asp:BulletedList>
        </div>
        Koszt :<asp:TextBox ID="totalTextBox" runat="server" Height="47px" style="margin-left: 75px" Width="198px"></asp:TextBox>
    </form>
</body>
</html>
