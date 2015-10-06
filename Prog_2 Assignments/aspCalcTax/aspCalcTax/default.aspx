<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspCalcTax.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Din skatt</title>
    </head>
    <body>
        <asp:SqlDataSource ID="dsCities" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [City] FROM [Taxes]" ></asp:SqlDataSource>   
        <form id="form1" runat="server">
            <div>
                <h1>Beräkna din skatt</h1>
                <table>
                    <tr>
                        <td>Personnummer:</td>
                        <td>
                            <asp:TextBox ID="txtPNo" runat="server">
                            </asp:TextBox><asp:Label ID="lblPNoErr" runat="server" Text="*" Visible="false">
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Bruttolön:</td>
                        <td>
                            <asp:TextBox EnableViewState="False" ID="txtSalary" runat="server">
                            </asp:TextBox>

                        </td>
                        <td>
                            <asp:RequiredFieldValidator ErrorMessage="*" ForeColor="Red" ControlToValidate="txtSalary"
                                ID="RequiredFieldValidator1" runat="server" ></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td>Kommun:</td>
                        <td>
                            <asp:DropDownList runat="server" ID="ddlProvince">
                                <asp:ListItem Text="Välj Kommun" Value="0"></asp:ListItem>
                                <asp:ListItem Text="------" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Motala" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Linköping" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Norrköping" Value="4"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>

                Medlem i svenska kyrkan:<br/>
                <asp:RadioButtonList ID="rdChruch" RepeatDirection="Horizontal" runat="server">
                    <asp:ListItem Selected="True" Text="Ja" value="Yes">
                    </asp:ListItem>
                    <asp:ListItem Selected="False" Text="Nej" value="No">
                    </asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="btnCalc" OnClick="btnCalc_OnClick" runat="server" Text="Beräkna"></asp:Button>


            </div>
        </form>
    </body>
</html>