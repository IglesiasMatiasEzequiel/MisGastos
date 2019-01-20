using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MisGastos.Entities.Helpers
{
    public class ValidationSummary
    {
        public static string GetErrorList(ModelStateDictionary modelState)
        {
            string errorList = string.Empty;

            if (modelState != null)
            {
                var errors = modelState.Where(n => n.Value.Errors.Count > 0);

                foreach (var error in errors)
                {
                    errorList += "'" + error.Value.Errors.First().ErrorMessage + (error.Equals(errors.Last()) ? "'" : "',");
                }
            }

            return HttpUtility.JavaScriptStringEncode(errorList);
        }

    }
}