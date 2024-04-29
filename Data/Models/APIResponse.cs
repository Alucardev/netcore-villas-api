using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool Error { get; set; } 
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
