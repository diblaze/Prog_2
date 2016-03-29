<%@ Page Title="Management page" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="aspHotelBook.adminPages.manage" %>
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
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
                       ID="sqlRoles"
                       runat="server"
                       SelectCommand="SELECT [Name] FROM [AspNetRoles]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
                       ID="sqlUsers"
                       runat="server"
                       SelectCommand="SELECT [UserName] FROM [AspNetUsers] ORDER BY [UserName]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       ID="sqlBookings"
                       runat="server"
                       SelectCommand="SELECT * FROM [Bookings]" DeleteCommand="DELETE FROM [Bookings] WHERE [Id] = @Id" 
        InsertCommand="INSERT INTO [Bookings] ([HotelName], [RoomNr], [CheckedIn], [CheckingOut], [NameOfBook], [Telephone], [Account]) VALUES (@HotelName, @RoomNr, @CheckedIn, @CheckingOut, @NameOfBook, @Telephone, @Account)" UpdateCommand="UPDATE [Bookings] SET [HotelName] = @HotelName, [RoomNr] = @RoomNr, [CheckedIn] = @CheckedIn, [CheckingOut] = @CheckingOut, [NameOfBook] = @NameOfBook, [Telephone] = @Telephone, [Account] = @Account WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="HotelName" Type="String" />
            <asp:Parameter Name="RoomNr" Type="Int32" />
            <asp:Parameter Name="CheckedIn" Type="DateTime" />
            <asp:Parameter Name="CheckingOut" Type="DateTime" />
            <asp:Parameter Name="NameOfBook" Type="String" />
            <asp:Parameter Name="Telephone" Type="String" />
            <asp:Parameter Name="Account" Type="String" />
        </InsertParameters>
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

    <asp:SqlDataSource ID="sqlRooms" runat="server" ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>" DeleteCommand="DELETE FROM [Rooms] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Rooms] ([HotelName], [RoomNr], [Adults], [Children], [TV], [AC], [RoomService], [SuiteType], [PricePerDay], [Image]) VALUES (@HotelName, @RoomNr, @Adults, @Children, @TV, @AC, @RoomService, @SuiteType, @PricePerDay, @Image)" SelectCommand="SELECT * FROM [Rooms]" UpdateCommand="UPDATE [Rooms] SET [HotelName] = @HotelName, [RoomNr] = @RoomNr, [Adults] = @Adults, [Children] = @Children, [TV] = @TV, [AC] = @AC, [RoomService] = @RoomService, [SuiteType] = @SuiteType, [PricePerDay] = @PricePerDay, [Image] = @Image WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="HotelName" Type="String" />
            <asp:Parameter Name="RoomNr" Type="Int32" />
            <asp:Parameter Name="Adults" Type="Int32" />
            <asp:Parameter Name="Children" Type="Int32" />
            <asp:Parameter Name="TV" Type="Boolean" />
            <asp:Parameter Name="AC" Type="Boolean" />
            <asp:Parameter Name="RoomService" Type="Boolean" />
            <asp:Parameter Name="SuiteType" Type="Int32" />
            <asp:Parameter Name="PricePerDay" Type="Int32" />
            <asp:Parameter Name="Image" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="HotelName" Type="String" />
            <asp:Parameter Name="RoomNr" Type="Int32" />
            <asp:Parameter Name="Adults" Type="Int32" />
            <asp:Parameter Name="Children" Type="Int32" />
            <asp:Parameter Name="TV" Type="Boolean" />
            <asp:Parameter Name="AC" Type="Boolean" />
            <asp:Parameter Name="RoomService" Type="Boolean" />
            <asp:Parameter Name="SuiteType" Type="Int32" />
            <asp:Parameter Name="PricePerDay" Type="Int32" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


