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
            var prop = typeof(T).GetProperty(valName);
            IEnumerable<TVal> values = xs.Select(x => (TVal)prop.GetValue(x));
            StringBuilder sb = new();
            sb.Append($"<select id=\"{ nameof(T) + valName }\" name=\"{ txtName }\">");
            foreach(TVal val in values)
            {
                sb.Append("<option ");
                if (val.Equals(selected))
                    sb.Append("selected");
                sb.Append($">{val}</option>");
            }
            sb.Append("</select>");
            return new HtmlString(sb.ToString());
        }
    }
}
