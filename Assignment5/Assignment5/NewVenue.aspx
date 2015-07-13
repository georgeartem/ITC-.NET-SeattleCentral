<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewVenue.aspx.cs" Inherits="Assignment5.NewVenue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Show</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Enter New Show Information</h1>
        <hr />
        <p>Select a Venue</p>
    <table>
        <tr>
            <td>Select a Venue from the Database</td>
            <td>
                <asp:DropDownList ID="ddlVenues" runat="server"></asp:DropDownList></td>
          
        </tr>
          <tr>
            <td>Select an Artist or Enter a New Artist</td>
            <td>
                <asp:DropDownList ID="ddlArtist" runat="server"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtArtist" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
            <td>Enter Show Time</td>
            <td>
                <asp:TextBox ID="txtShwtime" runat="server"></asp:TextBox> </td>
            <td>
                 </td>
        </tr>
          <tr>
            <td>Enter Show Details</td>
            <td>
                <asp:TextBox ID="txtShwDetails" runat="server"></asp:TextBox>  </td>
            <td>
                </td>
        </tr>
          <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" /></td>
            <td>
                <asp:Label ID="lbResult" runat="server" Text=""></asp:Label> </td>
            <td>
                </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
