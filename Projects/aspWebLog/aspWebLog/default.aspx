<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="aspWebLog.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>ASP: Online log</title>
        <style type="text/css">
            #divLog {
                border: solid 1px #0066CC;
                font-family: Arial, Verdana, Sans-Serif;
                font-size: 18px;
                padding: 10px;
            }

            #divLog .detail {
                border-bottom: dashed 1px #0066CC;
                font-size: 15px;
                margin-bottom: 10px;
                padding: 10px;
            }

            #body {
                margin: auto;
                width: 50%;
            }
        </style>
    </head>
    <body>
        <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                           ID="sqlLog"
                           runat="server"
                           SelectCommand="SELECT * FROM [Logs] ORDER BY [Time] DESC" />

        <form id="form1"
              runat="server">
            <div id="body">
                <h1>
                    My logging service - my logs
                </h1>
                <asp:Button ID="btnAddLog"
                            OnClick="btnAddLog_OnClick"
                            runat="server"
                            Text="Add new log" />
                <div id="divLog">
                    <asp:Repeater DataSourceID="sqlLog"
                                  ID="rLogs"
                                  runat="server">
                        <HeaderTemplate>
                            <div class="detail">
                                
                            </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="detail">
                                <p>
                                    Date: <strong><%# Eval("Time", "{0:yyyy-MM-dd HH:mm}") %></strong>
                                </p>
                                <p>
                                    <%# Eval("Logged") %>
                                </p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </form>
    </body>
</html>