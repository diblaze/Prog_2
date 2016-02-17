<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RentCars._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
        <h1>Välkommen till vår biluthyrning!</h1>
        <p class="lead">Här kan du hyra någon av våra välskötta bilar till vrakpris.</p>
    </div>
    <div class="panel panel-default col-md-6">
        <div class="panel-heading">
            <h4>Personbilar</h4>
        </div>
        <div class="panel-body">
            <a href="Cars.aspx"><img src="_pics/cars.jpg" /> </a>
        </div>
    </div>

    <div class="panel panel-default col-md-6">
        <div class="panel-heading">
            <h4>Minibussar</h4>
        </div>
        <div class="panel-body">
            <a href="#"><img src="_pics/vans.jpg" /> </a>
        </div>
    </div>


</asp:Content>
