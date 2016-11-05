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
namespace JsNet.ChartJs
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
