<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanLogin.aspx.cs" Inherits="FanLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Fan Registration</h1>
        <p>Log in</p>
        <table>
            <tr>
                <td>Fan Name</td>
                <td><asp:TextBox ID="FanNameTextBox" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" /></td>
                <td><asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <asp:LinkButton ID="RegisterLinkButton" runat="server" PostBackUrl="~/FanRegistration.aspx">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
