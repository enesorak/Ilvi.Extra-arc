﻿using Microsoft.AspNetCore.Mvc;
using Presentation.Exceptions;

namespace Presentation.Controllers
{
    [Route("errors/{code:int}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : BaseApiController
    {

        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
