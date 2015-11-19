<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspToDo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>ASP.NET: ToDo Main Page</title>
<style type="text/css">
    body
        {
        font-family: Arial, Verdana, Sans-Serif;
        margin: 0 auto;
        width: 50%;
        }

    #headerBox
        {
        border-bottom: dashed 1px #0066cc;
        text-align: center;
        }

    #contentTitle
        {
        /*font-family: Arial, Verdana, Sans-Serif;*/
        font-size: 18px;
        /*padding: 10px;*/
        }
    #message
        {
        border-top: dashed 1px;
        border-bottom: dashed 1px;
        padding-top: 10px;
        padding-bottom: 10px;
        }
    #borderStuff
        {
        border-bottom: dashed 1px;
        padding-top: 10px;
        padding-bottom: 10px;
        }
</style>
</head>
<body>
<asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                   ID="sdsTodo"
                   runat="server"
                   SelectCommand="SELECT * FROM [Todo] ORDER BY [Priority] DESC, [Enddate] ASC">
</asp:SqlDataSource>

<form id="form1"
      runat="server">
    <div>
        <div id="headerBox">
            <h1>ToDo-list</h1>
            <br/>
            <asp:Button ID="btnAddTodo"
                        OnClick="btnAddTodo_OnClick"
                        runat="server"/>
        </div>

        <div id="contentBox">
            <asp:Repeater DataSourceID="sdsTodo"
                          ID="rContent"
                          runat="server">
                <ItemTemplate>
                    <div id="contentItem">
                        <p id="contentTitle">
                            Title: <strong><%# Eval( "Title" ) %></strong>
                            <br/>
                        </p>
                        <%--<p style="color: <%# CheckEndDate( Eval( "Enddate" )%>;">--%>
                        End date: <strong><%# Eval( "Enddate", "{0:yyyy-MM-dd}") %></strong>
                        <%--</p>--%>
                        <p id="message">
                            <%# Eval( "Text" ) %>
                        </p>
                        <span id="borderStuff">
                        Finished?: <asp:CheckBox ID="cbFinished"
                                                 OnCheckedChanged="cbFinished_OnCheckedChanged"
                                                 runat="server"/>
                            </span>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
    </div>
</form>
</body>
</html>