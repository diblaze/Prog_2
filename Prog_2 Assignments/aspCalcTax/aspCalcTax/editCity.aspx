<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editCity.aspx.cs" Inherits="aspCalcTax.editCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>

        <!--DataSource start-->
        <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                           DeleteCommand="DELETE FROM [Taxes] WHERE [Id] = @Id"
                           ID="dsCities"
                           InsertCommand="INSERT INTO [Taxes] ([City], [LocalTax], [ChurchTax], [FuneralTax]) VALUES (@City, @LocalTax, @ChurchTax, @FuneralTax)"
                           runat="server"
                           SelectCommand="SELECT * FROM [Taxes]"
                           UpdateCommand="UPDATE [Taxes] SET [City] = @City, [LocalTax] = @LocalTax, [ChurchTax] = @ChurchTax, [FuneralTax] = @FuneralTax WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id"
                               Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="City"
                               Type="String" />
                <asp:Parameter Name="LocalTax"
                               Type="Double" />
                <asp:Parameter Name="ChurchTax"
                               Type="Double" />
                <asp:Parameter Name="FuneralTax"
                               Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="City"
                               Type="String" />
                <asp:Parameter Name="LocalTax"
                               Type="Double" />
                <asp:Parameter Name="ChurchTax"
                               Type="Double" />
                <asp:Parameter Name="FuneralTax"
                               Type="Double" />
                <asp:Parameter Name="Id"
                               Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <!--DataSource end -->

        <form id="form1"
              runat="server">
            <h1>Ändra kommun</h1>
            <table>
                <tr>
                    <td>
                        <asp:GridView AllowPaging="True"
                                      AllowSorting="True"
                                      AutoGenerateColumns="False"
                                      DataKeyNames="Id"
                                      DataSourceID="dsCities"
                                      ID="gvCities"
                                      runat="server">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True"
                                                  ShowEditButton="True" />
                                <asp:BoundField DataField="Id"
                                                HeaderText="Id"
                                                InsertVisible="False"
                                                ReadOnly="True"
                                                SortExpression="Id" />
                                <asp:BoundField DataField="City"
                                                HeaderText="City"
                                                SortExpression="City" />
                                <asp:BoundField DataField="LocalTax"
                                                HeaderText="LocalTax"
                                                SortExpression="LocalTax" />
                                <asp:BoundField DataField="ChurchTax"
                                                HeaderText="ChurchTax"
                                                SortExpression="ChurchTax" />
                                <asp:BoundField DataField="FuneralTax"
                                                HeaderText="FuneralTax"
                                                SortExpression="FuneralTax" />
                            </Columns>

                        </asp:GridView>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnExit"
                                    OnClick="btnExit_OnClick"
                                    runat="server"
                                    Text="Tillbaka" />
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>