<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginform.aspx.cs" Inherits="WebApplication1.loginform" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="LOGIN FORM"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter the username" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter the password" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
            <asp:LinkButton runat="server" OnClick="Unnamed2_Click">Reset Password</asp:LinkButton>
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
