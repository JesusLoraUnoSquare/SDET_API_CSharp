using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETAPI_CSharp.Core
{
    /// <summary>
    /// Objet Json that contains URL/Method
    /// </summary>
    class JsonContent
    {
        private string method = "";
        private string uRL = "";

        public string Method { get => method; set => method = value; }
        public string URL { get => uRL; set => uRL = value; }
    }
}
