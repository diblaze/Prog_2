<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspCalcTax.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Din skatt</title>
    </head>
    <body>
        <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ID="dsCities" runat="server" SelectCommand="SELECT [City] FROM [Taxes]"></asp:SqlDataSource>
        <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ID="dsTaxes" runat="server" SelectCommand="SELECT * FROM [Taxes] WHERE City=@city">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProvince" Name="city" PropertyName="SelectedValue" Type="String"/>
            </SelectParameters>
        </asp:SqlDataSource>

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
                            <asp:RequiredFieldValidator ControlToValidate="txtSalary" ErrorMessage="*" ForeColor="Red" ID="RequiredFieldValidator1" ValidationGroup="taxGroup" runat="server"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td>Kommun:</td>
                        <td>
                            <asp:DropDownList AutoPostBack="True" DataSourceID="dsCities" DataTextField="City" DataValueField="City" ID="ddlProvince" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <asp:FormView DataKeyNames="id" DataSourceID="dsTaxes" ID="fvTaxData" runat="server" CellPadding="4" ForeColor="#333333">
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemTemplate>
                        <asp:Panel ID="pnlTaxData" runat="server">
                            <h4>Avgifter och skatter</h4>
                            <table>
                                <tr>
                                    <td>Kommunalskatt:</td>
                                    <td>
                                        <asp:Label id="lblLocalTax" runat="server" Text='<%# String.Format("{0:P2}", Eval("LocalTax"))%>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Kyrkoavgift:</td>
                                    <td>
                                        <asp:Label id="lblChurchTax" runat="server" Text='<%# String.Format("{0:P2}", Eval("ChurchTax"))%>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Begravningsavgift:</td>
                                    <td>
                                        <asp:Label id="lblFuneralTax" runat="server" Text='<%# String.Format("{0:P2}", Eval("FuneralTax")) %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ItemTemplate>

                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />

                </asp:FormView>
                <br/>


                Medlem i svenska kyrkan:<br/>
                <asp:RadioButtonList ID="rdChruch" RepeatDirection="Horizontal" runat="server">
                    <asp:ListItem Selected="True" Text="Ja" value="Yes">
                    </asp:ListItem>
                    <asp:ListItem Selected="False" Text="Nej" value="No">
                    </asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="btnCalc" OnClick="btnCalc_OnClick" runat="server" Text="Beräkna" ValidationGroup="taxGroup"></asp:Button>
                <asp:Button ID="btnAdd" OnClick="btnAdd_OnClick" runat="server" Text="Lägg till ny kommun"></asp:Button>
                <asp:Button ID="btnEdit" OnClick="btnEdit_OnClick" runat="server" Text="Redigera kommun"></asp:Button>


            </div>
        </form>
    </body>
</html>