using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsNet.ChartJs
{
    public class xConfigDoughnut
    {
        private string _type = "doughnut"; // { line, bar, radar, polarArea, pie, doughnut, bubble }
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
            public List<DataSetClass> datasets { get { return _dataset; } set { _dataset = value; } }

        }
        public class DataSetClass
        {
            private List<double> _data = new List<double>();
            private string _label = "";

            private List<string> _backgroundColor = new List<string>();
            private List<string> _borderColor = new List<string>();
            private int _borderWidth = 0;

            private List<string> _hoverBackgroundColor = new List<string>();
            private List<string> _hoverBorderColor = new List<string>();
            private int _hoverBorderWidth = 0;

            public List<double> data { get { return _data; } set { _data = value; } }
            public string label { get { return _label; } set { _label = value; } }

            public List<string> backgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
            public List<string> borderColor { get { return _borderColor; } set { _borderColor = value; } }
            public int borderWidth { get { return _borderWidth; } set { _borderWidth = value; } }

            public List<string> hoverBackgroundColor { get { return _hoverBackgroundColor; } set { _hoverBackgroundColor = value; } }
            public List<string> hoverBorderColor { get { return _hoverBorderColor; } set { _hoverBorderColor = value; } }
            public int hoverBorderWidth { get { return _hoverBorderWidth; } set { _hoverBorderWidth = value; } }
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
    }
}
