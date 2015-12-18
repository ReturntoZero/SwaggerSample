using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    /// <summary>
    /// Swagger 範例
    /// </summary>
    public class SwaggerDocController : ApiController
    {
       
        /// <summary>
        /// 取得所有學生資料
        /// </summary>
        /// <remarks>取回所有學生資料</remarks>
        /// <response code="500">Internal Server Error</response>
        public string Get()
        {
            return "Hello";
        }
    }
}
