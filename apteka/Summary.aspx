<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="apteka.Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><h1>Dziękujemy za złożenie zamówienia!</h1>
            Opłać je, a my w ciągu 24 godzin od zaksięgowania przelewu wyślemy je do Ciebie!
        </p>

        <p><h2>Podsumowanie</h2>
            Do zapłaty: <asp:TextBox ID="totalTextBox" runat="server" Height="47px" style="margin-left: 75px" Width="198px"></asp:TextBox>
            Dostawa: <asp:TextBox ID="shipTextBox" runat="server" Height="47px" style="margin-left: 75px" Width="198px"></asp:TextBox>
        </p>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Height="123px" OnClick="Button2_Click"  Text="ZAMÓW" Width="236px" />
                <asp:Button ID="openProducts" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Height="50px" OnClick="Button1_Click"  Text="Wróć do przeglądania produktów" Width="350px" />

    </div>
    </form>
</body>
</html>
