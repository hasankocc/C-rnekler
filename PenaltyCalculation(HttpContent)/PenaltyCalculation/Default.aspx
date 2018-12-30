<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PenaltyCalculation.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frm" runat="server">
    <div>
     <asp:Label runat="server">Kitabın Alış Tarihi</asp:Label>
     <asp:Calendar ID="clnCheckoutDate" runat="server" ></asp:Calendar>
     <asp:Label runat="server">Kitabın Geriveriliş Tarihi</asp:Label>
     <asp:Calendar ID="clnReturnedDate" runat="server" ></asp:Calendar><br />
     <asp:Label runat="server">Ad Soyad </asp:Label>
     <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
     <asp:Label runat="server">Ülke </asp:Label>
     <asp:DropDownList ID="ddlCountry" runat="server" DataTextField="CountryName" DataValueField="id" AutoPostBack="true"></asp:DropDownList><br />
     <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click"/><br />
     <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
