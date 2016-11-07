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
        private string _altField = "";
        private string _altFormat = "";
        private string _appendText = "";
        private bool _autoSize = false;
        //private FUNCTION _beforeShow = null;
        //private FUNCTION _beforeShowDay = null;
        private string _buttonImage = "";
        private bool _buttonImageOnly = false;
        private string _buttonText = "...";
        //private FUNCTION _calculateWeek = null;
        private bool _changeMonth = false;
        private bool _changeYear = false;
        private string _closeText = "Done";
        private bool _constrainInput = true;
        private string _currentText = "Today";
        private string _dateFormat = "yyyy-mm-dd";
        // [ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ]
        private List<string> _dayNames = null;
        // [ "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" ]
        private List<string> _dayNamesMin = null;
        // [ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" ]
        private List<string>  _dayNamesShort = null;
        private string _defaultDate = "";
        // "slow", "normal", "fast"
        private string _duration = "slow";
        private int _firstDay = 0;
        private bool _gotoCurrent = false;
        private bool _hideIfNoPrevNext = false;
        private bool _isRTL = false;
        private string _maxDate = "";
        private string _minDate = "";
        // [ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" ]
        private List<string> _monthNames = null;
        // [ "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" ]
        private string _monthNamesShort = "";
        private bool _navigationAsDateFormat = false;
        private string _nextText = "Next";
        private List<int> _numberOfMonths = null;
        //private FUNCTION _onChangeMonthYear = null;
        //private FUNCTION _onClose = null;
        //private FUNCTION _onSelect = null;
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
        private string _yearSuffix = "";


        public string altField { get { return _altField; } set { value = _altField; } }
        public string altFormat { get { return _altFormat; } set { value = _altFormat; } }
        public string appendText { get { return _appendText; } set { value = _appendText; } }
        public bool autoSize { get { return _autoSize; } set { value = _autoSize; } }
        //public FUNCTION beforeShow = null;
        //public FUNCTION beforeShowDay = null;
        public string buttonImage { get { return _buttonImage; } set { value = _buttonImage; } }
        public bool buttonImageOnly { get { return _buttonImageOnly; } set { value = _buttonImageOnly; } }
        public string buttonText { get { return _buttonText; } set { value = _buttonText; } }
        //public FUNCTION calculateWeek = null
        public bool changeMonth { get { return _changeMonth; } set { value = _changeMonth; } }
        public bool changeYear  { get { return _changeYear; } set { value = _changeYear; } }
        public string closeText { get { return _closeText; } set { value = _closeText; } }
        public bool constrainInput { get { return _constrainInput; } set { value = _constrainInput; } }
        public string currentText { get { return _currentText; } set { value = _currentText; } }
        public string dateFormat { get { return _dateFormat; } set { value = _dateFormat; } }
        
        ///<summary>
        /// Default : [ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ]
        ///</summary>
        public List<string> dayNames { get { return _dayNames; } set { value = _dayNames; } }

        ///<summary>
        /// Default : [ "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" ]
        ///</summary>
        public List<string> dayNamesMin { get { return _dayNamesMin; } set { value = _dayNamesMin; } }

        ///<summary>
        /// Default : [ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" ]
        ///</summary>
        public List<string>  dayNamesShort { get { return _dayNamesShort; } set { value = _dayNamesShort; } }
        public string defaultDate { get { return _defaultDate; } set { value = _defaultDate; } }

        ///<summary>
        /// "slow", "normal", "fast"
        ///</summary>
        public string duration { get { return _duration; } set { value = _duration; } }
        public int firstDay { get { return _firstDay; } set { value = _firstDay; } }
        public bool gotoCurrent { get { return _gotoCurrent; } set { value = _gotoCurrent; } }
        public bool hideIfNoPrevNext { get { return _hideIfNoPrevNext; } set { value = _hideIfNoPrevNext; } }
        public bool isRTL { get { return _isRTL; } set { value = _isRTL; } }
        public string maxDate { get { return _maxDate; } set { value = _maxDate; } }
        public string minDate { get { return _minDate; } set { value = _minDate; } }

        ///<summary>
        /// Default : [ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" ]
        ///</summary>
        public List<string> monthNames { get { return _monthNames; } set { value = _monthNames; } }

        ///<summary>
        /// Default : [ "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" ]
        ///</summary>
        public string monthNamesShort { get { return _monthNamesShort; } set { value = _monthNamesShort; } }
        public bool navigationAsDateFormat { get { return _navigationAsDateFormat; } set { value = _navigationAsDateFormat; } }
        public string nextText { get { return _nextText; } set { value = _nextText; } }
        public List<int> numberOfMonths { get { return _numberOfMonths; } set { value = _numberOfMonths; } }
        //private FUNCTION onChangeMonthYear = null;
        //private FUNCTION onClose = null;
        //private FUNCTION onSelect = null;
        public string prevText { get { return _prevText; } set { value = _prevText; } }
        public bool selectOtherMonths { get { return _selectOtherMonths; } set { value = _selectOtherMonths; } }
        public string shortYearCutoff { get { return _shortYearCutoff; } set { value = _shortYearCutoff; } }
        
        ///<summary>
        /// "show", "slideDown", "fadeIn"
        ///</summary>
        public string showAnim { get { return _showAnim; } set { value = _showAnim; } }
        public bool showButtonPanel { get { return _showButtonPanel; } set { value = _showButtonPanel; } }
        public int showCurrentAtPos { get { return _showCurrentAtPos; } set { value = _showCurrentAtPos; } }
        public bool showMonthAfterYear { get { return _showMonthAfterYear; } set { value = _showMonthAfterYear; } }

        ///<summary>
        /// "focus", "button", "both"
        ///</summary>
        public string showOn { get { return _showOn; } set { value = _showOn; } }
        public ShowOptionsClass showOptions { get { return _showOptions; } set { value = _showOptions; } }
        public bool showOtherMonths { get { return _showOtherMonths; } set { value = _showOtherMonths; } }
        public bool showWeek { get { return _showWeek; } set { value = _showWeek; } }
        public int stepMonths { get { return _stepMonths; } set { value = _stepMonths; } }

        ///<summary>
        /// "Wk", "W"
        ///</summary>
        public string weekHeader { get { return _weekHeader; } set { value = _weekHeader; } }
        public string yearRange { get { return _yearRange; } set { value = _yearRange; } }
        public string yearSuffix { get { return _yearSuffix; } set { value = _yearSuffix; } }
    }

    public class ShowOptionsClass : JsNetBaseClass
    {
        private string _direction = "up";

        ///<summary>
        /// "up", "left", "down", "right"
        ///</summary>
        public string direction { get { return _direction; } set { value = _direction; } }
    }

}
