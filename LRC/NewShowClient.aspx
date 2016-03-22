<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewShowClient.aspx.cs" Inherits="NewShowClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add a Show</h1>
        <p>
        <asp:DropDownList ID="ArtistDropDownList" runat="server" AutoPostBack="True"></asp:DropDownList>
        </p>
        <asp:Panel ID="Panel1" runat="server">
                <table>
                    <tr>
                        <td>Artist Name</td>
                        <td><asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox></td>
                    </tr>
            <tr>
                <td>Show Name</td>
                <td>
                    <asp:TextBox ID="ShowNameTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Show Name is Required" ControlToValidate="ShowNameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
                    <tr>
                <td>Show Date</td>
                <td>
                    <asp:TextBox ID="ShowDateTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Show Date is Required" ControlToValidate="ShowDateTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
                    <tr>
                <td>Show Time</td>
                <td>
                    <asp:TextBox ID="ShowTimeTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Show Time is Required" ControlToValidate="ShowTimeTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
                    <tr>
                <td>Show Ticket Info</td>
                <td>
                    <asp:TextBox ID="ShowTicketInfoTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Show Ticket Info is Required" ControlToValidate="ShowTicketInfoTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
                </table>
                <h2>Add Show Details</h2>
        <table>
            <tr>
                <td>Artist Start Time</td>
                <td>
                    <asp:TextBox ID="ArtistStartTimeTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Artist Start Time is Required" ControlToValidate="ArtistStartTimeTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Additional Detail</td>
                <td>
                    <asp:TextBox ID="AdditionalDetailTextBox" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Additional Detail is Required" ControlToValidate="AdditionalDetailTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="AddArtistButton" runat="server" Text="Submit" OnClick="AddArtistButton_Click" />
                </td>
            </tr>
        </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
