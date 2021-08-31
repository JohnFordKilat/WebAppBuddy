<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 560px">
            Username
            <asp:TextBox ID="usernameTextbox" runat="server"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="passwordTextbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
