<%@ Page Title="Finalizing Booking" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="aspHotelBook.booking" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
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
            <LoggedInTemplate>
                <h1>
                    To finalize this order, please fill out the information below!
                </h1>
                <p>Payment occurs at arrival.</p>

                <ul>
                    <li>
                        <label for="tbName"><span class="glyphicon-user"></span>Name of booker</label>
                        <asp:TextBox ID="tbName"
                                     runat="server"/>
                    </li>
                    <li>
                        <label for="tbTele"><span class="glyphicon-phone"></span>Telephone number</label>
                        <asp:TextBox ID="tbTele"
                                     runat="server"/>
                    </li>
                </ul>
            </LoggedInTemplate>
        </asp:LoginView>
    </div>
</asp:Content>