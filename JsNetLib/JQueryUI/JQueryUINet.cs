using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   Description : JsNet Serializer for JQueryUI
///   Writen By   : Semih Günçer
///   Namespace   : JsNet.JQueryUI
///   Classes     : JQueryUINet
///   
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>

namespace JsNet.JQueryUI
{
    public class JQueryUINet : JsNetClass
    {
        public static void Load(ref DatePickerClass o, string fileName, string i18nFileName)
        {
            Load(ref o, fileName);
            DatePicker_i18n_Class i18n = new DatePicker_i18n_Class();
            Load(ref i18n, i18nFileName);
            ApplyLanguage(ref o, i18n);
        }

        public static void Load(ref DatePickerClass o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (DatePickerClass)ob;
        }

        public static void Load(ref DatePicker_i18n_Class i18n, string i18nFileName)
        {
            JsNetBaseClass ob = i18n;
            jsonLoad(ref ob, i18nFileName);
            i18n = (DatePicker_i18n_Class)ob;
        }

        public static void ApplyLanguage(ref DatePickerClass o, DatePicker_i18n_Class i18n)
        {
            o.closeText = i18n.closeText;
            o.currentText = i18n.currentText;
            o.dateFormat = i18n.dateFormat;
            o.dayNames = i18n.dayNames;
            o.dayNamesMin = i18n.dayNamesMin;
            o.dayNamesShort = i18n.dayNamesShort;
            o.firstDay = i18n.firstDay;
            o.isRTL = i18n.isRTL;
            o.monthNames = i18n.monthNames;
            o.monthNamesShort = i18n.monthNamesShort;
            o.nextText = i18n.nextText;
            o.prevText = i18n.prevText;
            o.showMonthAfterYear = i18n.showMonthAfterYear;
            o.weekHeader = i18n.weekHeader;
            o.yearSuffix = i18n.yearSuffix;            
        }

        public static string Serialize(DatePickerClass datePicker, int indentStep)
        {
            return JsNetClass.javascriptSerialize(datePicker, indentStep);
        }

    }
}
