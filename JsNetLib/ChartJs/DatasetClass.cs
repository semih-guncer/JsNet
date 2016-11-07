using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : Dataset classes for chart types
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : DataPoint, DataCircle, DatasetClass
///               , DatasetPie, DatasetDoughnut, DatasetPolarArea
///               , DatasetBubble, DatasetBar, DatasetRadar, DatasetLine
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs
{
    /// <summary>
    /// Data object for "radar" and "line"
    /// </summary>
    public class DataPoint : JsNetBaseClass
    {
        private double _x = 0;
        private double _y = 0;

        public double x { get { return _x; } set { _x = value; } }
        public double y { get { return _y; } set { _y = value; } }
    }

    /// <summary>
    /// Data object for "bubble"
    /// </summary>
    public class DataCircle : DataPoint
    {
        private double _r = 0;

        public double r { get { return _r; } set { _r = value; } }
    }

    /// <summary>
    /// Base Dataset class 
    /// </summary>
    public abstract class DatasetClass : JsNetBaseClass
    {
        // [*]
        private string _label = "";
        private List<string> _backgroundColor = null;
        private List<string> _borderColor = null;
        private List<double> _borderWidth = null;

        // [~],  "point+" [DatasetRadar,DatasetLine]
        protected List<string> _hoverBackgroundColor = null;
        protected List<string> _hoverBorderColor = null;
        protected List<double> _hoverBorderWidth = null;

        // [DatasetBubble], "point+" [DatasetRadar,DatasetLine]
        protected List<double> _hoverRadius = null;

        // [DatasetBar ,DatasetLine]
        protected string _xAxisID = "";
        protected string _yAxisID = "";

        // [DatasetBar]
        protected List<string> _borderSkipped = null; // new List<string>();

        // [DatasetRadar], "point+" [DatasetLine]
        protected List<double> _hitRadius = null;

        // [DatasetRadar, DatasetLine]
        protected List<double> _pointRadius = null;
        protected List<string> _pointStyle = null; //'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', 'dash'
        protected bool _fill = false;
        protected double _lineTension = 0;
        protected string _borderCapStyle = "";
        protected List<double> _borderDash = null;
        protected double _borderDashOffset = 0;
        protected string _borderJoinStyle = "";
        protected List<string> _pointBorderColor = null;
        protected List<string> _pointBackgroundColor = null;
        protected List<double> _pointBorderWidth = null;

        // [DatasetLine]
        protected bool _showLine = false;
        protected bool _spanGaps = false;
        protected bool _steppedLine = false;
        protected string _cubicInterpolationMode = "";


        public string label { get { return _label; } set { _label = value; } }

        public List<string> backgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
        public List<string> borderColor { get { return _borderColor; } set { _borderColor = value; } }
        public List<double> borderWidth { get { return _borderWidth; } set { _borderWidth = value; } }
    }

    /// <summary>
    /// Dataset class for "pie"
    /// </summary>
    public class DatasetPie : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
    }

    /// <summary>
    /// Dataset class for "doughnut"
    /// </summary>
    public class DatasetDoughnut : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
    }

    /// <summary>
    /// Dataset class for "polarArea"
    /// </summary>
    public class DatasetPolarArea : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
    }

    /// <summary>
    /// Dataset class for "bubble"
    /// </summary>
    public class DatasetBubble : DatasetClass
    {
        protected List<DataCircle> _dataCircle = null;

        public List<DataCircle> data { get { return _dataCircle; } set { _dataCircle = value; } }

        public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
        public List<double> hoverRadius { get { return _hoverRadius; } set { _hoverRadius = value; } }
    }

    /// <summary>
    /// Dataset class for "bar"
    /// </summary>
    public class DatasetBar : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }

        public string xAxisID { get { return _xAxisID; } set { _xAxisID = value; } }
        public string yAxisID { get { return _yAxisID; } set { _yAxisID = value; } }

        public List<string> borderSkipped { get { return _borderSkipped; } set { _borderSkipped = value; } }
    }

    /// <summary>
    /// Dataset class for "radar"
    /// </summary>
    public class DatasetRadar : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> pointHoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> pointHoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> pointHoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
        public List<double> pointHoverRadius { get { return _hoverRadius; } set { _hoverRadius = value; } }

        public  List<double> hitRadius { get { return _hitRadius; } set { _hitRadius = value; } }        

        /// <summary>
        /// "circle", "triangle", "rect", "rectRot", "cross", "crossRot", "star", "line", "dash"
        /// </summary>
        public List<string> pointStyle { get { return _pointStyle; } set { _pointStyle = value; } }

        public List<double> pointRadius { get { return _pointRadius; } set { _pointRadius = value; } }
        public bool fill { get { return _fill; } set { _fill = value; } }
        public double lineTension { get { return _lineTension; } set { _lineTension = value; } }
        public string borderCapStyle { get { return _borderCapStyle; } set { _borderCapStyle = value; } }
        public List<double> borderDash { get { return _borderDash; } set { _borderDash = value; } }
        public double borderDashOffset { get { return _borderDashOffset; } set { _borderDashOffset = value; } }
        public string borderJoinStyle { get { return _borderJoinStyle; } set { _borderJoinStyle = value; } }
        public List<string> pointBorderColor { get { return _pointBorderColor; } set { _pointBorderColor = value; } }
        public List<string> pointBackgroundColor { get { return _pointBackgroundColor; } set { _pointBackgroundColor = value; } }
        public List<double> pointBorderWidth  { get { return _pointBorderWidth; } set { _pointBorderWidth = value; } }
    }

    /// <summary>
    /// Dataset class for "line"
    /// </summary>
    public class DatasetLine : DatasetClass
    {
        protected List<double> _dataNumber = null;

        public List<double> data { get { return _dataNumber; } set { _dataNumber = value; } }

        public List<string> pointHoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> pointHoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> pointHoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
        public List<double> pointHoverRadius { get { return _hoverRadius; } set { _hoverRadius = value; } }

        public string xAxisID { get { return _xAxisID; } set { _xAxisID = value; } }
        public string yAxisID { get { return _yAxisID; } set { _yAxisID = value; } }

        public List<double> pointHitRadius { get { return _hitRadius; } set { _hitRadius = value; } }

        /// <summary>
        /// "circle", "triangle", "rect", "rectRot", "cross", "crossRot", "star", "line", "dash"
        /// </summary>
        public List<string> pointStyle { get { return _pointStyle; } set { _pointStyle = value; } }

        public List<double> pointRadius { get { return _pointRadius; } set { _pointRadius = value; } }
        public bool fill { get { return _fill; } set { _fill = value; } }
        public double lineTension { get { return _lineTension; } set { _lineTension = value; } }
        public string borderCapStyle { get { return _borderCapStyle; } set { _borderCapStyle = value; } }
        public List<double> borderDash { get { return _borderDash; } set { _borderDash = value; } }
        public double borderDashOffset { get { return _borderDashOffset; } set { _borderDashOffset = value; } }
        public string borderJoinStyle { get { return _borderJoinStyle; } set { _borderJoinStyle = value; } }
        public List<string> pointBorderColor { get { return _pointBorderColor; } set { _pointBorderColor = value; } }
        public List<string> pointBackgroundColor { get { return _pointBackgroundColor; } set { _pointBackgroundColor = value; } }
        public List<double> pointBorderWidth { get { return _pointBorderWidth; } set { _pointBorderWidth = value; } }

        protected bool showLine { get { return _showLine; } set { _showLine = value; } }
        protected bool spanGaps { get { return _spanGaps; } set { _spanGaps = value; } }
        protected bool steppedLine { get { return _steppedLine; } set { _steppedLine = value; } }
        protected string cubicInterpolationMode { get { return _cubicInterpolationMode; } set { _cubicInterpolationMode = value; } }
    }

    /// <summary>
    /// Dataset class for "Scatterline"
    /// </summary>
    public class DatasetScatterLine : DatasetClass
    {
        protected List<DataPoint> _dataPoint = null;

        public List<DataPoint> data { get { return _dataPoint; } set { _dataPoint = value; } }

        public List<string> pointHoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
        public List<string> pointHoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
        public List<double> pointHoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
        public List<double> pointHoverRadius { get { return _hoverRadius; } set { _hoverRadius = value; } }

        public string xAxisID { get { return _xAxisID; } set { _xAxisID = value; } }
        public string yAxisID { get { return _yAxisID; } set { _yAxisID = value; } }

        public List<double> pointHitRadius { get { return _hitRadius; } set { _hitRadius = value; } }

        /// <summary>
        /// "circle", "triangle", "rect", "rectRot", "cross", "crossRot", "star", "line", "dash"
        /// </summary>
        public List<string> pointStyle { get { return _pointStyle; } set { _pointStyle = value; } }

        public List<double> pointRadius { get { return _pointRadius; } set { _pointRadius = value; } }
        public bool fill { get { return _fill; } set { _fill = value; } }
        public double lineTension { get { return _lineTension; } set { _lineTension = value; } }
        public string borderCapStyle { get { return _borderCapStyle; } set { _borderCapStyle = value; } }
        public List<double> borderDash { get { return _borderDash; } set { _borderDash = value; } }
        public double borderDashOffset { get { return _borderDashOffset; } set { _borderDashOffset = value; } }
        public string borderJoinStyle { get { return _borderJoinStyle; } set { _borderJoinStyle = value; } }
        public List<string> pointBorderColor { get { return _pointBorderColor; } set { _pointBorderColor = value; } }
        public List<string> pointBackgroundColor { get { return _pointBackgroundColor; } set { _pointBackgroundColor = value; } }
        public List<double> pointBorderWidth { get { return _pointBorderWidth; } set { _pointBorderWidth = value; } }

        protected bool showLine { get { return _showLine; } set { _showLine = value; } }
        protected bool spanGaps { get { return _spanGaps; } set { _spanGaps = value; } }
        protected bool steppedLine { get { return _steppedLine; } set { _steppedLine = value; } }
        protected string cubicInterpolationMode { get { return _cubicInterpolationMode; } set { _cubicInterpolationMode = value; } }
    }

}
