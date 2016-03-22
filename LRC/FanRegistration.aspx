<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanRegistration.aspx.cs" Inherits="FanRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Fan Registration</h1>
        <p>Add Info</p>
        <table>
            <tr>
                <td>Fan Name</td>
                <td>
                    <asp:TextBox ID="FanNameTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fan Name is Required" ControlToValidate="FanNameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is Required" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Userame</td>
                <td>
                    <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Username is Required" ControlToValidate="UsernameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Fan Name</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password is Required" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                </td>
                <td>
                    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
