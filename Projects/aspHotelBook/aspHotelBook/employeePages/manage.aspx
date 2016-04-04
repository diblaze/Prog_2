<%@ Page Title="Management page" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="aspHotelBook.employeePages.manage" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
    <style>
        label { color: grey; }

        .list-box { color: black; }

        .asp-textbox { color: black; }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       ID="sqlBookings"
                       runat="server"
                       SelectCommand="SELECT * FROM [Bookings]" DeleteCommand="DELETE FROM [Bookings] WHERE [Id] = @Id" 
        UpdateCommand="UPDATE [Bookings] SET [HotelName] = @HotelName, [RoomNr] = @RoomNr, [CheckedIn] = @CheckedIn, [CheckingOut] = @CheckingOut, [NameOfBook] = @NameOfBook, [Telephone] = @Telephone, [Account] = @Account WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="HotelName" Type="String" />
            <asp:Parameter Name="RoomNr" Type="Int32" />
            <asp:Parameter Name="CheckedIn" Type="DateTime" />
            <asp:Parameter Name="CheckingOut" Type="DateTime" />
            <asp:Parameter Name="NameOfBook" Type="String" />
            <asp:Parameter Name="Telephone" Type="String" />
            <asp:Parameter Name="Account" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


    <div class="container"
         style="margin-top: 100px">


        <!-- Start Manage Bookings -->
        <div class="col-md-12 panel panel-default">
            <div class="panel-heading">
                <h3>Manage bookings</h3>
            </div>
            <div class="panel-body">
                <div class="col-md-8">
                    <asp:GridView runat="server"
                                  DataSourceID="sqlBookings"
                                  ID="gvBookings"
                                  AllowPaging="True"
                                  AllowSorting="True"
                                  CellPadding="4"
                                  ForeColor="#333333"
                                  GridLines="None"
                                  AutoGenerateColumns="False"
                                  DataKeyNames="Id">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True"
                                              ShowEditButton="False" />
                            <asp:BoundField DataField="RoomNr"
                                            HeaderText="RoomNr"
                                            ReadOnly="True"
                                            SortExpression="RoomNr" />
                            <asp:BoundField DataField="CheckedIn"
                                            HeaderText="CheckedIn"
                                            ReadOnly="True"
                                            SortExpression="CheckedIn" />
                            <asp:BoundField DataField="CheckingOut"
                                            HeaderText="CheckingOut"
                                            ReadOnly="True"
                                            SortExpression="CheckingOut" />
                            <asp:BoundField DataField="NameOfBook"
                                            HeaderText="NameOfBook"
                                            SortExpression="NameOfBook" />
                            <asp:BoundField DataField="Telephone"
                                            HeaderText="Telephone"
                                            SortExpression="Telephone" />
                            <asp:BoundField DataField="Account"
                                            HeaderText="Account"
                                            ReadOnly="True"
                                            SortExpression="Account" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57"
                                      CssClass="btn btn-sucess " />
                        <FooterStyle BackColor="#1C5E55"
                                     Font-Bold="True"
                                     ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55"
                                     Font-Bold="True"
                                     ForeColor="White" />
                        <PagerStyle BackColor="#666666"
                                    ForeColor="White"
                                    HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF"
                                          Font-Bold="True"
                                          ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>


                </div>
                <div class="col-md-4 pull-right">
                    <p class="text-primary pull-right"
                       style="font-size: medium">To add a new booking, go to the booking page and follow the same steps as a customer. In the end you'll get the option to book it for a customer.</p>
                </div>
            </div>
        </div>
        <!-- / Start Manage Bookings -->

    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">
</asp:Content>