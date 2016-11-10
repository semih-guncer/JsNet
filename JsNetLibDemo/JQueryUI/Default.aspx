<%@ Page Title="JsNet Demo : JQueryUI" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JsNetLibDemo.JQueryUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
  <title><%= Page.Title %></title>
  <link rel="stylesheet" type="text/css" href="~/Content/themes/base/jquery-ui.css"/>
  <script type="text/javascript" src="../Scripts/jquery-3.1.1.js"></script>
  <script type="text/javascript" src="../Scripts/jquery-ui-1.12.1.js"></script>
 </head>
 <body>
  <form id="form1" runat="server">
   <div>
    <a href="DatePicker.aspx">DatePicker</a><br />

 
    <asp:LinkButton ID="lbHome" runat="server" PostBackUrl="~/Default.aspx" Text="Home" /><br />
   </div>
  </form>
 </body>
</html>
