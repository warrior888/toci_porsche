using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Web.Http;
using Toci.CarRentsl.Api.Areas.HelpPage;

namespace Toci.CarRentsl.Api.Areas.CarRental.App_Start
{
    public class HelpPageConfig
    {
        [SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters",
            MessageId = "Toci.CarRentsl.Api.Areas.HelpPage.TextSample.#ctor(System.String)",
            Justification = "End users may choose to merge this string with existing localized resources.")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly",
            MessageId = "bsonspec",
            Justification = "Part of a URI.")]
        public static void Register(HttpConfiguration config)
        {
            config.SetSampleForMediaType(
                new TextSample("Binary JSON content. See http://bsonspec.org for details."),
                new MediaTypeHeaderValue("application/json"));
        }
    }
}