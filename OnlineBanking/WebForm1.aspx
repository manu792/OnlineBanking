<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OnlineBanking.WebForm1" %>
<%@ Register TagPrefix="ids" Assembly="IDS.Web" Namespace="IDS.Web.UI.WebControls" %>
<%@ Register TagPrefix="ids" Assembly="IDS.Web" Namespace="IDS.Web.UI.WebInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ids:WebInputForm runat="server" ID="webInputForm" Features-Order="0"></ids:WebInputForm>
        <ids:WebInputTextBox ID="txtFirstName" runat="server" Label="First Name " AutoFormat="True" Required="True" Features-ZoneID="LeftZone"></ids:WebInputTextBox>
    </div>
    </form>
</body>
</html>
