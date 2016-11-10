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
        public static void Load(ref DatePickerClass o, string fileName)
        {
            JsNetBaseClass ob = o;
            jsonLoad(ref ob, fileName);
            o = (DatePickerClass)ob;
        }

        public static string Serialize(DatePickerClass datePicker, int indentStep)
        {
            return JsNetClass.javascriptSerialize(datePicker, indentStep);
        }

    }
}
