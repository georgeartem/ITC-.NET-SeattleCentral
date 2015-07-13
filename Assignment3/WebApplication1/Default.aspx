<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <h1>Welcome to the Fan Login Page</h1>
    <p>Login or Register a New Account</p>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>Enter Username</td>
            <td>
                <asp:TextBox ID="TextUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr><td>Enter Password</td>
            <td>
                <asp:TextBox ID="TextPassword" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
             <td>
                 <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                </td>
            
        </tr>
    </table>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Registration.aspx.">Register New Account</asp:LinkButton></p>
    </div>
    </form>
</body>
</html>
