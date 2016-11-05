﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;

/// <summary>
///   Namespace   : JsNet
///   Description : Easy way to use js libraries with Asp.Net 
///   Writen By   : Semih Günçer
///   Date       Author               Description
///   ---------- -------------------- -------------------------------------------------
///   
/// </summary>
namespace JsNet
{
    /// <summary>
    /// Easy way to use js libraries with Asp.Net 
    /// </summary>
    public class JsNetClass
    {
        protected static string jsonSerialize(object o)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            return s.Serialize(o);
        }

        protected static object jsonDeserialize(string input, Type targetType)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();

            return s.Deserialize(input, targetType);
        }
        protected static object jsonDeserialize<T>(string input)
        {
            JavaScriptSerializer s = new JavaScriptSerializer();

            return s.Deserialize<T>(input);
        }

        protected static object jsonLoad<T>(string fileName)
        {
            string input = File.ReadAllText(fileName);
            return jsonDeserialize<T>(input);
        }


        protected static string javascriptSerialize(object o, int indentStep)
        {
            StringBuilder retVal = new StringBuilder();
            javascriptSerialize(o, 0, indentStep, ref retVal);
            return retVal.ToString();
        }

        protected static void javascriptSerialize(object o, int indentLevel, int indentStep, ref StringBuilder s)
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
                        s.Append(o);
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