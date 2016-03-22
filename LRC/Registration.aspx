<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <h1>Registration</h1>
        <p>Add Venue</p>
        <table>
            <tr>
                <td>Venue Name</td>
                <td>
                    <asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Venue Name is Required" ControlToValidate="VenueNameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="AddressRequiredFieldValidator" runat="server" ErrorMessage="Address is Required" ControlToValidate="AddressTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="City is Required" ControlToValidate="CityTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="State is Required" ControlToValidate="StateTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Zip Code</td>
                <td>
                    <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Zip Code is Required" ControlToValidate="ZipCodeTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td>Web Page</td>
                <td>
                    <asp:TextBox ID="WebPageTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Web Page is Required" ControlToValidate="WebPageTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td>Age Restriction</td>
                <td>
                    <asp:TextBox ID="AgeRestrictionTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Age Restriction is Required" ControlToValidate="AgeRestrictionTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Email is Required" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Email Not Valid" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>            
            <tr>
                <td>Phone Number</td>
                <td>
                    <asp:TextBox ID="PhoneNumberTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Phone Number is Required" ControlToValidate="PhoneNumberTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="UserNameRequiredFieldValidator" runat="server" ErrorMessage="User Name is Required" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Password is Required" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>                
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Confirm Password is Required" ControlToValidate="ConfirmTextBox"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Must Match" ControlToValidate="ConfirmTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator>
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
