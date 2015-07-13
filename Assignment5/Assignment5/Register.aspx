<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment5.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>New Venue Registration</h1>
    <table>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password">
                </asp:TextBox></td>
        </tr>
         <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password">
                </asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Button ID="btnRegister" runat="server" Text="Register" /></td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </td>
        </tr>
    </table>
        <asp:LinkButton ID="lbLogin" runat="server" PostBackURL="~/Default.aspx">Log in</asp:LinkButton>


    </div>
    </form>
</body>
</html>
