<%@ Control Language="C#" Inherits="OnlineBanking.BusinessForm, OnlineBanking" CodeBehind="BusinessForm.ascx.cs" AutoEventWireup="False" %>
<%@ Register TagPrefix="ids" Assembly="IDS.Web" Namespace="IDS.Web.UI.WebControls" %>
<%@ Register TagPrefix="ids" Assembly="IDS.Web" Namespace="IDS.Web.UI.WebInput" %>

<ids:WebInputForm runat="server", ID="webInputForm", Features-Order="0"></ids:WebInputForm>
<ids:WebInputTextBox runat="server", ID ="txtFirstName", Label="First Name", AutoFormat="true", Features-ZoneID="LeftZone"></ids:WebInputTextBox>