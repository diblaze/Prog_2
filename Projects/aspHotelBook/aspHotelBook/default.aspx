<%@ Page Title="cheap hotels, high quality" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspHotelBook._default" %>

<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
    
    <script>



    </script>
</asp:Content>

<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <!-- Slider -->
    <section class="no-margin"
             id="main-slider">
        <!-- Carousel -->
        <div class="carousel slide">
            <!-- Carousel Inner-->
            <div class="carousel-inner">
                <!-- Item -->
                <div class="active item"
                     style="background-image: url(/images/slider/bg1.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h2 class="animated-item-1 animation">Welcome to <span>Atlantic Hotels</span></h2>
                                    <p class="animated-item-2 animation">We strive after low prices, but high quality standards!</p>
                                    <a class="animated-item-3 animation btn-slide"
                                       href="#book">
                                        Book your stay now
                                    </a>
                                    <a class="animated-item-3 animation btn-slide"
                                       href="#about">
                                        Read more!
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End item-->
            </div>
            <!-- End Carousel Inner-->
        </div>
        <!-- End Carousel-->
    </section>
    <!-- End Slider -->

    <div class="about"
         id="book">
        <div class="container">
            <div class="text-center">
                <div class="col-xs-4">
                    <div class="hi-icon-effect wow hi-icon-wrap fadeInUp">
                        
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">

</asp:Content>