<%@ Page Title="Register an account" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="aspHotelBook.account.register" %>
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
                <legend class="">Register</legend>
            </div>
            <div class="control-group">
                <!-- Username -->
                <label class="control-label"
                       for="tbUsername">
                    Username
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbUsername"
                                 runat="server"
                                 ForeColor="Black"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbUsername"></asp:RequiredFieldValidator>
                    <p class="help-block">Username can contain any letters or numbers, without spaces</p>
                </div>
            </div>

            <div class="control-group">
                <!-- E-mail -->
                <label class="control-label"
                       for="tbEmail">
                    E-mail
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbEmail"
                                 runat="server"
                                 ForeColor="Black"
                                 TextMode="Email"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
                    <p class="help-block">Please provide your E-mail</p>
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
                                 ID="tbPassword"
                                 runat="server"
                                 TextMode="Password" ForeColor="Black"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
                    <p class="help-block">Password should be at least 7 characters and have at least one non-alphanumeric character!</p>
                </div>
            </div>

            <div class="control-group">
                <!-- Password -->
                <label class="control-label"
                       for="tbPasswordConfirm">
                    Password (Confirm)
                </label>
                <div class="controls">
                    <asp:TextBox CssClass="input-xlarge"
                                 ID="tbPasswordConfirm"
                                 runat="server"
                                 TextMode="Password"
                                 ForeColor="Black"/>
                    <asp:RequiredFieldValidator runat="server" ForeColor="Red" Text="*" ValidationGroup="validationGroup" ControlToValidate="tbPasswordConfirm"></asp:RequiredFieldValidator>
                    <p class="help-block">Please confirm password</p>
                    <asp:CompareValidator runat="server"
                                          ID="ComparePassword"
                                          ControlToCompare="tbPassword"
                                          ControlToValidate="tbPasswordConfirm"
                                          CssClass="has-error"
                                          ErrorMessage="Passwords do not match!"
                                          ForeColor="Red"
                                          ToolTip="Passwords must be the same."/>
                    
                </div>
            </div>

            <div class="control-group">
                <!-- Button -->
                <div class="controls" style="margin-top: 10px">
                    <asp:Button CssClass="btn btn-success"
                                OnClick="RegisterUser"
                                runat="server"
                                Text="Register"
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