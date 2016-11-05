using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : Title class
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.ChartJs
///   Classes     : TitleClass
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.ChartJs
{
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
}
