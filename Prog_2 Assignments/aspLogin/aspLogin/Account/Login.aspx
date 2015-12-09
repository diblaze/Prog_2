<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="aspLogin.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; font-size: small">
<form id="form1" runat="server">
    <div>
        <h4 style="font-size: medium">Log In</h4>
        <hr/>
        <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="False">
            <p>
                <asp:Literal runat="server" ID="StatusText"></asp:Literal>
            </p>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="LoginForm" Visible="False">
            <div style="margin-bottom: 10px">
                <asp:Label runat="server" AssociatedControlID="UserName">Username</asp:Label>
                <div>
                    <asp:TextBox runat="server" ID="UserName"></asp:TextBox>
                </div>
            </div>
            <div style="margin-bottom: 10px">
                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                <div>
                    <asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div style="margin-bottom: 10px">
                <div>
                    <asp:Button runat="server" ID="LoginButton" OnClick="SignIn" Text="Log in"/>
                </div>
            </div>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="False">
            <div>
                <div>
                    <asp:Button runat="server" OnClick="SignOut" Text="Log out"/>
                </div>
            </div>
        </asp:PlaceHolder>
    </div>

</form>
</body>
</html>