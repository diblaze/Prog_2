<%@ Page Title="Login to your account" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="aspHotelBook.account.login" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
    
    <style>
        label {
            color: Grey;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">

    <div class="container"
         style="margin-bottom: 20px; margin-top: 100px;">
        <fieldset>
            <div id="legend">
                <legend>Log In</legend>
            </div>
            <div class="control-group">
                <!-- Username -->
                <label class="control-label"
                       for="tbUsername">
                    Username
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ForeColor="Black"
                                 ID="tbUsername"
                                 runat="server"/>
                    <asp:RequiredFieldValidator ControlToValidate="tbUsername"
                                                ForeColor="Red"
                                                runat="server"
                                                Text="*"
                                                ValidationGroup="validationGroup">
                    </asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="control-group">
                <!-- Password-->
                <label class="control-label"
                       for="tbPassword">
                    Password
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ForeColor="Black"
                                 ID="tbPassword"
                                 runat="server"
                                 TextMode="Password"/>
                    <asp:RequiredFieldValidator ControlToValidate="tbPassword"
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
                                OnClick="SignIn"
                                runat="server"
                                Text="Login"
                                ValidationGroup="validationGroup"/>
                </div>
            </div>

                      
            <div class="control-group">
                <!-- Confirmaton Label-->
                <div class="controls">
                    <asp:Label runat="server"
                               CssClass="control-label"
                               ID="lblConfirmationText"/>
                    </div>
                
            </div>
        </fieldset>
    </div>

</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">
</asp:Content>