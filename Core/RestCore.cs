using Newtonsoft.Json;
using RestSharp;
using SDETAPI_CSharp.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static SDETAPI_CSharp.Enums.EventTypes;

namespace SDETAPI_CSharp.Core
{
    /// <summary>
    /// Implementation of services request
    /// </summary>
    internal class RestCore
    {
        /// <summary>
        /// Create request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public RestRequest CreateRequestWithHeaders(JsonContent request)
        {
            RestRequest restRequest;

            switch (request.Method.ToUpper())
            {
                case "GET":
                    restRequest = new RestRequest(request.URL, Method.Get);
                    break;

                case "POST":
                    restRequest = new RestRequest(request.URL, Method.Post);
                    break;

                case "PUT":
                    restRequest = new RestRequest(request.URL, Method.Put);
                    break;

                case "DELETE":
                    restRequest = new RestRequest(request.URL, Method.Delete);
                    break;

                default:
                    //An error ocurred
                    string message = $"Rest Method not valid. Must specifiy correctly. Current value: [{request.Method}]" + $"Current valid types: Get and Post";
                    Log.AddEvent(message, LogType.ERROR);
                    throw new NotImplementedException(message);
            }
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public RestRequest CreateRequestBody(RestRequest restRequestParameter,string body)
        {
            restRequestParameter.AddParameter("application/json", body, ParameterType.RequestBody);

            return restRequestParameter;
        }

        /// <summary>
        /// Add request to body and execute
        /// </summary>
        /// <param name="restRequest"></param>
        /// <returns></returns>
        public FeatureResponse ExecuteRequest(RestRequest restRequest)
        {
            RestResponse serviceReponse=new RestResponse();
            FeatureResponse featureResponse = new FeatureResponse();
            try
            {
                //restRequest.AddParameter("application/json;charset=utf-8", ParameterType.RequestBody);
                RestClient restClient = new RestClient();
                serviceReponse = restClient.Execute(restRequest);
             
                featureResponse = JsonConvert.DeserializeObject<FeatureResponse>("{\"status\":\"" + serviceReponse.StatusCode+ "\",\"statusCode\":\"" + (int)serviceReponse.StatusCode+ "\"}");

                //Log response
                Log.AddEvent("Method: " + restRequest.Method.ToString()  +" | Response: "+ (int)serviceReponse.StatusCode + " |URL: " + restRequest.Resource, LogType.NOTIFY);
            }
            catch (Exception ex)
            {
                Log.AddEvent("An error occurred while calling API,"+ ex.ToString()+" | "+restRequest.ToString(), LogType.ERROR);
            }
            return featureResponse;
            //comments abc def ghi jkl mnñ
        }
    }
}
