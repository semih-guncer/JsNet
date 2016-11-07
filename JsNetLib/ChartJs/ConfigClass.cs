using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsNet.ChartJs.Options;

/// <summary>
///   Description : Config classes for chart types
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : ConfigClass
///               , ConfigPie, ConfigDoughnut, ConfigPolarArea
///               , ConfigBubble, ConfigBar, ConfigRadar, ConfigLine
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs
{
    /// <summary>
    /// Base Config class 
    /// </summary>
    public abstract class ConfigClass : JsNetBaseClass
    {
        protected string _type = ""; // { line, bar, radar, polarArea, pie, doughnut, bubble }
        protected OptionsClass _options = new OptionsClass();
    }

    /// <summary>
    /// Config class for "pie"
    /// </summary>
    public class ConfigPie : ConfigClass
    {
        private DataPie _data = new DataPie();

        public string type { get { return _type; } }
        public DataPie data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigPie()
        {
            _type = "pie";
        }
    }

    /// <summary>
    /// Config class for "doughnut"
    /// </summary>
    public class ConfigDoughnut : ConfigClass
    {
        private DataDoughnut _data = new DataDoughnut();

        public string type { get { return _type; } }
        public DataDoughnut data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigDoughnut()
        {
            _type = "doughnut";
        }
    }

    /// <summary>
    /// Config class for "polarArea"
    /// </summary>
    public class ConfigPolarArea : ConfigClass
    {
        private DataPolarArea _data = new DataPolarArea();

        public string type { get { return _type; } }
        public DataPolarArea data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigPolarArea()
        {
            _type = "polarArea";
        }
    }

    /// <summary>
    /// Config class for "bubble"
    /// </summary>
    public class ConfigBubble : ConfigClass
    {
        private DataBubble _data = new DataBubble();

        public string type { get { return _type; } }
        public DataBubble data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigBubble()
        {
            _type = "bubble";
        }
    }

    /// <summary>
    /// Config class for "bar"
    /// </summary>
    public class ConfigBar : ConfigClass
    {
        private DataBar _data = new DataBar();

        public string type { get { return _type; } }
        public DataBar data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigBar()
        {
            _type = "bar";
        }
    }

    /// <summary>
    /// Config class for "radar"
    /// </summary>
    public class ConfigRadar : ConfigClass
    {
        private DataRadar _data = new DataRadar();

        public string type { get { return _type; } }
        public DataRadar data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigRadar()
        {
            _type = "radar";
        }
    }

    /// <summary>
    /// Config class for "line"
    /// </summary>
    public class ConfigLine : ConfigClass
    {
        private DataLine _data = new DataLine();

        public string type { get { return _type; } }
        public DataLine data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigLine()
        {
            _type = "line";
        }
    }
    /// <summary>
    /// Config class for Scatter "line"
    /// </summary>
    public class ConfigScatterLine : ConfigClass
    {
        private DataScatterLine _data = new DataScatterLine();

        public string type { get { return _type; } }
        public DataScatterLine data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public ConfigScatterLine()
        {
            _type = "line";
        }
    }
}
