using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JsNet.ChartJs;

namespace JsNetLibDemo.ChartJs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetExampleChartBar()
        {
            string templateFile = Server.MapPath("TemplateBar.json");
            ConfigBar c = ChartJsNet.LoadConfigBar(templateFile);

            c.data.datasets[0].data.Clear();
            c.data.datasets[0].data.Add(120);
            c.data.datasets[0].data.Add(190);
            c.data.datasets[0].data.Add(30);
            c.data.datasets[0].data.Add(50);
            c.data.datasets[0].data.Add(20);
            c.data.datasets[0].data.Add(30);

            return ChartJsNet.Serialize(c, 0);
        }

        public string GetExampleChartPie()
        {
            string templateFile = Server.MapPath("TemplatePie.json");
            ConfigPie c = ChartJsNet.LoadConfigPie(templateFile);

            c.data.datasets[0].data.Clear();
            c.data.datasets[0].data.Add(120);
            c.data.datasets[0].data.Add(250);
            c.data.datasets[0].data.Add(70);

            // ConfigPie c = new ConfigPie();
            // c.data.labels.Add("L1");
            // c.data.labels.Add("L2");
            // c.data.labels.Add("L3");
            // 
            // DatasetPie ds = new DatasetPie();
            // ds.label = "Pie";
            // ds.backgroundColor.Add("rgba(255, 99, 132, 0.2)");
            // ds.backgroundColor.Add("rgba(54, 162, 235, 0.2)");
            // ds.backgroundColor.Add("rgba(255, 206, 86, 0.2)");
            // ds.backgroundColor.Add("rgba(75, 192, 192, 0.2)");
            // ds.backgroundColor.Add("rgba(153, 102, 255, 0.2)");
            // ds.backgroundColor.Add("rgba(255, 159, 64, 0.2)");
            // 
            // ds.borderColor.Add("rgba(255, 99, 132, 1)");
            // ds.borderColor.Add("rgba(54, 162, 235, 1)");
            // ds.borderColor.Add("rgba(255, 206, 86, 1)");
            // ds.borderColor.Add("rgba(75, 192, 192, 1)");
            // ds.borderColor.Add("rgba(153, 102, 255, 1)");
            // ds.borderColor.Add("rgba(255, 159, 64, 1)");
            // 
            // ds.borderWidth = 1;
            // 
            // ds.data.Add(12.00);
            // ds.data.Add(25.00);
            // ds.data.Add(7.00);
            // c.data.datasets.Add(ds);

            return ChartJsNet.Serialize(c, 2);
        }
    }
}