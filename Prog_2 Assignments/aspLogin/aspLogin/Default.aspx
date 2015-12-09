<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aspLogin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <h4 style="font-size: medium">Log In</h4>
        <hr/>
        <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="False">
            <p>
                <asp:Literal runat="server" ID="StatusText"></asp:Literal>
            </p>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="false">
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