using System;
using System.Web;
using System.Web.Mvc;

namespace MisGastos.Entities.Helpers
{
    public static class CustomHtmlHelper
    {
        public static IHtmlString ConGuion(this HtmlHelper htmlHelper, string value)
        {
            return ConDefault(htmlHelper, value, "-");
        }

        public static IHtmlString ConGuion(this HtmlHelper htmlHelper, DateTime? value)
        {
            return ConDefault(htmlHelper, value, "-");
        }

        public static IHtmlString ConDefault(this HtmlHelper htmlHelper, string value, string valueDefault = "")
        {
            return new HtmlString(!string.IsNullOrEmpty(value) ? value : valueDefault);
        }

        public static IHtmlString ConDefault(this HtmlHelper htmlHelper, DateTime? value, string valueDefault = "")
        {
            return ConDefault(htmlHelper, value?.ToShortDateString(), valueDefault);
        }
    }
}