<%@ Page Title="Management page" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="aspHotelBook.adminPages.manage" %>
<asp:Content ContentPlaceHolderID="HeadContent"
             ID="Content1"
             runat="server">
    <style>
        label { color: grey; }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContent"
             ID="Content2"
             runat="server">
    <asp:SqlDataSource ID="sqlRoles" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Name] FROM [AspNetRoles]"></asp:SqlDataSource>
    <div class="container"
         style="margin-top: 100px">
        <div class="col-md-6 panel panel-default">
            <div class="panel-heading">
                <h3>Manage Roles</h3>
            </div>
            <div class="panel-body">
                <div class="col-md-6 pull-left">
                    <h3>Add a new role</h3>

                    <label for="tbNewRole">Role name</label>
                    <asp:TextBox ID="tbNewRole"
                                 runat="server"/>
                    <asp:Button CssClass="btn btn-success"
                                ID="btnAddNewRole"
                                OnClick="btnAddNewRole_OnClick"
                                runat="server"
                                Text="Add role"/>
                    <asp:Label runat="server"
                               ID="lblRoleManager"
                               ForeColor="Black"></asp:Label>
                </div>
                <div class="col-md-6 pull-right">
                    <h3>Current roles</h3>
                    <asp:ListBox runat="server"
                                 ID="listBoxAllRoles" DataSourceID="sqlRoles" DataTextField="Name" DataValueField="Name"/>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
<asp:Content ContentPlaceHolderID="ScriptContent"
             ID="Content3"
             runat="server">
</asp:Content>