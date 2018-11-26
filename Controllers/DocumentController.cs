using EssentialEventManagementDocumentAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEventManagementDocumentAPI.Controllers
{
    public class DocumentController : Controller
    {
        protected ILogger _logger { get; set; }

        /// <summary>
        ///     Adjust Subscription
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/Documents/UploadImages")]
        public async Task<IActionResult> UploadImages([FromBody] UploadImagesRequest request)
        {
            throw new NotImplementedException { };
        }
    }
}
