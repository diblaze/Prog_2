<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="aspLogin.Account.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; font-size: small">
    <form id="form1" runat="server">
        <div>
            <h4 style="font-size: medium">Register a new user</h4>
            <hr />
            <p>
                <asp:Literal runat="server"
                             ID="StatusMessage"></asp:Literal>
            </p>
            <div style="margin-bottom: 10px">
                <asp:Label runat="server"
                           AssociatedControlID="UserName">Username</asp:Label>
                <div>
                    <asp:TextBox runat="server"
                                 ID="UserName"></asp:TextBox>
                </div>
            </div>
            <div style="margin-bottom: 10px">
                <asp:Label runat="server"
                           AssociatedControlID="Password">Password</asp:Label>
                <div>
                    <asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div style="margin-bottom: 10px">
                <asp:Label runat="server"
                           AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                <div>
                    <asp:TextBox runat="server"
                                 ID="ConfirmPassword"
                                 TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div>
                <div>
                    <asp:Button runat="server" OnClick="CreateUser_OnClick" Text="Register"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
