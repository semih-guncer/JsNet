using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JsNet;
using JsNet.JQueryUI;

namespace JsNetLibDemo.JQueryUI
{
    public partial class DatePicker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string GetExampleDatePicker()
        {
            string templateFile = Server.MapPath("TemplateDatePicker.json");
            DatePickerClass c = new DatePickerClass();
            JQueryUINet.Load(ref c, templateFile);

            return JQueryUINet.Serialize(c, 2);
        }

        public string GetExampleDatePicker(string languageName)
        {
            string templateFile = Server.MapPath("TemplateDatePicker.json");
            string languageFile = Server.MapPath("i18n/DatePicker_" + languageName + ".json");
            DatePickerClass c = new DatePickerClass();
            JQueryUINet.Load(ref c, templateFile, languageFile);

            return JQueryUINet.Serialize(c, 2);
        }

        public string GetInitFunction()
        {
            string templateFile = Server.MapPath("TemplateInitFunction.json");
            JsNetFunction c = new JsNetFunction();
            JsNetClass.Load(ref c, templateFile);
            
            return JsNetClass.Serialize(c, 2);
        }
    }
}