<%@ Page Title="JsNet Demo : Chart.js" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JsNetLibDemo.ChartJs.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
  <title><%= Page.Title %></title>
  <link rel="stylesheet" type="text/css" href="~/Content/bootstrap.css"/>
  <script type="text/javascript" src="../Scripts/jquery-3.1.1.js"></script>
  <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
  <script type="text/javascript" src="../Scripts/Chart.js"></script>
 </head>
 <body>
  <form id="form1" runat="server">
   <div class="content-box">
    <h1><%= Page.Title %></h1>
    <div class="row">
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>Bar</p>
      <canvas id="myChartBar1" width="400" height="400"></canvas>
<script>
var ctxBar1 = document.getElementById("myChartBar1");
var myChartBar1 = new Chart(ctxBar1,<%= GetExampleChartBar()  %> );
</script>
     </div>
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>Pie</p>
      <canvas id="myChartPie1" width="400" height="400"></canvas>
<script>
var ctxPie1 = document.getElementById("myChartPie1");
var myChartPie1 = new Chart(ctxPie1,<%= GetExampleChartPie()  %> );
</script>
     </div>
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>Radar</p>
      <canvas id="myChartRadar1" width="400" height="400"></canvas>
<script>
var ctxRadar1 = document.getElementById("myChartRadar1");
var myChartRadar1 = new Chart(ctxRadar1,<%= GetExampleChartRadar()  %> );
</script>
     </div>
     <div class="col-md-2" style="margin-top:15px;margin-left:15px;padding:5px;background-color:#f8f8f8;">
      <p>Line</p>
      <canvas id="myChartLine1" width="400" height="400"></canvas>
<script>
var ctxLine1 = document.getElementById("myChartLine1");
var myChartLine1 = new Chart(ctxLine1, <%= GetExampleChartLine()  %>);
</script>
     </div>
    </div>
    
    <asp:LinkButton ID="lbHome" runat="server" PostBackUrl="~/Default.aspx" Text="Home" /><br />
   </div>
  </form>
 </body>
</html>
