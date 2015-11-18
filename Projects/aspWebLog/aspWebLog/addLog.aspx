<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addLog.aspx.cs" Inherits="aspWebLog.AddLog" %>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>My Log - Add new log</title>

        <style type="text/css">
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
                           SelectCommand="SELECT * FROM [Logs]" />
        <form id="form1"
              runat="server">
            <div id="body">
                <h1>My logging service</h1>
                <asp:Label id="currentDate" runat="server">Entry date: </asp:Label>    
                <asp:RequiredFieldValidator ControlToValidate="txtMessage"
                                            ErrorMessage="*"
                                            ForeColor="red"
                                            runat="server"
                                            style="margin-left: 500px"
                                            ValidationGroup="entryGroup">
                </asp:RequiredFieldValidator>

                <div id="messagebox">
                    <asp:TextBox ID="txtMessage"
                                 placeholder="Enter your text here."
                                 runat="server"
                                 style="height: 300px; width: 600px;" />

                </div>
                <div id="buttons">
                    <asp:Button id="btnBack"
                                OnClick="btnBack_OnClick"
                                runat="server" Text="Cancel" />
                    <asp:Button ID="btnSave"
                                OnClick="btnSave_OnClick"
                                runat="server"
                                ValidationGroup="entryGroup" Text="Save"/>

                </div>
            </div>
        </form>
    </body>
</html>