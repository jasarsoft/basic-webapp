<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebPage.aspx.cs" Inherits="BasicWebApp.FirstWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to Visual Developer<br />
        <br />
        <br />
        Enter your name:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Display Name" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ForeColor="Red" ID="Label1" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
