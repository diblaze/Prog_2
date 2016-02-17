<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentCars.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:SqlDataSource ID="dsVehicles"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT DISTINCT(Model), Manufacture,  Image, Passengers, PricePerDay  FROM [Vehicles] WHERE Type='Car'"
        >
    </asp:SqlDataSource>
    <div class="jumbotron">
        <h1>Våra personbilar!</h1>
        <p class="lead" >Nya välskötta bilar</p>
    </div>
    
    <div>
        <asp:Repeater runat="server" DataSourceID="dsVehicles">
            <ItemTemplate>
                <div class="panel panel-default col-md-6">
                    <div class="panel-heading">
                        <h4><a href='<%# "Bookings.aspx?Type=Car&Manufacture=" + Eval("Manufacture") + "&Model=" + Eval("Model") %>'> <%# Eval("Manufacture") + " " + Eval("Model") %> </a></h4>
                    </div>
                    <div class="panel-body">
                        <img class="col-md-6 pull-left" src='<%# "_pics/" + Eval("Image") %>' />
                        <div class="col-md-6 pull-right">
                            <table>
                                <tr>
                                    <td>Passagerare:</td>
                                    <td><%# Eval("Passengers") %></td>
                                </tr>
                                <tr>
                                    <td>Pris per dygn:</td>
                                    <td><%# Eval("PricePerDay") %></td>
                                </tr>
                            </table>
                        </div>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
