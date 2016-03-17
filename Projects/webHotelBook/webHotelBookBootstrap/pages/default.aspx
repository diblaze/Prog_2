<%@ Page Title="cheap hotels, high quality" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="webHotelBookBootstrap.pages._default" %>

<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <section class="no-margin"
             id="main-slider">
        <div class="carousel slide">
            <div class="carousel-inner">
                <div class="active item" style="background-color: red">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h2 class="animated-item-1 animation">Welcome to <span>Atlantic Hotels</span></h2>
                                    <p class="animated-item-2 animation">Accusantium doloremque laudantium totam rem aperiam, eaque ipsa...</p>
                                    <a class="animated-item-3 animation btn-slide"
                                       href="#">
                                        Read More
                                    </a>
                                </div>
                            </div>

                            <%--      <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <img src="~/images/slider/img3.png" class="img-responsive">
                                </div>
                            </div>--%>

                        </div>
                    </div>
                </div><!--/.item-->
            </div><!--/.carousel-inner-->
        </div><!--/.carousel-->
    </section><!--/#main-slider-->

</asp:Content>