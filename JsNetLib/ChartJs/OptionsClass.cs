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
    public class OptionsClass
    {
        private bool _responsive = true;
        private int _responsiveAnimationDuration = 0;
        private bool _maintainAspectRatio = true;
        private List<string> _events = new List<string>();
        private TitleClass _title = null;
        private HoverClass _hover = null;
        private TooltipClass _tooltip = null;
        private LegendClass _legend = null;
        private List<ScaleClass> _scales = null;

        public bool responsive { get { return _responsive; } set { _responsive = value; } }
        public int responsiveAnimationDuration { get { return _responsiveAnimationDuration; } set { _responsiveAnimationDuration = value; } }
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
    public class TitleClass
    {
        private bool _display = false;
        private string _position = "top";
        private bool _fullWidth = true;
        private int _fontSize = 12;
        private string _fontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
        private string _fontColor = "#666";
        private string _fontStyle = "bold";
        private int _padding = 10;
        private string _text = "";

        public bool display { get { return _display; } set { _display = value; } }
        public string position { get { return _position; } set { _position = value; } }
        public bool fullWidth { get { return _fullWidth; } set { _fullWidth = value; } }
        public int fontSize { get { return _fontSize; } set { _fontSize = value; } }
        public string fontFamily { get { return _fontFamily; } set { _fontFamily = value; } }
        public string fontColor { get { return _fontColor; } set { _fontColor = value; } }
        public string fontStyle { get { return _fontStyle; } set { _fontStyle = value; } }
        public int padding { get { return _padding; } set { _padding = value; } }
        public string text { get { return _text; } set { _text = value; } }
    }

    public class HoverClass
    {
        public string _mode = "single";
        public int _animationDuration = 400;

        /// <summary>
        /// ['single', 'label', 'x-axis', 'dataset'.]
        /// </summary>
        public string mode { get { return _mode; } set { _mode = value; } }
        public int animationDuration { get { return _animationDuration; } set { _animationDuration = value; } }
        
        // onHover Function 	null 
    }

    public class TooltipClass
    {
        public bool _enabled = true;
        //custom Function 	null 
        public string _mode = "single";
        //itemSort Function    undefined
        public string _backgroundColor = "rgba(0,0,0,0.8)";
        public string _titleFontFamily = "Helvetica";
        public int _titleFontSize = 12;
        public string _titleFontStyle = "bold";
        public string _titleFontColor = "#fff";
        public int _titleSpacing = 2;
        public int _titleMarginBottom = 6;
        public string _bodyFontFamily = "Helvetica";
        public int _bodyFontSize = 12;
        public string _bodyFontStyle = "normal";
        public string _bodyFontColor = "#fff";
        public int _bodySpacing = 2;
        public string _footerFontFamily = "Helvetica";
        public int _footerFontSize = 12;
        public string _footerFontStyle = "bold";
        public string _footerFontColor = "#fff";
        public int _footerSpacing = 2;
        public int _footerMarginTop = 6;
        public int _xPadding = 6;
        public int _yPadding = 6;
        public int _caretSize = 5;
        public int _cornerRadius = 6;
        public string _multiKeyBackground = "#fff";
        //callbacks Object


        public bool enabled { get { return _enabled; } set { _enabled = value; } }
        
        //custom Function 	null 

        public string mode { get { return _mode; } set { _mode = value; } }
        
        //itemSort Function    undefined

        public string backgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
        public string titleFontFamily { get { return _titleFontFamily; } set { _titleFontFamily = value; } }
        public int titleFontSize { get { return _titleFontSize; } set { _titleFontSize = value; } }
        public string titleFontStyle { get { return _titleFontStyle; } set { _titleFontStyle = value; } }
        public string titleFontColor { get { return _titleFontColor; } set { _titleFontColor = value; } }
        public int titleSpacing { get { return _titleSpacing; } set { _titleSpacing = value; } }
        public int titleMarginBottom { get { return _titleMarginBottom; } set { _titleMarginBottom = value; } }
        public string bodyFontFamily { get { return _bodyFontFamily; } set { _bodyFontFamily = value; } }
        public int bodyFontSize { get { return _bodyFontSize; } set { _bodyFontSize = value; } }
        public string bodyFontStyle { get { return _bodyFontStyle; } set { _bodyFontStyle = value; } }
        public string bodyFontColor { get { return _bodyFontColor; } set { _bodyFontColor = value; } }
        public int bodySpacing { get { return _bodySpacing; } set { _bodySpacing = value; } }
        public string footerFontFamily { get { return _footerFontFamily; } set { _footerFontFamily = value; } }
        public int footerFontSize { get { return _footerFontSize; } set { _footerFontSize = value; } }
        public string footerFontStyle { get { return _footerFontStyle; } set { _footerFontStyle = value; } }
        public string footerFontColor { get { return _footerFontColor; } set { _footerFontColor = value; } }
        public int footerSpacing { get { return _footerSpacing; } set { _footerSpacing = value; } }
        public int footerMarginTop { get { return _footerMarginTop; } set { _footerMarginTop = value; } }
        public int xPadding { get { return _xPadding; } set { _xPadding = value; } }
        public int yPadding { get { return _yPadding; } set { _yPadding = value; } }
        public int caretSize { get { return _caretSize; } set { _caretSize = value; } }
        public int cornerRadius { get { return _cornerRadius; } set { _cornerRadius = value; } }
        public string multiKeyBackground { get { return _multiKeyBackground; } set { _multiKeyBackground = value; } }
        
        //callbacks Object

    }

    /// <summary>
    /// Legend class not implemented
    /// </summary>
    public class LegendClass
    {

    }


    /// <summary>
    /// Scale class not implemented
    /// </summary>
    public class ScaleClass
    {

    }

}
