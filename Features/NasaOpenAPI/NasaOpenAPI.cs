using RestSharp;
using SDETAPI_CSharp.Core;
using SDETAPI_CSharp.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static SDETAPI_CSharp.Enums.EventTypes;

namespace SDETAPI_CSharp.Features.NasaOpenAPI
{
    internal class NasaOpenAPI
    {
        private SDETAPI_CSharp.Core.JsonReader jsonReader;

        public string ValidateAPI(string path, string fileName)
        {
            string result = "";


            try
            {
                if (ValidationFiles.ValidateIfJsonFileExists(path, fileName))
                {
                    jsonReader = new SDETAPI_CSharp.Core.JsonReader();
                    Core.JsonContent jsonContent = jsonReader.ReadJsonFile(path, fileName);

                    RestCore restCore = new RestCore();
                    RestRequest restRequest = restCore.CreateRequestWithHeaders(jsonContent);

                    RestResponse restResponse = restCore.ExecuteRequest(restRequest);


                    if (restResponse.StatusCode == HttpStatusCode.OK && restResponse.IsSuccessful)
                    {
                        result = "OK";
                    }
                    else
                    {
                        result = "An error occurred, status code response: " + restResponse.StatusCode + " | " + restResponse.ErrorMessage + " | ErrorExeption: " + restResponse.ErrorMessage + " | ContentResponse: " + restResponse.Content + " | file path: " + path + " | FileName: " + fileName;
                        Log.AddEvent(result, LogType.ERROR);
                    }
                }
                else
                {
                    result = "The file requested doesnt exists | file path: " + path + " | FileName: " + fileName + " | Your request will not be process";
                    Log.AddEvent(result, LogType.ERROR);
                }
            }
            catch (Exception ex)
            {
                result = "An error occurred while calling API, file path: " + path + " | FileName: " + fileName;
                Log.AddEvent(result + " | " + ex.Message, LogType.ERROR);
            }


            return result;
        }
    }
}
