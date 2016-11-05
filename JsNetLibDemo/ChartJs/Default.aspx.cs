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

        public string GetExampleCartPie()
        {
            ConfigPie c = new ConfigPie();
            c.data.labels.Add("L1");
            c.data.labels.Add("L2");
            c.data.labels.Add("L3");

            DatasetPie ds = new DatasetPie();
            ds.label = "Pie";


            ds.backgroundColor.Add("rgba(255, 99, 132, 0.2)");
            ds.backgroundColor.Add("rgba(54, 162, 235, 0.2)");
            ds.backgroundColor.Add("rgba(255, 206, 86, 0.2)");
            ds.backgroundColor.Add("rgba(75, 192, 192, 0.2)");
            ds.backgroundColor.Add("rgba(153, 102, 255, 0.2)");
            ds.backgroundColor.Add("rgba(255, 159, 64, 0.2)");

            ds.borderColor.Add("rgba(255, 99, 132, 1)");
            ds.borderColor.Add("rgba(54, 162, 235, 1)");
            ds.borderColor.Add("rgba(255, 206, 86, 1)");
            ds.borderColor.Add("rgba(75, 192, 192, 1)");
            ds.borderColor.Add("rgba(153, 102, 255, 1)");
            ds.borderColor.Add("rgba(255, 159, 64, 1)");

            ds.borderWidth = 1;

            ds.data.Add(12.00);
            ds.data.Add(25.00);
            ds.data.Add(7.00);
            c.data.datasets.Add(ds);
            
            return ChartJsNet.Serialize(c, 2);
        }
    }
}