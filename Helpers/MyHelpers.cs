using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWebApp.Helpers
{
    public static class MyHelpers
    {
        public static HtmlString Select<T, TVal>(this IHtmlHelper html, IEnumerable<T> xs, string valName, string txtName, TVal selected)
        {
            var val = typeof(T).GetProperty(valName);
            var txt = typeof(T).GetProperty(txtName);
            StringBuilder sb = new();
            sb.Append($"<select>");
            foreach(T x in xs)
            {
                sb.Append($"<option value=\"{val.GetValue(x)}");
                sb.Append($">{txt.GetValue(x)}</option>");
            }
            sb.Append("</select>");
            return new HtmlString(sb.ToString());
        }
    }
}
