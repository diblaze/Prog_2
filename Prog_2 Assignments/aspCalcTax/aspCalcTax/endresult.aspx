<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="endresult.aspx.cs" Inherits="aspCalcTax.Endresult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Din skatt - beräknad</title>
</head>
<body>
    <form id="form1"
          runat="server">
        <div>
            <asp:Panel ID="pnlResult"
                       runat="server"
                       Visible="False">
                <section id="result">
                    <h1>Ditt lönebesked:</h1>
                    <p>
                        <asp:Label ID="lblSalary"
                                   runat="server"
                                   Text="">
                        </asp:Label> <br/>
                        <asp:Label ID="lblTax"
                                   runat="server"
                                   Text="">
                        </asp:Label><br/>
                        <asp:Label ID="lblNet"
                                   runat="server"
                                   Text="">
                        </asp:Label><br/>
                    </p>
                </section>
            </asp:Panel>
        </div>
    </form>
</body>
</html>