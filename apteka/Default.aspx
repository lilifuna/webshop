<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="apteka._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        
       
    

    <asp:RadioButtonList ID="categoriesRadioBtnList" runat="server" Height="79px" RepeatDirection="Horizontal" Width="691px" AutoPostBack="True" OnSelectedIndexChanged="categoriesRadioBtnList_SelectedIndexChanged">
        <asp:ListItem Value="1">Leki na kaszel</asp:ListItem>
        <asp:ListItem Value="2">Leki przeciwbólowe</asp:ListItem>
        <asp:ListItem Value="3">Środki anestezjologiczne</asp:ListItem>
    </asp:RadioButtonList>
    <div style="height: 250px">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="168px" Width="188px" style="float:left">
        </asp:CheckBoxList>
        <asp:CheckBoxList ID="CheckBoxList2" runat="server" Height="168px" Width="188px" style="float:left" Visible="False">
        </asp:CheckBoxList>
        <asp:CheckBoxList ID="CheckBoxList3" runat="server" Height="168px" Width="188px" style="float:left" Visible="False">
        </asp:CheckBoxList>
        
        <asp:Button ID="addToCart" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Height="123px" OnClick="Button1_Click" Text="Dodaj do koszyka" Width="253px" />
        
    </div>
    

    
        
       
    

</asp:Content>
