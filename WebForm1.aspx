<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RequerimientoWeb.FormNumeroVariable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
            <asp:Button ID="btnNro1" runat="server" Text="Incrementar" OnClick="btnNro1_Click" />
            <asp:Button ID="btnNro2" runat="server" Text="Abrir Form2" PostBackUrl="~/WebForm2.aspx" />
        </div>
    </form>
</body>
</html>
