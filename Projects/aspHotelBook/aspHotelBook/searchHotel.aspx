<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchHotel.aspx.cs" Inherits="aspHotelBook.searchHotel" MasterPageFile="Master.Master" Title="Search Rooms" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             runat="server">

    <style>
        td { color: black; }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="BodyContent"
             runat="server">
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       ID="sqlHotels"
                       runat="server"
                       SelectCommand="SELECT * FROM [Rooms] ORDER BY [PricePerDay] DESC">
    </asp:SqlDataSource>
    <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:SqlHotelsString %>"
                       ID="sqlBookings"
                       runat="server"
                       SelectCommand="SELECT * FROM [Bookings]">
    </asp:SqlDataSource>

    <div class="jumbotron text-center"
         style="margin-top: 20px">
        <h1>Avilable Rooms</h1>
        <p class="lead">To specify your options, use the menu to the left!</p>
    </div>
    <div class="navbar navbar-default navbar-left"
         style="margin: 10px; padding-right: 10px; padding-top: 10px;">
        <ul>
            <li>
                <label class="text-info"
                       for="btnAllRoomTypes">
                    Room Type:
                </label>
                <ul>
                    <li>
                        <asp:Button CssClass="btn btn-info"
                                    ID="btnAllRoomTypes"
                                    OnClick="ChangeRoomType"
                                    runat="server"
                                    Text="All room types"/>
                    </li>

                    <li>
                        <asp:Button CssClass="btn btn-info"
                                    ID="btnStandardRoomType"
                                    OnClick="ChangeRoomType"
                                    runat="server"
                                    Text="Standard"/>
                    </li>
                    <li>
                        <asp:Button CssClass="btn btn-info"
                                    ID="btnHighEndRoomType"
                                    OnClick="ChangeRoomType"
                                    runat="server"
                                    Text="High-End"/>
                    </li>
                    <li>
                        <asp:Button CssClass="btn btn-info"
                                    ID="btnLuxuaryRoomType"
                                    OnClick="ChangeRoomType"
                                    runat="server"
                                    Text="Luxuary"/>
                    </li>
                </ul>

            </li>
        </ul>
    </div>
    <div class="container">
        <asp:Repeater DataSourceID="sqlHotels"
                      runat="server">
            <ItemTemplate>
                <div class="col-md-8 panel panel-default">
                    <div class="panel-heading">
                        <h4>

                            <asp:Button CommandArgument='<%# Eval("RoomNr") %>'
                                        CssClass="btn btn-success"
                                        ID="btnBook"
                                        OnClick="BookRoom_Click"

                                        runat="server"
                                        Text="Book room at Sandy Beach Hotel"/>
                        </h4>
                    </div>
                    <div class="panel-body">
                        <img class="col-md-6 pull-left"
                             src='<%# "images/rooms/" + Eval("image") + ".jpg" %>'/>
                        <div class="col-md-6 media pull-right">
                            <table>
                                <h1 style="color: black"><%# WhatRoomType(Eval("SuiteType")) + " Room" + " : Room number " + Eval("RoomNr") %></h1>
                                <tr>
                                    <td>Max Adults:</td>
                                    <td><%#Eval("Adults") %></td>
                                </tr>
                                <tr>
                                    <td>Max Children:</td>
                                    <td><%# Eval("Children") %></td>
                                </tr>

                                <tr>
                                    <td>TV:</td>
                                    <td><%# (bool) Eval("TV") ? "Yes" : "No" %></td>
                                </tr>
                                <tr>
                                    <td>AC:</td>
                                    <td><%# (bool) Eval("AC") ? "Yes" : "No" %></td>
                                </tr>

                                <tr>
                                    <td>Rate:</td>
                                    <td><%# Eval("PricePerDay") %> USD</td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>