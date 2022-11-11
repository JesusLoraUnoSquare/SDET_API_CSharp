using RestSharp;
using SDETAPI_CSharp.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Add request to body and execute
        /// </summary>
        /// <param name="restRequest"></param>
        /// <returns></returns>
        public RestResponse ExecuteRequest(RestRequest restRequest)
        {
            RestResponse serviceReponse=new RestResponse();
            try
            {
                //restRequest.AddParameter("application/json;charset=utf-8", ParameterType.RequestBody);
                RestClient restClient = new RestClient();
                serviceReponse = restClient.Execute(restRequest);
                Log.AddEvent(restRequest.Resource, LogType.NOTIFY);

            }
            catch (Exception ex)
            {
                Log.AddEvent("An error occurred while calling API,"+ ex.ToString()+" | "+restRequest.ToString(), LogType.ERROR);
            }
            return serviceReponse;
        }
    }
}
