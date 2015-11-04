<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCity.aspx.cs" Inherits="aspCalcTax.AddCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Ny kommun</title>
    </head>
    <body>

        <asp:SqlDataSource ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                           ID="dsCities"
                           runat="server"
                           SelectCommand="SELECT * FROM [Taxes]">
        </asp:SqlDataSource>

        <form id="form1"
              runat="server">
            <div>
                <table>
                    <tr>
                        <td>Kommun:</td>
                        <td>
                            <asp:TextBox ID="txtCity"
                                         runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ControlToValidate="txtCity"
                                                        ForeColor="Red"
                                                        ID="rqValidator1"
                                                        runat="server"  
                                                        Text="*"
                                                        ValidationGroup="addGroup">

                            </asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:Label ForeColor="Red"
                                       ID="lblCityError"
                                       runat="server">
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Skatt (%):</td>
                        <td>
                            <asp:TextBox ID="txtLocalTax"
                                         runat="server">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator runat="server"
                                                            ID="revNumber"
                                                            ErrorMessage="*"
                                                            ForeColor="Red"
                                                            ControlToValidate="txtLocalTax"
                                                            ValidationExpression="^\d*(\,|\.)?\d*[%]{0,1}$">
                                
                            </asp:RegularExpressionValidator>

                            <asp:RequiredFieldValidator ControlToValidate="txtLocalTax"
                                                        ErrorMessage="*"
                                                        ForeColor="Red"
                                                        ID="rqValidator2"
                                                        runat="server"
                                                        ValidationGroup="addGroup">
                            </asp:RequiredFieldValidator>

                        </td>

                    </tr>
                    <tr>
                        <td>Kyrkoavgift (%):</td>
                        <td>
                            <asp:TextBox ID="txtChurchTax"
                                         runat="server">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator runat="server"
                                                            ID="revChurchTax"
                                                            ErrorMessage="*"
                                                            ForeColor="Red"
                                                            ControlToValidate="txtChurchTax"
                                                            ValidationExpression="^\d*(\,|\.)?\d*[%]{0,1}$">
                                
                            </asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ControlToValidate="txtChurchTax"
                                                        ErrorMessage="*"
                                                        ForeColor="Red"
                                                        ID="rqValidator3"
                                                        runat="server"
                                                        ValidationGroup="addGroup">
                            </asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>Begravningsavgift (%):</td>
                        <td>
                            <asp:TextBox ID="txtFuneralTax"
                                         runat="server">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator runat="server"
                                                            ID="revFuneralTax"
                                                            ErrorMessage="*"
                                                            ForeColor="Red"
                                                            ControlToValidate="txtFuneralTax"
                                                            ValidationExpression="^\d*(\,|\.)?\d*[%]{0,1}$">
                                
                            </asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ControlToValidate="txtFuneralTax"
                                                        ErrorMessage="*"
                                                        ForeColor="Red"
                                                        ID="rqValidator4"
                                                        runat="server"
                                                        ValidationGroup="addGroup">
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>

                <br />
                <div>
                    <asp:Button ID="btnAdd"
                                OnClick="btnAdd_OnClick"
                                runat="server"
                                Text="Lägg till kommun"
                                ValidationGroup="addGroup" />

                    <asp:Button ID="btnBack"
                                OnClick="btnBack_OnClick"
                                runat="server"
                                Text="Tillbaka" />
                </div>
            </div>
        </form>
    </body>
</html>