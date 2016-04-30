<%@ Page Title="Cheap Hotels - High Quality" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspHotelBook._default" %>

<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">

    <script>


    
    </script>
</asp:Content>

<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <!-- Needed for no postback while using Calendar -->
    <asp:ScriptManager EnablePartialRendering="True"
                       runat="server">
    </asp:ScriptManager>
    <!-- End of ScriptManager -->

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

            <div class="col-md-4">
                <div class="fadeInUp hi-icon-effect hi-icon-wrap wow">
                    <label for="checkInDate"
                           style="color: black">
                        Check in
                    </label>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>

                            <asp:Calendar BackColor="LightGrey"
                                          BorderColor="Black"
                                          BorderStyle="Solid"
                                          CellSpacing="1"
                                          Font-Names="Verdana"
                                          Font-Size="9pt"
                                          ForeColor="Black"
                                          Height="250px"
                                          ID="checkInDate"
                                          NextPrevFormat="ShortMonth"
                                          runat="server"
                                          SelectionMode="Day"
                                          Width="250px">
                                <SelectedDayStyle BackColor="White"
                                                  ForeColor="Red"/>
                                <DayStyle BackColor="#1BBD36"
                                          Font-Bold="True"
                                          ForeColor="White"/>
                                <NextPrevStyle Font-Bold="True"
                                               Font-Size="8pt"
                                               ForeColor="White"/>
                                <DayHeaderStyle Font-Bold="True"
                                                Font-Size="8pt"
                                                ForeColor="#333333"
                                                Height="8pt"/>
                                <TitleStyle BackColor="Firebrick"
                                            BorderStyle="None"
                                            Font-Bold="True"
                                            Font-Size="12pt"
                                            ForeColor="white"
                                            Height="12pt"/>
                                <OtherMonthDayStyle BackColor="NavajoWhite"
                                                    Font-Bold="False"
                                                    ForeColor="Black"/>

                            </asp:Calendar>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <div class="col-md-4">
                <div class="fadeInUp hi-icon-effect hi-icon-wrap wow">
                    <label for="checkOutDate"
                           style="color: Black">
                        How many days?
                    </label>
                    <asp:DropDownList ID="ddlDaysToStay" ForeColor="Black" Width="50px" runat="server">
                        <asp:ListItem Text="1" Value="1"/>
                        <asp:ListItem Text="2" Value="2"/>
                        <asp:ListItem Text="3" Value="3"/>
                        <asp:ListItem Text="4" Value="4"/>
                        <asp:ListItem Text="5" Value="5"/>
                        <asp:ListItem Text="6" Value="6"/>
                        <asp:ListItem Text="7" Value="7"/>
                    </asp:DropDownList>
                  <%--  <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:Calendar BackColor="LightGrey"
                                          BorderColor="Black"
                                          BorderStyle="Solid"
                                          CellSpacing="1"
                                          Font-Names="Verdana"
                                          Font-Size="9pt"
                                          ForeColor="Black"
                                          Height="250px"
                                          ID="checkOutDate"
                                          NextPrevFormat="ShortMonth"
                                          runat="server"
                                          SelectionMode="Day"
                                          Width="250px" OnSelectionChanged="checkOutDate_OnSelectionChanged">
                                <SelectedDayStyle BackColor="White"
                                                  ForeColor="Red"/>
                                <DayStyle BackColor="#1BBD36"
                                          Font-Bold="True"
                                          ForeColor="White"/>
                                <NextPrevStyle Font-Bold="True"
                                               Font-Size="8pt"
                                               ForeColor="White"/>
                                <DayHeaderStyle Font-Bold="True"
                                                Font-Size="8pt"
                                                ForeColor="#333333"
                                                Height="8pt"/>
                                <TitleStyle BackColor="Firebrick"
                                            BorderStyle="None"
                                            Font-Bold="True"
                                            Font-Size="12pt"
                                            ForeColor="white"
                                            Height="12pt"/>
                                <OtherMonthDayStyle BackColor="NavajoWhite"
                                                    Font-Bold="False"
                                                    ForeColor="Black"/>

                            </asp:Calendar>
                        </ContentTemplate>
                    </asp:UpdatePanel>--%>
                    <br/>
                     <label for="ddlGrownUps"
                           style="color: black">
                        Adults
                    </label>
                    <asp:DropDownList ForeColor="Black"
                                      ID="ddlGrownUps"
                                      runat="server"
                                      Width="50px">
                        <asp:ListItem Enabled="True"
                                      Text="1"
                                      Value="1">
                        </asp:ListItem>
                        <asp:ListItem Text="2"
                                      Value="2">
                        </asp:ListItem>

                    </asp:DropDownList>
                    <br/>

                    <label for="ddlChildren"
                           style="color: black">
                        Children
                    </label>
                    <asp:DropDownList ForeColor="Black"
                                      ID="ddlChildren"
                                      runat="server"
                                      Width="50px">
                        <asp:ListItem Enabled="True" Text="0" Value="0"></asp:ListItem>
                        <asp:ListItem
                                      Text="1"
                                      Value="1">
                        </asp:ListItem>
                        <asp:ListItem Text="2"
                                      Value="2">
                        </asp:ListItem>

                    </asp:DropDownList>
                    <br/>

                    <asp:Button runat="server"
                                ID="btnSearchForHotels"
                                Text="Search for hotels!" ForeColor="black" OnClick="btnSearchForHotels_OnClick"/>

                </div>
            </div>
            
            <div class="col-md-4">
                <div class="fadeInUp hi-icon-effect hi-icon-wrap wow">
                    

                </div>
            </div>
        </div>
    </div>

<div class="aboutus"
     id="about">
    <div class="container">
        <div class="col-md-6">
            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name of Lorem Ipsum decided to leave for the far World of Grammar. The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove, the headline of Alphabet Village and the subline of her own road, the Line Lane. Pityful a rethoric question ran over her cheek, then</p>
        </div>
    </div>
</div>

</asp:Content>

<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">

</asp:Content>