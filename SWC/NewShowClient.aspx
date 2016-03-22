<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewShowClient.aspx.cs" Inherits="NewShowClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add a Show</h1>
        <hr />
        <p>
        <asp:DropDownList ID="ShowDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ShowDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        </p>
        
        <asp:Panel ID="Panel1" runat="server">
            <hr/>
            <table id="NewShowTable"> 
                <tr>
                    <td class="auto-style1">Artist Name</td>
                    <td class="auto-style1">
                         <asp:TextBox ID="ShowTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Choose Artist</td>
                    <td>
                        <asp:DropDownList ID="ArtistDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ArtistDropDownList_SelectedIndexChanged"></asp:DropDownList>
                        <asp:Panel ID="Panel2" runat="server">
                            <p>Add Artist Name <asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox><br />
                                <asp:Button ID="AddArtistButton" runat="server" Text="Add" OnClick="AddArtistButton_Click" />
                            </p>
                        </asp:Panel>
                    </td>
                    </tr>
                </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
