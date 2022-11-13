using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Core
{
    /// <summary>
    /// Read response API statusCode using LINQ
    /// </summary>
    internal class ReadResponseLinq
    {
        public static string ValidateResponseUsingLinq(FeatureResponse featureResponse)
        {
            string json = JsonConvert.SerializeObject(featureResponse);

            JObject jObj = JObject.Parse(json);
            var value = (string)jObj.Descendants()
                                .OfType<JProperty>()
                                .Where(p => p.Name == "statusCode")
    .First()
                                .Value;

            return value;
        }

    }
}
