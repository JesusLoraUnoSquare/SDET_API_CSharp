using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SDETAPI_CSharp.Core;
using SDETAPI_CSharp.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static SDETAPI_CSharp.Enums.EventTypes;

namespace SDETAPI_CSharp.Features.HealthCareGov
{
    internal class HealthCareGov
    {
        private SDETAPI_CSharp.Core.JsonReader jsonReader;

        public FeatureResponse ValidateAPI(string path,string fileName)
        {
            FeatureResponse featureResponse = new FeatureResponse();


            try
            {
                if (ValidationFiles.ValidateIfJsonFileExists(path, fileName))
                {
                    jsonReader = new SDETAPI_CSharp.Core.JsonReader();
                    Core.JsonContent jsonContent = jsonReader.ReadJsonFile(path, fileName);

                    RestCore restCore = new RestCore();
                    RestRequest restRequest = restCore.CreateRequestWithHeaders(jsonContent);

                    featureResponse = restCore.ExecuteRequest(restRequest);

                    string estatus = ReadResponseLinq.ValidateResponseUsingLinq(featureResponse);

                    if (estatus != "200")
                    {
                        Log.AddEvent("An error occurred, status code response: " + featureResponse.statusCode + " | file path: " + path + " | FileName: " + fileName, LogType.ERROR);
                    }
                }
                else
                {
                    Log.AddEvent("The file requested doesnt exists | file path: " + path + " | FileName: " + fileName + " | Your request will not be process", LogType.ERROR);
                }
            }
            catch (Exception ex)
            {
                Log.AddEvent("An error occurred while calling API, file path: " + path + " | FileName: " + fileName + " | " + ex.Message, LogType.ERROR);
            }


            return featureResponse;
        }

    }
}
