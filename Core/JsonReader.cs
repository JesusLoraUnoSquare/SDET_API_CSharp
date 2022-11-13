using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SDETAPI_CSharp.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDETAPI_CSharp.Enums.EventTypes;

namespace SDETAPI_CSharp.Core
{
    internal class JsonReader
    {
        /// <summary>
        /// Reading a Json file
        /// </summary>
        /// <param name="fileName">File name to read</param>
        /// <returns></returns>
        public JsonContent ReadJsonFile(string path,string fileName)
        {
            string completePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory+path, fileName + ".json");
            JsonContent result = new JsonContent();
            try
            {
               StreamReader streamReader= new StreamReader(completePath);
                string jsonData= streamReader.ReadToEnd();
                streamReader.Close();

                result = JsonConvert.DeserializeObject<JsonContent>(jsonData);
            }
            catch (Exception ex)
            {
                Log.AddEvent(ex.Message+" | "+fileName, LogType.ERROR);
            }
            return result;

        }

        public JsonApiPost ReadJsonPostFile(string path, string fileName)
        {
            string completePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + path, fileName + ".json");
            JsonApiPost result = new JsonApiPost();
            try
            {
                StreamReader streamReader = new StreamReader(completePath);
                string jsonData = streamReader.ReadToEnd();
                streamReader.Close();

                result = JsonConvert.DeserializeObject<JsonApiPost>(jsonData);
            }
            catch (Exception ex)
            {
                Log.AddEvent(ex.Message + " | " + fileName, LogType.ERROR);
            }
            return result;

        }
    }
}
