using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Core
{

    /// <summary>
    /// test comment 3
    /// </summary>
    public  class ValidationFiles
    {
        /// <summary>
        /// Method to validate if the file requested exists
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static  bool ValidateIfJsonFileExists(string path, string fileName)
        {
            bool result = false;

            result = File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + path, fileName + ".json")) ? true : false;

            return result;
        }
    }
}
