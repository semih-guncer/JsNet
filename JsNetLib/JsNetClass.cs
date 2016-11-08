using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;

/// <summary>
///   Description : Easy way to use js libraries with Asp.Net 
///   Writen By   : Semih Günçer
///   Namespace   : JsNet
///   Classes     : JsNetClass
/// 
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet
{
    /// <summary>
    /// JsNet Base Class 
    /// </summary>
    public class JsNetBaseClass
    {

    }

    public class JsNetFunction : JsNetBaseClass
    {
        private string _name = "";
        private List<string> _parameters = new List<string>();
        private List<string> _bodyLines = new List<string>();

        public string name { get { return _name; } set { _name = value; } }
        public List<string> parameters { get { return _parameters; } set { _parameters = value; } }
        public List<string> bodyLines { get { return _bodyLines; } set { _bodyLines = value; } }
    }

    /// <summary>
    /// Easy way to use js libraries with Asp.Net 
    /// </summary>
    public class JsNetClass
    {
        protected static string jsonSerialize(JsNetBaseClass o)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            return s.Serialize(o);
        }

        protected static JsNetBaseClass jsonDeserialize(string input, Type targetType)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();

            return (JsNetBaseClass)s.Deserialize(input, targetType);
        }

        protected static void jsonLoad(ref JsNetBaseClass o, string fileName)
        {
            Type targetType = o.GetType();
            string input = File.ReadAllText(fileName);
            o = jsonDeserialize(input, targetType);
        }


        protected static string javascriptSerialize(JsNetBaseClass o, int indentStep)
        {
            StringBuilder retVal = new StringBuilder();
            javascriptSerialize(o, 0, indentStep, ref retVal);
            return retVal.ToString();
        }

        private static void javascriptSerialize(object o, int indentLevel, int indentStep, ref StringBuilder s)
        {
            try
            {
                if (o != null)
                {
                    if (o is sbyte || o is byte || o is short || o is ushort ||
                        o is int || o is uint || o is long || o is ulong)
                        s.Append(o);
                    else if (o is float || o is double)
                    {
                        double od = (double)o;
                        string sod = od.ToString("###0.#").Replace(",", ".");
                        s.Append(sod);
                    }
                    else if (o is bool)
                    {
                        s.Append(o.ToString().ToLower());
                    }
                    else if (o is char)
                    {
                        s.Append("'");
                        s.Append(o);
                        s.Append("'");
                    }
                    else if (o is string)
                    {
                        s.Append('"');
                        s.Append(o);
                        s.Append('"');
                    }
                    else if (o is DateTime)
                    {
                        s.Append('"');
                        DateTime dt = (DateTime)o;
                        s.Append(dt.ToString("yyyy-MM-dd HH:mm:ss:mi"));
                        s.Append('"');
                    }
                    else if (o is IEnumerable)
                    {
                        IEnumerable ao = o as IEnumerable;
                        StringBuilder sa = new StringBuilder();
                        string indent = new String(' ', indentLevel * indentStep);
                        string indentChild = new String(' ', (indentLevel + 1) * indentStep);

                        int ic = 0;
                        foreach (object item in ao)
                        {
                            StringBuilder si = new StringBuilder();
                            javascriptSerialize(item, indentLevel + 1, indentStep, ref si);
                            if (si.Length > 0)
                            {
                                if (ic > 0)
                                {
                                    sa.Append(",");
                                    if (indentStep > 0)
                                        sa.AppendLine();
                                }
                                sa.Append(indentChild);
                                sa.Append(si.ToString());
                                ic = ic + 1;
                            }
                        }
                        if (sa.Length > 0)
                        {
                            s.Append("[");
                            if (indentStep > 0)
                                s.AppendLine();
                            s.Append(sa.ToString());
                            if (indentStep > 0)
                                s.AppendLine();
                            s.Append(indent);
                            s.Append("]");
                        }
                    }
                    else if (o is JsNetFunction)
                    {
                        JsNetFunction of = (JsNetFunction)o;
                        
                        StringBuilder sp = new StringBuilder();
                        for (int i = 0; i < of.parameters.Count; i++)
                        {
                            string item = of.parameters[i].Trim();
                            if (item == "")
                                item = "null";
                            if (i > 0)
                                sp.Append(", ");
                            sp.Append(item);
                        }
                        s.AppendLine(" function " + of.name + "(" + sp.ToString() + ")");
                        s.AppendLine("{");
                        for (int i = 0; i < of.bodyLines.Count; i++)
                        {
                            string item = of.bodyLines[i].Trim();
                            s.AppendLine(item);
                        }
                        s.AppendLine("}");
                    }
                    else
                    {
                        string indent = new String(' ', indentLevel * indentStep);
                        string indentChild = new String(' ', (indentLevel + 1) * indentStep);
                        s.Append("{");
                        if (indentStep > 0)
                            s.AppendLine();
                        Type t = o.GetType();
                        PropertyInfo[] pa = t.GetProperties();
                        int ic = 0;
                        for (int i = 0; i < pa.Length; i++)
                        {
                            PropertyInfo p = pa[i];
                            object item = p.GetValue(o);
                            if (item != null)
                            {
                                StringBuilder si = new StringBuilder();
                                javascriptSerialize(p.GetValue(o), indentLevel + 1, indentStep, ref si);
                                if (si.Length > 0)
                                {
                                    if (ic > 0)
                                    {
                                        s.Append(",");
                                        if (indentStep > 0)
                                            s.AppendLine();
                                    }
                                    s.Append(indentChild);
                                    s.Append(p.Name + ":");
                                    s.Append(si.ToString());
                                    ic = ic + 1;
                                }
                            }
                        }
                        if (indentStep > 0)
                            s.AppendLine();
                        s.Append(indent);
                        s.Append("}");
                    }
                }
                //else
                //    s.Append("null");
            }
            catch
            { }
        }

    }
}
