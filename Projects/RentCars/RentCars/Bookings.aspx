<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Bookings.aspx.cs" Inherits="RentCars.Bookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- datasource  -->
    <asp:SqlDataSource ID="dsVehicles" runat="server"
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [Vehicles] WHERE Model=@model AND Manufacture=@manufacture AND [Type]=@type"
        >
        <SelectParameters>
            <asp:QueryStringParameter Name="model" QueryStringField="Model" DbType="String" />
            <asp:QueryStringParameter Name="manufacture" QueryStringField="Manufacture" DbType="String" />
            <asp:QueryStringParameter Name="type" QueryStringField="Type" DbType="String" />

        </SelectParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource ID="dsBookings" runat="server"
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [Bookings]"
        >
    </asp:SqlDataSource>



    <!-- ----------  -->
    
    <div class =" jumbotron">
        <h1>Boka en bil</h1>
        <p class="lead">Nya välskötta bilar</p>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                Från: <asp:Calendar runat="server"
                                    ID="startDate"
                                     />
                <%--<asp:TextBox runat="server" ID="startDate" TextMode="DateTime"></asp:TextBox>--%>
                Till: <asp:Calendar runat="server"
                                    ID="endDate"
                                    />
                <%--<asp:TextBox runat="server" ID="endDate" TextMode="DateTime"></asp:TextBox>--%>
                <!-- TODO: Add seek button -->
                <asp:Button runat="server"
                            ID="btnSearch"
                            Text="Sök bilar" OnClick="btnSearch_OnClick"/>
            </div>
        </div>
    </div>
    <asp:Repeater runat="server" DataSourceID="dsVehicles" ID="vehiclesRepeater" >
        <ItemTemplate>
            <div class="panel panel-default col-md-6">
                <div class ="panel-heading">
                    <h4><%#Eval("RegNo") %></h4>
                </div>
                <div class="panel-body">
                    <img class="col-md-6 pull-left" src='<%# "_pics/" + Eval("Image") %>' />
                    <div class="col-md-6 pull-right">
                         <table>
                             <tr>
                                 <td>Passagerare: </td>
                                 <td><%#Eval("Passengers") %></td>
                             </tr>
                             <tr>
                                 <td>Pris/dygn: </td>
                                 <td><%#Eval("PricePerDay") %></td>
                             </tr>
                             <tr>
                                 <td>Bränsle: </td>
                                 <td><%#Eval("Fuel") %></td>
                             </tr>
                             <tr>
                                 <asp:Button CssClass="btn-primary" ID="btnBook" runat="server"
                                     Text="Boka" OnClick="btnBook_Click" CommandArgument='<%# Eval("RegNo") %>' />
                                 <!-- TODO: add event for booking -->

                                 

                             </tr>
                         </table>       
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
