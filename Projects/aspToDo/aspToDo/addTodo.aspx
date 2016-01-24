<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addTodo.aspx.cs" Inherits="aspToDo.AddTodo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>ASP.NET: Add Todo item</title>

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
                   SelectCommand="SELECT * FROM [Todo]">
</asp:SqlDataSource>

<form id="form1"
      runat="server">
    <div class="col-centered col-lg-3">

        <div class="page-header text-center">
            <h1>Add Todo-item</h1>
        </div>

        <div class="panel panel-info">
            <div class="panel-body">
                <span class="text-info">Title:</span> 
                

                <asp:TextBox ID="tbTitle"
                             placeholder="Enter the title here - 50 characters max"
                             runat="server"
                             ValidationGroup="addGroup"
                             Width="230px">
                </asp:TextBox>

                <asp:RequiredFieldValidator runat="server"
                                            Text="*"
                    ErrorMessage="You have to input a title."
                                            ForeColor="Red"
                                            ValidationGroup="addGroup"
                                            ControlToValidate="tbTitle"
                                            SetFocusOnError="True"/>
            </div>
        </div>
        <div class="panel panel-info">
            <div class="panel-body ">

                <span class="text-info">Priority: </span> <asp:DropDownList ID="ddlPriority"
                                                                            placeholder="Choose priority"
                                                                            runat="server">
                    <asp:ListItem Value="-1">
                        Low
                    </asp:ListItem>
                    <asp:ListItem Selected="True"
                                  Value="0">
                        Normal
                    </asp:ListItem>
                    <asp:ListItem Value="1">
                        High
                    </asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="panel panel-info">
            <div class="panel-body">
                <span class="text-info">End date</span> <asp:Calendar BackColor="White"
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
        </div>

        <div class="panel panel-info">
            <div class="panel-body">
                <h3 class="text-info">Todo Message</h3> <asp:TextBox Height="150px"
                                                                     ID="tbMessage"
                                                                     placeholder="Input your todo message here."
                                                                     runat="server"
                                                                     
                                                                     Width="100%">
                </asp:TextBox>
            </div>
        </div>
        <div class="panel panel-info"
             style="padding: 10px">
            <asp:Button ID="btnAdd"
                        OnClick="btnAdd_OnClick"
                        runat="server"
                        Text="Add item"
                        ValidationGroup="addGroup"/>
            <asp:ValidationSummary runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="addGroup"/>
            <asp:Button CssClass="Buttons"
                        ID="btnCancel"
                        OnClick="btnCancel_OnClick"
                        runat="server"
                        Text="Cancel"/>

        </div>
    </div>
</form>
</body>
</html>