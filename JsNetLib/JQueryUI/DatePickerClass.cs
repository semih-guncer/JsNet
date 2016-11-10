using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : JQueryUI DatePicker class
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.JQueryUI
///   Classes     : DatePickerClass
///
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet.JQueryUI
{
     /// <summary>
    /// DatePicker class 
    /// </summary>
    public class DatePickerClass : JsNetBaseClass
    {
        private string _altField = null;
        private string _altFormat = null;
        private string _appendText = null;
        private bool _autoSize = false;

        private JsNetFunction _beforeShow = null;
        private JsNetFunction _beforeShowDay = null;

        private string _buttonImage = null;
        private bool _buttonImageOnly = false;
        private string _buttonText = "...";

        private JsNetFunction _calculateWeek = null;

        private bool _changeMonth = false;
        private bool _changeYear = false;
        private string _closeText = "Done";
        private bool _constrainInput = true;
        private string _currentText = "Today";
        private string _dateFormat = null;
        // [ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ]
        private List<string> _dayNames = null;
        // [ "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" ]
        private List<string> _dayNamesMin = null;
        // [ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" ]
        private List<string> _dayNamesShort = null;
        private string _defaultDate = null;
        // "slow", "normal", "fast"
        private string _duration = "slow";
        private int _firstDay = 0;
        private bool _gotoCurrent = false;
        private bool _hideIfNoPrevNext = false;
        private bool _isRTL = false;
        private string _maxDate = null;
        private string _minDate = null;
        // [ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" ]
        private List<string> _monthNames = null;
        // [ "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" ]
        private List<string> _monthNamesShort = null;
        private bool _navigationAsDateFormat = false;
        private string _nextText = "Next";
        private List<int> _numberOfMonths = null;

        private JsNetFunction _onChangeMonthYear = null;
        private JsNetFunction _onClose = null;
        private JsNetFunction _onSelect = null;

        private string _prevText = "Prev";
        private bool _selectOtherMonths = false;
        private string _shortYearCutoff = "+10";
        // "show", "slideDown", "fadeIn"
        private string _showAnim = "show";
        private bool _showButtonPanel = false;
        private int _showCurrentAtPos = 0;
        private bool _showMonthAfterYear = false;
        // "focus", "button", "both"
        private string _showOn = "focus";
        private ShowOptionsClass _showOptions = null;
        private bool _showOtherMonths = false;
        private bool _showWeek = false;
        private int _stepMonths = 1;
        // "Wk", "W"
        private string _weekHeader = "Wk";
        private string _yearRange = "c-10:c+10";
        private string _yearSuffix = null;


        public string altField { get { return _altField; } set { _altField= value; } }
        public string altFormat { get { return _altFormat; } set { _altFormat= value; } }
        public string appendText { get { return _appendText; } set { _appendText= value; } }
        public bool autoSize { get { return _autoSize; } set { _autoSize= value; } }

        public JsNetFunction beforeShow { get { return _beforeShow; } set { _beforeShow= value; } }
        public JsNetFunction beforeShowDay { get { return _beforeShowDay; } set { _beforeShowDay= value; } }

        public string buttonImage { get { return _buttonImage; } set { _buttonImage= value; } }
        public bool buttonImageOnly { get { return _buttonImageOnly; } set { _buttonImageOnly= value; } }
        public string buttonText { get { return _buttonText; } set { _buttonText= value; } }

        public JsNetFunction calculateWeek { get { return _calculateWeek; } set { _calculateWeek= value; } }

        public bool changeMonth { get { return _changeMonth; } set { _changeMonth= value; } }
        public bool changeYear  { get { return _changeYear; } set { _changeYear= value; } }
        public string closeText { get { return _closeText; } set { _closeText= value; } }
        public bool constrainInput { get { return _constrainInput; } set { _constrainInput= value; } }
        public string currentText { get { return _currentText; } set { _currentText= value; } }
        public string dateFormat { get { return _dateFormat; } set { _dateFormat= value; } }
        
        ///<summary>
        /// Default : [ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ]
        ///</summary>
        public List<string> dayNames { get { return _dayNames; } set { _dayNames= value; } }

        ///<summary>
        /// Default : [ "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" ]
        ///</summary>
        public List<string> dayNamesMin { get { return _dayNamesMin; } set { _dayNamesMin= value; } }

        ///<summary>
        /// Default : [ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" ]
        ///</summary>
        public List<string>  dayNamesShort { get { return _dayNamesShort; } set { _dayNamesShort= value; } }
        public string defaultDate { get { return _defaultDate; } set { _defaultDate= value; } }

        ///<summary>
        /// "slow", "normal", "fast"
        ///</summary>
        public string duration { get { return _duration; } set { _duration= value; } }
        public int firstDay { get { return _firstDay; } set { _firstDay= value; } }
        public bool gotoCurrent { get { return _gotoCurrent; } set { _gotoCurrent= value; } }
        public bool hideIfNoPrevNext { get { return _hideIfNoPrevNext; } set { _hideIfNoPrevNext= value; } }
        public bool isRTL { get { return _isRTL; } set { _isRTL= value; } }
        public string maxDate { get { return _maxDate; } set { _maxDate= value; } }
        public string minDate { get { return _minDate; } set { _minDate= value; } }

        ///<summary>
        /// Default : [ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" ]
        ///</summary>
        public List<string> monthNames { get { return _monthNames; } set { _monthNames= value; } }

        ///<summary>
        /// Default : [ "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" ]
        ///</summary>
        public List<string> monthNamesShort { get { return _monthNamesShort; } set { _monthNamesShort= value; } }
        public bool navigationAsDateFormat { get { return _navigationAsDateFormat; } set { _navigationAsDateFormat= value; } }
        public string nextText { get { return _nextText; } set { _nextText= value; } }
        public List<int> numberOfMonths { get { return _numberOfMonths; } set { _numberOfMonths= value; } }

        public JsNetFunction onChangeMonthYear { get { return _onChangeMonthYear; } set { _onChangeMonthYear= value; } }
        public JsNetFunction onClose { get { return _onClose; } set { _onClose= value; } }
        public JsNetFunction onSelect { get { return _onSelect; } set { _onSelect= value; } }

        public string prevText { get { return _prevText; } set { _prevText= value; } }
        public bool selectOtherMonths { get { return _selectOtherMonths; } set { _selectOtherMonths= value; } }
        public string shortYearCutoff { get { return _shortYearCutoff; } set { _shortYearCutoff= value; } }
        
        ///<summary>
        /// "show", "slideDown", "fadeIn"
        ///</summary>
        public string showAnim { get { return _showAnim; } set { _showAnim= value; } }
        public bool showButtonPanel { get { return _showButtonPanel; } set { _showButtonPanel= value; } }
        public int showCurrentAtPos { get { return _showCurrentAtPos; } set { _showCurrentAtPos= value; } }
        public bool showMonthAfterYear { get { return _showMonthAfterYear; } set { _showMonthAfterYear= value; } }

        ///<summary>
        /// "focus", "button", "both"
        ///</summary>
        public string showOn { get { return _showOn; } set { _showOn= value; } }
        public ShowOptionsClass showOptions { get { return _showOptions; } set { _showOptions= value; } }
        public bool showOtherMonths { get { return _showOtherMonths; } set { _showOtherMonths= value; } }
        public bool showWeek { get { return _showWeek; } set { _showWeek= value; } }
        public int stepMonths { get { return _stepMonths; } set { _stepMonths= value; } }

        ///<summary>
        /// "Wk", "W"
        ///</summary>
        public string weekHeader { get { return _weekHeader; } set { _weekHeader= value; } }
        public string yearRange { get { return _yearRange; } set { _yearRange= value; } }
        public string yearSuffix { get { return _yearSuffix; } set { _yearSuffix= value; } }
    }

    public class ShowOptionsClass : JsNetBaseClass
    {
        private string _direction = "up";

        ///<summary>
        /// "up", "left", "down", "right"
        ///</summary>
        public string direction { get { return _direction; } set { _direction= value; } }
    }

}
