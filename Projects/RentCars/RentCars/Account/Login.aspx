<%@ Page Title="Login" Language="C#" MasterPageFile="~/Main.Master" %>

<asp:Content ContentPlaceHolderID="head"
             ID="Content1"
             runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1"
             ID="Content2"
             runat="server">

    <asp:Login BackColor="#EFF3FB"
               BorderColor="#B5C7DE"
               BorderPadding="4"
               BorderStyle="Solid"
               BorderWidth="1px"
               Font-Names="Verdana"
               Font-Size="0.8em"
               ForeColor="#333333"
               ID="Login1"
               DisplayRememberMe="False"
               runat="server">
        <InstructionTextStyle Font-Italic="True"
                              ForeColor="Black" />
        <LoginButtonStyle BackColor="White"
                          BorderColor="#507CD1"
                          BorderStyle="Solid"
                          BorderWidth="1px"
                          Font-Names="Verdana"
                          Font-Size="0.8em"
                          ForeColor="#284E98" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#507CD1"
                        Font-Bold="True"
                        Font-Size="0.9em"
                        ForeColor="White" />
    </asp:Login>
</asp:Content>