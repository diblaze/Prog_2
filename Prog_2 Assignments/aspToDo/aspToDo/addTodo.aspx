<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addTodo.aspx.cs" Inherits="aspToDo.addTodo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>ASP.NET: Add Todo item</title>
<style type="text/css">
    body
        {
        margin: 0 auto;
        width: 50%;
        }

    #headerAddBox
        {
        text-align: center;
        }

    #addSettings
        {
        border-bottom: dashed 1px #0066cc;
        }
    #addButtons
        {
        /*width: 50%;*/
        text-align: center

        
        }
    .Buttons
        {
        margin-right: 20px;
        
        }
    

</style>
</head>
<body>
<asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                   ID="sdsTodo"
                   runat="server"
                   SelectCommand="SELECT * FROM [Todo]">
</asp:SqlDataSource>
<form id="form1"
      runat="server">
    <div>
        <div id="headerAddBox">
            <h1>Add Todo-item</h1>
        </div>

        <div id="addBox">
            <div id="addSettings">
                Title: <asp:TextBox ID="tbTitle"
                                    placeholder="Enter the title here - 50 characters max"
                                    runat="server"
                                    ValidationGroup="addGroup"
                                    Width="230px">
                </asp:TextBox>
                <br/>
                Priority: <asp:DropDownList ID="ddlPriority"
                                            placeholder="Choose priority"
                                            runat="server">
                    <asp:ListItem Value="0">
                        Low
                    </asp:ListItem>
                    <asp:ListItem Value="1" Selected="True">
                        Normal
                    </asp:ListItem>
                    <asp:ListItem Value="2">
                        High
                    </asp:ListItem>
                </asp:DropDownList>
                <br/>
                End date: <asp:Calendar BackColor="White"
                                        BorderColor="#3366CC"
                                        CellPadding="1"
                                        DayNameFormat="Shortest"
                                        Font-Names="Verdana"
                                        Font-Size="8pt"
                                        ForeColor="#003399"
                                        Height="200px"
                                        ID="calEndDate"
                                        runat="server"
                                        Width="250px">
                    <SelectedDayStyle BackColor="#009999"
                                      Font-Bold="True"
                                      ForeColor="#CCFF99"/>
                    <TodayDayStyle BackColor="#99CCCC"
                                   ForeColor="White"/>
                    <SelectorStyle BackColor="#99CCCC"
                                   ForeColor="#336666"/>
                    <WeekendDayStyle BackColor="#CCCCFF"/>
                    <OtherMonthDayStyle ForeColor="#999999"/>
                    <NextPrevStyle Font-Size="8pt"
                                   ForeColor="#CCCCFF"/>
                    <DayHeaderStyle BackColor="#99CCCC"
                                    ForeColor="#336666"
                                    Height="1px"/>
                    <TitleStyle BackColor="#003399"
                                BorderColor="#3366CC"
                                BorderWidth="1px"
                                Font-Bold="True"
                                Font-Size="10pt"
                                ForeColor="#CCCCFF"
                                Height="25px"/>
                </asp:Calendar>
            </div>
            <div id="addMessageBox" style="margin-top: 50px">
                <h2 style="margin: 0">Text:</h2> <asp:TextBox runat="server"
                                                              ID="tbMessage"
                                                              ValidationGroup="addGroup"
                                                              placeholder="Input your todo item here."
                                                              Width="100%"
                                                              Height="150px">
                </asp:TextBox>
                <div id="addButtons">
                <asp:Button runat="server" CssClass="Buttons" ID="btnCancel" OnClick="btnCancel_OnClick" Text="Cancel" />
                    <asp:Button runat="server"
                                ID="btnAdd"
                                ValidationGroup="addGroup"
                                OnClick="btnAdd_OnClick"
                                Text="Add item"/>
                    </div>
            </div>

        </div>

    </div>
</form>
</body>
</html>