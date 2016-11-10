<%@ Page Title="JsNet Demo" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JsNetLibDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
  <title><%= Page.Title %></title>
  <link rel="stylesheet" type="text/css" href="~/Content/bootstrap.css"/>
  <script type="text/javascript" src="../Scripts/jquery-3.1.1.js"></script>
  <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
 </head>
 <body>
  <form id="form1" runat="server">
   <div class="content-box">
    <h1><%= Page.Title %></h1>
    <a href="ChartJs/Default.aspx">Chart.js</a><br />
    <a href="JQueryUI/Default.aspx">JQuery UI</a><br />
   
   </div>
  </form>
 </body>
</html>
