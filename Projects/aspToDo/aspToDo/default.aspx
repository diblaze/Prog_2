<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspToDo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>ASP.NET: ToDo Main Page</title>
<link href="Content/bootstrap.css"
      rel="stylesheet"/>
<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/jquery-2.1.4.js"></script>

<style type="text/css">
    .col-centered
        {
        float: none;
        margin: 0 auto;
        }
</style>
</head>
<body>
<asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                   ID="sdsTodo"
                   runat="server"
                   SelectCommand="SELECT * FROM [Todo] WHERE ([Finished] = @Finished) ORDER BY [Priority] DESC, [Enddate]"
                   UpdateCommand="UPDATE [Todo] SET [Finished] = @FinishedTick WHERE [Id] = @Id">
    <SelectParameters>
        <asp:Parameter DefaultValue="False"
                       Name="Finished"
                       Type="Boolean"/>
    </SelectParameters>
</asp:SqlDataSource>

<form id="form1"
      runat="server">
    <div class="col-centered col-lg-6">
        <div class="page-header text-center">
            <h1>ASP.NET: ToDo-list</h1>
            <asp:Button ID="btnAddTodo"
                        OnClick="btnAddTodo_OnClick"
                        runat="server"
                        Text="Add new post"/>
        </div>

        <div class=" col-centered col-lg-4">
            <asp:Repeater DataSourceID="sdsTodo"
                          ID="rContent"
                          runat="server">
                <ItemTemplate>
                    <div class="panel panel-primary">
                        <p class="panel-heading">
                            <asp:CheckBox AutoPostBack="True"
                                          ID="cbFinished"
                                          OnCheckedChanged="cbFinished_OnCheckedChanged"
                                          runat="server"/>
                            <strong><%# Eval( "Title" ) %></strong>
                            <br/>
                            <!-- If no end date is not inputted for current item, then do not show any text -->
                            <strong>
                                <%# Eval( "Enddate", "{0:yyyy-MM-dd}" ) == string.Empty ? "" : "Due: " + Eval( "Enddate", "{0:yyyy-MM-dd}" ) %>
                            </strong>
                        </p>
                        <div class="panel-body">
                            <asp:Literal ID="postedText"
                                         runat="server"
                                         Text='<%# Eval( "Text" ) %>'/>
                            <asp:Literal ID="lId"
                                         runat="server"
                                         Text='<%# Eval( "Id" ) %>'
                                         Visible="False"/>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</form>
</body>
</html>