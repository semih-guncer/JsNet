using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsNet.ChartJs
{
    public class xConfigPolarArea
    {
        private string _type = "polarArea"; // { line, bar, radar, polarArea, pie, doughnut, bubble }
        private DataClass _data = new DataClass();
        private OptionsClass _options = new OptionsClass();

        public string type { get { return _type; } }
        public DataClass data { get { return _data; } set { _data = value; } }
        public OptionsClass options { get { return _options; } set { _options = value; } }

        public class DataClass
        {
            private List<string> _labels = new List<string>();
            private List<string> _xLabels = new List<string>();
            private List<string> _yLabels = new List<string>();
            private List<DataSetClass> _dataset = new List<DataSetClass>();

            public List<string> labels { get { return _labels; } set { _labels = value; } }
            public List<string> xLabels { get { return _xLabels; } set { _xLabels = value; } }
            public List<string> yLabels { get { return _yLabels; } set { _yLabels = value; } }
            public List<DataSetClass> dataset { get { return _dataset; } set { _dataset = value; } }

        }
        public class DataSetClass
        {
            public string _label = "";
            public List<double> _data = new List<double>();
            public List<string> _backgroundColor = new List<string>();
            public List<string> _borderColor = new List<string>();
            public int _borderWidth = 0;
            
            public string label { get { return _label; } set { _label = value; } }
            public List<double> data { get { return _data; } set { _data = value; } }
            public List<string> backgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
            public List<string> borderColor { get { return _borderColor; } set { _borderColor = value; } }
            public int borderWidth { get { return _borderWidth; } set { _borderWidth = value; } }
        }

        public class OptionsClass
        {
            private bool _responsive = true;
            private int _responsiveAnimationDuration = 0;
            private bool _maintainAspectRatio = true;
            private List<string> _events = new List<string>();
            public TitleClass _title = null;
            //Function onClick = null;
            //Function legendCallback = function (chart) { }
            //Function onResize = null;

            public bool responsive { get { return _responsive; } set { _responsive = value; } }
            public int responsiveAnimationDuration { get { return _responsiveAnimationDuration; } set { _responsiveAnimationDuration = value; } }
            public bool maintainAspectRatio { get { return _maintainAspectRatio; } set { _maintainAspectRatio = value; } }
            public List<string> events { get { return _events; } set { _events = value; } }
            public TitleClass title { get { return _title; } set { _title = value; } }
        }

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
}
