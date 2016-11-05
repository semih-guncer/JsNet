<%@ Page Title="JsNet Demo : Chart.js" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JsNetLibDemo.ChartJs.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title><%= Page.Title %></title>
 <script type="text/javascript" src="../Scripts/jquery-3.1.1.js"></script>
 <script type="text/javascript" src="../Scripts/Chart.js"></script>
</head>
<body>
 <form id="form1" runat="server">
  <div>
   <h1><%= Page.Title %></h1>

   <div style="width:200px; height:200px; border-width:1px;">
    <canvas id="myChart" width="400" height="400"></canvas>
   </div>
<script>
var ctx = document.getElementById("myChart");
var myChart = new Chart(ctx, {
    type: "bar",
    data: {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                "rgba(255, 99, 132, 0.2)",
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero:true
                }
            }]
        }
    }
});
</script>
   
   <br />

   <div style="width:200px; height:200px; border-width:1px;">
    <canvas id="myChartPie" width="400" height="400"></canvas>
   </div>
<script>
var ctx1 = document.getElementById("myChartPie");
var myChart1 = new Chart(ctx1,<%= GetExampleCartPie()  %> );
</script>
   
   <br />
 
   <asp:LinkButton ID="lbHome" runat="server" PostBackUrl="~/Default.aspx" Text="Home" /><br />
  </div>
 </form>
</body>
</html>
