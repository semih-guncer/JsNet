using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using JsNet;

/// <summary>
///   Description : JsNet Serializer for Chart.js
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : ChartJsNet
///   
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs
{
    public class ChartJsNet : JsNetClass
    {
        public string GetRGBA(Color c)
        {
            string retVal = "";
            if (c!=null)
                retVal = "rgba(" + c.R.ToString() + ", " + c.G.ToString() + ", " + c.B.ToString() + ", 0." + c.A.ToString() + ")";
            return retVal;
        }

        public static ConfigPie LoadConfigPie(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigPie>(fileName)) as ConfigPie;
        }
        public static ConfigDoughnut LoadConfigDoughnut(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigDoughnut>(fileName)) as ConfigDoughnut;
        }
        public static ConfigPolarArea LoadConfigPolarArea(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigPolarArea>(fileName)) as ConfigPolarArea;
        }
        public static ConfigBubble LoadConfigBubble(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigBubble>(fileName)) as ConfigBubble;
        }
        public static ConfigBar LoadConfigBar(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigBar>(fileName)) as ConfigBar;
        }
        public static ConfigRadar LoadConfigRadar(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigRadar>(fileName)) as ConfigRadar;
        }
        public static ConfigLine LoadConfigLine(string fileName)
        {
            return (JsNetClass.jsonLoad<ConfigLine>(fileName)) as ConfigLine;
        }


        public static string Serialize(ConfigPie configPie, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configPie, indentStep);
        }
        public static string Serialize(ConfigDoughnut configDoughnut, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configDoughnut, indentStep);
        }
        public static string Serialize(ConfigPolarArea configPolarArea, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configPolarArea, indentStep);
        }
        public static string Serialize(ConfigBubble configBubble, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configBubble, indentStep);
        }
        public static string Serialize(ConfigBar configBar, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configBar, indentStep);
        }
        public static string Serialize(ConfigRadar configRadar, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configRadar, indentStep);
        }
        public static string Serialize(ConfigLine configLine, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configLine, indentStep);
        }
    }
}
