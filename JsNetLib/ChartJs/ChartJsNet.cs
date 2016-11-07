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

        public static void Load(ref ConfigPie o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigPie)ob;
        }

        public static void Load(ref ConfigDoughnut o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigDoughnut)ob;
        }

        public static void Load(ref ConfigPolarArea o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigPolarArea)ob;
        }

        public static void Load(ref ConfigBubble o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigBubble)ob;
        }

        public static void Load(ref ConfigBar o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigBar)ob;
        }

        public static void Load(ref ConfigRadar o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigRadar)ob;
        }

        public static void Load(ref ConfigLine o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigLine)ob;
        }

        public static void Load(ref ConfigScatterLine o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (ConfigScatterLine)ob;
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
        public static string Serialize(ConfigScatterLine configScatterLine, int indentStep)
        {
            return JsNetClass.javascriptSerialize(configScatterLine, indentStep);
        }
    }
}