<div class="container"
         style="margin-top: 100px">
        <div class="col-md-6 panel panel-default">
            <div class="panel-heading">
                <h3>Create Roles</h3>
            </div>
            <div class="panel-body">
                <div class="col-md-6 pull-left">
                    <h3>Add a new role</h3>

                    <label for="tbNewRole">Role name</label>
                    <asp:TextBox CssClass="asp-textbox"
                                 ID="tbNewRole"
                                 runat="server"/>
                    <asp:Button CssClass="btn btn-success"
                                ID="btnAddNewRole"
                                OnClick="btnAddNewRole_OnClick"
                                runat="server"
                                Text="Add role"/>
                    <asp:Label ForeColor="Black"
                               ID="lblRoleManager"
                               runat="server">
                    </asp:Label>
                </div>
                <div class="col-md-6 pull-right">
                    <h3>Current roles</h3>
                    <asp:ListBox CssClass="list-box"
                                 DataSourceID="sqlRoles"
                                 DataTextField="Name"
                                 DataValueField="Name"
                                 ID="listBoxAllRoles"
                                 runat="server"/>
                </div>

            </div>

        </div>

        <div class="col-md-6 panel panel-default">
            <div class="panel-heading">
                <h3>Add users to role</h3>
            </div>
            <div class="panel-body">
                <div class="col-md-6 pull-left">
                    <p>Select user from left listbox, then select a role from the right listbox</p>
                    <p>Finish with pressing "Add"</p>

                    <asp:ListBox CssClass="list-box"
                                 DataSourceID="sqlUsers"
                                 DataTextField="UserName"
                                 DataValueField="UserName"
                                 ID="listBoxAllUsers"
                                 runat="server"/>
                    <asp:ListBox CssClass="list-box"
                                 DataSourceID="sqlRoles"
                                 DataTextField="Name"
                                 DataValueField="Name"
                                 ID="listBoxAllRoles2"
                                 runat="server"/>
                    <asp:Button CssClass="btn btn-success"
                                ID="btnAddUserToRole"
                                OnClick="btnAddUserToRole_OnClick"
                                runat="server"
                                Text="Add user"/>
                    <asp:Label ID="lblConfirmationText"
                               runat="server">
                    </asp:Label>
                </div>
            </div>
        </div>

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
                        <AlternatingRowStyle BackColor="White"/>
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True"
                                              ShowEditButton="False"/>
                            <asp:BoundField DataField="RoomNr"
                                            HeaderText="RoomNr"
                                            ReadOnly="True"
                                            SortExpression="RoomNr"/>
                            <asp:BoundField DataField="CheckedIn"
                                            HeaderText="CheckedIn"
                                            ReadOnly="True"
                                            SortExpression="CheckedIn"/>
                            <asp:BoundField DataField="CheckingOut"
                                            HeaderText="CheckingOut"
                                            ReadOnly="True"
                                            SortExpression="CheckingOut"/>
                            <asp:BoundField DataField="NameOfBook"
                                            HeaderText="NameOfBook"
                                            SortExpression="NameOfBook"/>
                            <asp:BoundField DataField="Telephone"
                                            HeaderText="Telephone"
                                            SortExpression="Telephone"/>
                            <asp:BoundField DataField="Account"
                                            HeaderText="Account"
                                            ReadOnly="True"
                                            SortExpression="Account"/>
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57"
                                      CssClass="btn btn-sucess "/>
                        <FooterStyle BackColor="#1C5E55"
                                     Font-Bold="True"
                                     ForeColor="White"/>
                        <HeaderStyle BackColor="#1C5E55"
                                     Font-Bold="True"
                                     ForeColor="White"/>
                        <PagerStyle BackColor="#666666"
                                    ForeColor="White"
                                    HorizontalAlign="Center"/>
                        <RowStyle BackColor="#E3EAEB"/>
                        <SelectedRowStyle BackColor="#C5BBAF"
                                          Font-Bold="True"
                                          ForeColor="#333333"/>
                        <SortedAscendingCellStyle BackColor="#F8FAFA"/>
                        <SortedAscendingHeaderStyle BackColor="#246B61"/>
                        <SortedDescendingCellStyle BackColor="#D4DFE1"/>
                        <SortedDescendingHeaderStyle BackColor="#15524A"/>
                    </asp:GridView>
                    
                    
                </div>
                <div class="col-md-4 pull-right">
                    <p class="text-primary pull-right" style="font-size: medium">To add a new booking, go to the booking page and follow the same steps as a customer. In the end you'll get the option to book it for a customer.</p>
                </div>
            </div>
        </div>

        <div class="col-md-6 panel panel-default">
            <div class="panel-heading">
                <h3>Add new rooms</h3>
            </div>
            <div class="panel-body">
                <fieldset>
            <div class="control-group">
                <!-- Room Number -->
                <label class="control-label"
                       for="tbRoomNumber">
                    Room number
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbRoomNumber"
                                 runat="server"
                                 ForeColor="Black"
                        TextMode="Number"
                        Text="0"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbRoomNumber"></asp:RequiredFieldValidator>
                    <p class="help-block">Only numbers!</p>
                </div>
            </div>

            <div class="control-group">
                <!-- Adults -->
                <label class="control-label"
                       for="tbAdults">
                    Max number of Adults
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbAdults"
                                 runat="server"
                                 ForeColor="Black"
                                 TextMode="Number"
                        Text="1"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbAdults"></asp:RequiredFieldValidator>
                    <p class="help-block">How many adults be maximum in the room?</p>
                </div>
            </div>

            <div class="control-group">
                <!-- Children -->
                <label class="control-label"
                       for="tbChildren">
                    Children
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbChildren"
                                 runat="server"
                                 TextMode="Number" Text="0" ForeColor="Black"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbChildren"></asp:RequiredFieldValidator>
                    <p class="help-block">How many children can be maximum in the room?</p>
                </div>
            </div>

                    <div class="control-group">
                        <!-- TV -->
                        <label class="control-label"
                               for="cbTv">
                            TV
                        </label>
                        <div class="controls">
                            <asp:CheckBox CssClass="input-xlarge"
                                          ID="cbTv"
                                          runat="server"
                                          ForeColor="Black"
                                          />

                            <p class="help-block">TV available?</p>

                        </div>
                    </div>

                    
            <div class="control-group">
                <!-- AC -->
                <label class="control-label"
                       for="cbAc">
                    TV
                </label>
                <div class="controls">
                    <asp:CheckBox CssClass="input-xlarge"
                                 ID="cbAc"
                                 runat="server"
                                 ForeColor="Black" />
                    
                    <p class="help-block">AC available?</p>
                   
                </div>
            </div>

                    <div class="control-group">
                        <!-- Room Service -->
                        <label class="control-label"
                               for="cbRoomService">
                            Room Service
                        </label>
                        <div class="controls">
                            <asp:CheckBox CssClass="input-xlarge"
                                          ID="cbRoomService"
                                          runat="server"
                                          ForeColor="Black"
                                          />

                            <p class="help-block">Room service available?</p>

                        </div>
                    </div>
                    
            <div class="control-group">
                <!-- Suite Type -->
                <label class="control-label"
                       for="ddlSuiteType">
                    Suite type
                </label>
                <div class="controls">
                    <asp:DropDownList CssClass="input-xlarge"
                                      ID="ddlSuiteType"
                                      runat="server"
                                      ForeColor="Black">
                        <asp:ListItem Value="0">Standard</asp:ListItem>
                        <asp:ListItem Value="1">High-End</asp:ListItem>
                        <asp:ListItem Value="2">Luxuary</asp:ListItem>
                    </asp:DropDownList>
                    
                    <p class="help-block">Specify the suite type.</p>
                   
                </div>
            </div>
                    <div class="control-group">
                        <!-- Price per day-->
                        <label class="control-label"
                               for="tbRate">
                            Price per day
                        </label>
                        <div class="controls">
                            <asp:TextBox CssClass="input-xlarge"
                                         ID="tbRate"
                                         runat="server"
                                         ForeColor="Black"
                                         TextMode="Number"
                                Text="200">

                            </asp:TextBox>

                            <p class="help-block">Specify the price per day.</p>

                        </div>
                    </div>
                    


                    <div class="control-group">
                <!-- Button -->
                <div class="controls" style="margin-top: 10px">
                    <asp:Button CssClass="btn btn-success"
                                OnClick="btnAddRoom_OnClick"
                                runat="server"
                                Text="Add new room"
                        ValidationGroup="validationGroup"/>
                </div>
            </div>

            
            <div class="control-group">
                <!-- Confirmaton Label-->
                <div class="controls">
                    <asp:Label runat="server"
                               CssClass="control-label"
                               ID="lblAddRoomConfirmationText"/>
                    </div>
                
            </div>
        </fieldset>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">
</asp:Content>