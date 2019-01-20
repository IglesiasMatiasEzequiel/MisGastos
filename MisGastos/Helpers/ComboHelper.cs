using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MisGastos.Helpers
{
    public static class ComboHelper
    {
        public static IEnumerable<SelectListItem> CreateCombo(IEnumerable<object> list, string propertyValue, string propertyText, string defaultOptionText = null)
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            if (!string.IsNullOrEmpty(defaultOptionText))
            {
                selectListItems.Add(new SelectListItem {Value = "", Text = defaultOptionText});
            }

            if (list != null && list.Any())
            {
                Type objectType = list.First().GetType();

                foreach (object o in list)
                {
                    string value = objectType.GetProperty(propertyValue).GetValue(o).ToString();
                    string text = objectType.GetProperty(propertyText).GetValue(o).ToString();

                    selectListItems.Add(new SelectListItem {Value = value, Text = text});
                }
            }

            return selectListItems;
        }
    }
}