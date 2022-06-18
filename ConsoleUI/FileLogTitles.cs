using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public enum FileLogTitles
    {

        /// <summary>
        /// File Location: ..BsnBase.WebApi\Controllers\Base\ErrorController.cs
        /// </summary>
        [Description("BEC")]
        BaseErrorController,

        /// <summary>
        /// File Location: ..BsnBase.WebApi\Middlewares\LoggingMiddleware.cs
        /// </summary>
        [Description("WLM")]
        WebApiLoggingMiddleware,

        /// <summary>
        /// File Location: ..BsnBase.WebApi\Controllers\Base\HealthCheckController.cs
        /// </summary>
        [Description("HCC")]
        HealthCheckController,

        /// <summary>
        /// File Location: ..BsnBase.Core\Providers\BsnApi\BsnApiProvider.cs
        /// </summary>
        [Description("BAP")]
        BsnApiProvider,

    }

    public static class FileLogExtension
    {
        public static string ToDesctiption(this FileLogTitles val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}

