using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : Options class
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : OptionsClass
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs.Options
{
    /// <summary>
    /// Options class
    /// </summary>
    public class OptionsClass : JsNetBaseClass
    {
        private bool _responsive = true;
        private double _responsiveAnimationDuration = 0;
        private bool _maintainAspectRatio = true;
        private List<string> _events = new List<string>();
        private TitleClass _title = null;
        private HoverClass _hover = null;
        private TooltipClass _tooltip = null;
        private LegendClass _legend = null;
        private List<ScaleClass> _scales = null;

        public bool responsive { get { return _responsive; } set { _responsive = value; } }
        public double responsiveAnimationDuration { get { return _responsiveAnimationDuration; } set { _responsiveAnimationDuration = value; } }
        public bool maintainAspectRatio { get { return _maintainAspectRatio; } set { _maintainAspectRatio = value; } }

        /// <summary>
        /// ["mousemove", "mouseout", "click", "touchstart", "touchmove", "touchend"]
        /// </summary>
        public List<string> events { get { return _events; } set { _events = value; } }
        
        // onClick
        // legendCallback
        // onResize

        public TitleClass title { get { return _title; } set { _title = value; } }

        public HoverClass hover { get { return _hover; } set { _hover = value; } }

        public TooltipClass tooltip { get { return _tooltip; } set { _tooltip = value; } }

        /// <summary>
        /// LegendClass not implemented
        /// </summary>
        public LegendClass legend { get { return _legend; } set { _legend = value; } }

        /// <summary>
        /// ScaleClass not implemented
        /// </summary>
        public List<ScaleClass> scales { get { return _scales; } set { _scales = value; } }

    }

    /// <summary>
    /// Title class
    /// </summary>
    public class TitleClass : JsNetBaseClass
    {
        private bool _display = false;
        private string _position = "top";
        private bool _fullWidth = true;
        private double _fontSize = 12;
        private string _fontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
        private string _fontColor = "#666";
        private string _fontStyle = "bold";
        private double _padding = 10;
        private string _text = null;

        public bool display { get { return _display; } set { _display = value; } }
        public string position { get { return _position; } set { _position = value; } }
        public bool fullWidth { get { return _fullWidth; } set { _fullWidth = value; } }
        public double fontSize { get { return _fontSize; } set { _fontSize = value; } }
        public string fontFamily { get { return _fontFamily; } set { _fontFamily = value; } }
        public string fontColor { get { return _fontColor; } set { _fontColor = value; } }
        public string fontStyle { get { return _fontStyle; } set { _fontStyle = value; } }
        public double padding { get { return _padding; } set { _padding = value; } }
        public string text { get { return _text; } set { _text = value; } }
    }

    public class HoverClass : JsNetBaseClass
    {
        private string _mode = "single";
        private double _animationDuration = 400;
        private JsNetFunction _onHover = null;

        /// <summary>
        /// ['single', 'label', 'x-axis', 'dataset'.]
        /// </summary>
        public string mode { get { return _mode; } set { _mode = value; } }
        public double animationDuration { get { return _animationDuration; } set { _animationDuration = value; } }
        
        public JsNetFunction onHover { get { return _onHover; } set { _onHover = value; } }
    }

    public class TooltipClass : JsNetBaseClass
    {
        private bool _enabled = true;
        private JsNetFunction _custom = null;
        private string _mode = "single";
        private JsNetFunction _itemSort = null;
        private string _backgroundColor = "rgba(0,0,0,0.8)";
        private string _titleFontFamily = "Helvetica";
        private double _titleFontSize = 12;
        private string _titleFontStyle = "bold";
        private string _titleFontColor = "#fff";
        private double _titleSpacing = 2;
        private double _titleMarginBottom = 6;
        private string _bodyFontFamily = "Helvetica";
        private double _bodyFontSize = 12;
        private string _bodyFontStyle = "normal";
        private string _bodyFontColor = "#fff";
        private double _bodySpacing = 2;
        private string _footerFontFamily = "Helvetica";
        private double _footerFontSize = 12;
        private string _footerFontStyle = "bold";
        private string _footerFontColor = "#fff";
        private double _footerSpacing = 2;
        private double _footerMarginTop = 6;
        private double _xPadding = 6;
        private double _yPadding = 6;
        private double _caretSize = 5;
        private double _cornerRadius = 6;
        private string _multiKeyBackground = "#fff";
        //callbacks Object


        public bool enabled { get { return _enabled; } set { _enabled = value; } }

        public JsNetFunction custom { get { return _custom; } set { _custom = value; } }

        public string mode { get { return _mode; } set { _mode = value; } }

        public JsNetFunction itemSort { get { return _itemSort; } set { _itemSort = value; } }

        public string backgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
        public string titleFontFamily { get { return _titleFontFamily; } set { _titleFontFamily = value; } }
        public double titleFontSize { get { return _titleFontSize; } set { _titleFontSize = value; } }
        public string titleFontStyle { get { return _titleFontStyle; } set { _titleFontStyle = value; } }
        public string titleFontColor { get { return _titleFontColor; } set { _titleFontColor = value; } }
        public double titleSpacing { get { return _titleSpacing; } set { _titleSpacing = value; } }
        public double titleMarginBottom { get { return _titleMarginBottom; } set { _titleMarginBottom = value; } }
        public string bodyFontFamily { get { return _bodyFontFamily; } set { _bodyFontFamily = value; } }
        public double bodyFontSize { get { return _bodyFontSize; } set { _bodyFontSize = value; } }
        public string bodyFontStyle { get { return _bodyFontStyle; } set { _bodyFontStyle = value; } }
        public string bodyFontColor { get { return _bodyFontColor; } set { _bodyFontColor = value; } }
        public double bodySpacing { get { return _bodySpacing; } set { _bodySpacing = value; } }
        public string footerFontFamily { get { return _footerFontFamily; } set { _footerFontFamily = value; } }
        public double footerFontSize { get { return _footerFontSize; } set { _footerFontSize = value; } }
        public string footerFontStyle { get { return _footerFontStyle; } set { _footerFontStyle = value; } }
        public string footerFontColor { get { return _footerFontColor; } set { _footerFontColor = value; } }
        public double footerSpacing { get { return _footerSpacing; } set { _footerSpacing = value; } }
        public double footerMarginTop { get { return _footerMarginTop; } set { _footerMarginTop = value; } }
        public double xPadding { get { return _xPadding; } set { _xPadding = value; } }
        public double yPadding { get { return _yPadding; } set { _yPadding = value; } }
        public double caretSize { get { return _caretSize; } set { _caretSize = value; } }
        public double cornerRadius { get { return _cornerRadius; } set { _cornerRadius = value; } }
        public string multiKeyBackground { get { return _multiKeyBackground; } set { _multiKeyBackground = value; } }
        
        //callbacks Object

    }

    /// <summary>
    /// Legend class not implemented
    /// </summary>
    public class LegendClass : JsNetBaseClass
    {
        private bool _display = true;

        //  'top', 'left', 'bottom', 'right'
        private string _position = "top";
        private bool _fullWidth = true;

        private JsNetFunction _onClick = null;
        private JsNetFunction _onHover = null;

        private List<LegendLabelClass> _labels = null;


        public bool display { get { return _display; } set { _display = value; } }

        //  'top', 'left', 'bottom', 'right'
        public string position { get { return _position; } set { _position = value; } }
        public bool fullWidth { get { return _fullWidth; } set { _fullWidth = value; } }

        public JsNetFunction onClick { get { return _onClick; } set { _onClick = value; } }
        public JsNetFunction onHover { get { return _onHover; } set { _onHover = value; } }

        public List<LegendLabelClass> labels { get { return _labels; } set { _labels = value; } }
    }

    public class LegendLabelClass : JsNetBaseClass
    {
        private double _boxWidth = 40;
        private double _fontSize = 12;
        private string _fontStyle = "normal";
        private string _fontColor = "#666";
        private string _fontFamily = "Helvetica";
        private double _padding = 10;
        private JsNetFunction _generateLabels = null;
        private bool _usePointStyle = false;
        private bool _reverse = false;


        public double boxWidth { get { return _boxWidth; } set { _boxWidth = value; } }
        public double fontSize { get { return _fontSize; } set { _fontSize = value; } }
        public string fontStyle { get { return _fontStyle; } set { _fontStyle = value; } }
        public string fontColor { get { return _fontColor; } set { _fontColor = value; } }
        public string fontFamily { get { return _fontFamily; } set { _fontFamily = value; } }
        public double padding { get { return _padding; } set { _padding = value; } }
        public JsNetFunction generateLabels { get { return _generateLabels; } set { _generateLabels = value; } }
        public bool usePointStyle { get { return _usePointStyle; } set { _usePointStyle = value; } }
        public bool reverse { get { return _reverse; } set { _reverse = value; } }
    }


    /// <summary>
    /// Scale class not implemented
    /// </summary>
    public class ScaleClass : JsNetBaseClass
    {
        // "category", "linear", "logarithmic", "time", "radialLinear"
        private string _type = null; //  Chart specific.
        private bool _display = true;
        // 'top', 'left', 'bottom' and 'right'.
        private string _position = "left";
        private string _id = null;

        private JsNetFunction _beforeUpdate = null;
        private JsNetFunction _beforeSetDimensions = null;
        private JsNetFunction _afterSetDimensions = null;
        private JsNetFunction _beforeDataLimits = null;
        private JsNetFunction _afterDataLimits = null;
        private JsNetFunction _beforeBuildTicks = null;
        private JsNetFunction _afterBuildTicks = null;
        private JsNetFunction _beforeTickToLabelConversion = null;
        private JsNetFunction _afterTickToLabelConversion = null;
        private JsNetFunction _beforeCalculateTickRotation = null;
        private JsNetFunction _afterCalculateTickRotation = null;
        private JsNetFunction _beforeFit = null;
        private JsNetFunction _afterFit = null;
        private JsNetFunction _afterUpdate = null;

        private ScaleGridLines _gridLines = null;
        private ScaleLabel _scaleLabel = null;
        private ScaleTicks _ticks = null;


        /// <summary>
        /// "category", "linear", "logarithmic", "time", "radialLinear"
        /// </summary>
        private string type { get { return _type; } set { _type = value; } }

        private bool display { get { return _display; } set { _display = value; } }

        /// <summary>
        /// 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        private string position { get { return _position; } set { _position = value; } }
        private string id { get { return _id; } set { _id = value; } }


        private ScaleGridLines gridLines { get { return _gridLines; } set { _gridLines = value; } }
        private ScaleLabel scaleLabel { get { return _scaleLabel; } set { _scaleLabel = value; } }
        private ScaleTicks ticks { get { return _ticks; } set { _ticks = value; } }

        private JsNetFunction beforeUpdate { get { return _beforeUpdate; } set { _beforeUpdate = value; } }
        private JsNetFunction beforeSetDimensions { get { return _beforeSetDimensions; } set { _beforeSetDimensions = value; } }
        private JsNetFunction afterSetDimensions { get { return _afterSetDimensions; } set { _afterSetDimensions = value; } }
        private JsNetFunction beforeDataLimits { get { return _beforeDataLimits; } set { _beforeDataLimits = value; } }
        private JsNetFunction afterDataLimits { get { return _afterDataLimits; } set { _afterDataLimits = value; } }
        private JsNetFunction beforeBuildTicks { get { return _beforeBuildTicks; } set { _beforeBuildTicks = value; } }
        private JsNetFunction afterBuildTicks { get { return _afterBuildTicks; } set { _afterBuildTicks = value; } }
        private JsNetFunction beforeTickToLabelConversion { get { return _beforeTickToLabelConversion; } set { _beforeTickToLabelConversion = value; } }
        private JsNetFunction afterTickToLabelConversion { get { return _afterTickToLabelConversion; } set { _afterTickToLabelConversion = value; } }
        private JsNetFunction beforeCalculateTickRotation { get { return _beforeCalculateTickRotation; } set { _beforeCalculateTickRotation = value; } }
        private JsNetFunction afterCalculateTickRotation { get { return _afterCalculateTickRotation; } set { _afterCalculateTickRotation = value; } }
        private JsNetFunction beforeFit { get { return _beforeFit; } set { _beforeFit = value; } }
        private JsNetFunction afterFit { get { return _afterFit; } set { _afterFit = value; } }
        private JsNetFunction afterUpdate { get { return _afterUpdate; } set { _afterUpdate = value; } }
    }

    public class ScaleGridLines : JsNetBaseClass
    {

    }

    public class ScaleLabel : JsNetBaseClass
    {

    }

    public class ScaleTicks : JsNetBaseClass
    {
        private bool _beginAtZero = true;

        public bool beginAtZero { get { return _beginAtZero; } set { _beginAtZero = value; } }
    }
}
