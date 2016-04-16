<%@ Page Title="Finalizing Booking" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="True" CodeBehind="booking.aspx.cs" Inherits="aspHotelBook.booking" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">

    <style>
        label { color: Grey; }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       ID="sqlHotels"
                       runat="server"
                       SelectCommand="SELECT * FROM [Rooms]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       DeleteCommand="DELETE FROM [Bookings] WHERE [Id] = @Id"
                       ID="sqlBookings"
                       InsertCommand="INSERT INTO [Bookings] ([HotelName], [RoomNr], [CheckedIn], [CheckingOut], [NameOfBook], [Telephone], [Account]) VALUES (@HotelName, @RoomNr, @CheckedIn, @CheckingOut, @NameOfBook, @Telephone, @Account)"
                       runat="server"
                       SelectCommand="SELECT * FROM [Bookings]"
                       UpdateCommand="UPDATE [Bookings] SET [HotelName] = @HotelName, [RoomNr] = @RoomNr, [CheckedIn] = @CheckedIn, [CheckingOut] = @CheckingOut, [NameOfBook] = @NameOfBook, [Telephone] = @Telephone, [Account] = @Account WHERE [Id] = @Id">
        <InsertParameters>
            <asp:Parameter Name="HotelName"
                           Type="String"/>
            <asp:Parameter Name="RoomNr"
                           Type="Int32"/>
            <asp:Parameter Name="CheckedIn"
                           Type="DateTime"/>
            <asp:Parameter Name="CheckingOut"
                           Type="DateTime"/>
            <asp:Parameter Name="NameOfBook"
                           Type="String"/>
            <asp:Parameter Name="Telephone"
                           Type="String"/>
            <asp:Parameter Name="Account"
                           Type="String"/>
        </InsertParameters>
    </asp:SqlDataSource>
</asp:Content>

<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">
    <div class="jumbotron text-center">
        <asp:LoginView id="lvStatus"
                       runat="server">
            <AnonymousTemplate>
                <h1 style="color: black">Please log in or register before finalizing your booking!</h1>
                <p>
                    <a href="./account/register.aspx">
                        <span class="fa fa-pencil">Register an account</span>
                    </a>
                    <a href="./account/login.aspx">
                        <span class="fa fa-user"/>Login
                    </a>
                </p>
                <p>

                </p>

            </AnonymousTemplate>

        </asp:LoginView>

        <asp:LoginView ID="lvManage"
                       runat="server"
                       Visible="False">
            <LoggedInTemplate>
                <div class="col-md-12 panel panel-default">
                    <div class="panel-heading">To book this for a customer, fill in the requried info below</div>
                    <div class="panel-body">
                        <fieldset>
                        <div id="legend">
                            <legend>Book</legend>
                        </div>
                        <div class="control-group">
                            <!-- Name -->
                            <label class="control-label"
                                   for="tbFullName">
                                Full name of booker
                            </label>
                            <div class="controls">
                                <asp:TextBox CssClass="input-xlarge"
                                             ForeColor="Black"
                                             ID="tbFullName"
                                             runat="server"/>
                                <asp:RequiredFieldValidator ControlToValidate="tbFullName"
                                                            ForeColor="Red"
                                                            runat="server"
                                                            Text="*"
                                                            ValidationGroup="validationGroup">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="control-group">
                            <!-- Username -->
                            <label class="control-label"
                                   for="tbUserName">
                                Username of booker (Not needed)
                            </label>
                            <div class="controls">
                                <asp:TextBox CssClass="input-xlarge"
                                             ForeColor="Black"
                                             ID="tbUserName"
                                             runat="server"/>
                                <%--                                        <asp:RequiredFieldValidator ControlToValidate="tbUsername"
                                                                    ForeColor="Red"
                                                                    runat="server"
                                                                    Text="*"
                                                                    ValidationGroup="validationGroup">
                                        </asp:RequiredFieldValidator>--%>
                            </div>
                        </div>

                        <div class="control-group">
                            <!-- Telephone -->
                            <label class="control-label"
                                   for="tbTelephone">
                                Telephone of booker
                            </label>
                            <div class="controls">
                                <asp:TextBox CssClass="input-xlarge"
                                             ForeColor="Black"
                                             ID="tbTelephone"
                                             runat="server"
                                             TextMode="Phone"/>

                                <asp:RequiredFieldValidator ControlToValidate="tbTelephone"
                                                            ForeColor="Red"
                                                            runat="server"
                                                            Text="*"
                                                            ValidationGroup="validationGroup">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="control-group">
                            <!-- Button -->
                            <div class="controls"
                                 style="margin-top: 10px">
                                <asp:Button CssClass="btn btn-success"
                                            OnClick="BookRoomForUser"
                                            runat="server"
                                            Text="Book this room for user"
                                            ValidationGroup="validationGroup"/>
                            </div>
                        </div>

                    </div>

                    </fieldset>
                </div>
            </LoggedInTemplate>

        </asp:LoginView>

        <asp:LoginView ID="lvCustomer"
                       runat="server"
                       Visible="False">
            <LoggedInTemplate>
                <div class="col-md-12 panel panel-default">
                    <div class="panel-heading">
                        To finalize this booking, fill in the full name of the one who's going to stay at the hotel
                    </div>
                    <div class="panel-body">
                        <fieldset>
                        <div id="legend">
                            <legend>Book</legend>
                        </div>
                        <div class="control-group">
                            <!-- Name -->
                            <label class="control-label"
                                   for="tbFullName">
                                Full name of booker
                            </label>
                            <div class="controls">
                                <asp:TextBox CssClass="input-xlarge"
                                             ForeColor="Black"
                                             ID="tbFullName"
                                             runat="server"/>
                                <asp:RequiredFieldValidator ControlToValidate="tbFullName"
                                                            ForeColor="Red"
                                                            runat="server"
                                                            Text="*"
                                                            ValidationGroup="validationGroup">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                            
                        <div class="control-group">
                            <!-- Telephone -->
                            <label class="control-label"
                                   for="tbTelephone">
                                Telephone of booker
                            </label>
                            <div class="controls">
                                <asp:TextBox CssClass="input-xlarge"
                                             ForeColor="Black"
                                             ID="tbTelephone"
                                             runat="server"
                                             TextMode="Phone"/>

                                <asp:RequiredFieldValidator ControlToValidate="tbTelephone"
                                                            ForeColor="Red"
                                                            runat="server"
                                                            Text="*"
                                                            ValidationGroup="validationGroup">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="control-group">
                            <!-- Button -->
                            <div class="controls"
                                 style="margin-top: 10px">
                                <asp:Button CssClass="btn btn-success"
                                            OnClick="BookRoom"
                                            runat="server"
                                            Text="Book this room"
                                            ValidationGroup="validationGroup"/>
                            </div>
                        </div>

                    </div>
                    </fieldset>
                </div>
            </LoggedInTemplate>

        </asp:LoginView>

        <div class="control-group">
            <!-- Telephone -->
            <asp:Label runat="server" CssClass="control-label"
                   id="lblMessage"></asp:Label>

            
        </div>

    </div>
</asp:Content>