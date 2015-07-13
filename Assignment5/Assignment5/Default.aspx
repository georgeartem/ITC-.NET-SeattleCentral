<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Venue Login Page</h1>
        <hr />
        <p>To book a venue you must log in.</p>
        <table class="login">
            <tr>
                <td class="login">User Name</td>
                <td class="login">
                    <asp:TextBox ID="txtUserName" runat="server">
</asp:TextBox></td>
            </tr>
                <tr>
                <td class="login">Password</td>
                <td class="login">
                    <asp:TextBox ID="txtPassword" runat="server" 
TextMode="Password">
                   </asp:TextBox></td>
            </tr>
                <tr>
                <td class="login">
                    <asp:Button ID="btnLogin" runat="server" Text="LogIn" />
                </td>
                <td class="login">
                    <asp:Label ID="lblMessage" runat="server" Text="">
</asp:Label> </td>
            </tr>
        </table>
        <asp:LinkButton ID="lbRegister" runat="server" 
            PostBackUrl="~/Register.aspx">New User Registration</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
