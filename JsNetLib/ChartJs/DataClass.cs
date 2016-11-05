using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : Data classes for chart types
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : DataClass
///               , DataPie, DataDoughnut, DataPolarArea
///               , DataBubble, DataBar, DataRadar, DataLine
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs
{
    /// <summary>
    /// Base Data class 
    /// </summary>
    public abstract class DataClass
    {
        private List<string> _labels = new List<string>();
        private List<string> _xLabels = new List<string>();
        private List<string> _yLabels = new List<string>();

        public List<string> labels { get { return _labels; } set { _labels = value; } }
        public List<string> xLabels { get { return _xLabels; } set { _xLabels = value; } }
        public List<string> yLabels { get { return _yLabels; } set { _yLabels = value; } }
    }

    /// <summary>
    /// Data class for "pie"
    /// </summary>
    public class DataPie : DataClass
    {
        private List<DatasetPie> _datasets = new List<DatasetPie>();

        public List<DatasetPie> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "doughnut"
    /// </summary>
    public class DataDoughnut : DataClass
    {
        private List<DatasetDoughnut> _datasets = new List<DatasetDoughnut>();

        public List<DatasetDoughnut> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "polarArea"
    /// </summary>
    public class DataPolarArea : DataClass
    {
        private List<DatasetPolarArea> _datasets = new List<DatasetPolarArea>();

        public List<DatasetPolarArea> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "bubble"
    /// </summary>
    public class DataBubble : DataClass
    {
        private List<DatasetBubble> _datasets = new List<DatasetBubble>();

        public List<DatasetBubble> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "bar"
    /// </summary>
    public class DataBar : DataClass
    {
        private List<DatasetBar> _datasets = new List<DatasetBar>();

        public List<DatasetBar> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "radar"
    /// </summary>
    public class DataRadar : DataClass
    {
        private List<DatasetRadar> _datasets = new List<DatasetRadar>();

        public List<DatasetRadar> datasets { get { return _datasets; } set { _datasets = value; } }
    }

    /// <summary>
    /// Data class for "line"
    /// </summary>
    public class DataLine : DataClass
    {
        private List<DatasetLine> _datasets = new List<DatasetLine>();

        public List<DatasetLine> datasets { get { return _datasets; } set { _datasets = value; } }
    }

}
