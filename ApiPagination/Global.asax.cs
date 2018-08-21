using System;
using Newtonsoft.Json;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ApiPagination
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings =
            new JsonSerializerSettings
            {
                Culture = CultureInfo.GetCultureInfo("pt-br"),
                DateFormatString = "dd/MM/yyyy"
            };

        }
    }
}
