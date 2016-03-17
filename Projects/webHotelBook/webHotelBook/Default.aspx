<%@ Page Title="Book cheap hotels" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webHotelBook._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Atlantic Hotels</h1>
        <p class="lead">At Atlantic Hotels you get the best, without the fuss.</p>
        <p><a href="#book" class="btn btn-primary btn-success btn-lg">Book your stay now!&raquo;</a>
        <a href="#about" class="btn btn-primary btn-lg">Learn more about us now!&raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2 id="book">Book your stay right now!</h2>
            <p>
                With our hotels, you will get the cheapest price but with the highest quality standards!
            </p>
            <p>
                <i class="glyphicon-calendar"></i>
                <asp:TextBox runat="server" ReadOnly="True" ID="datePicker"/>
                
            </p>
        </div>
        <div class="col-md-4">
            <h2 id="about">Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
