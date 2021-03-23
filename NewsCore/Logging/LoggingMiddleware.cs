using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsCore.Logging
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _request;
        private readonly ILogger _logger;
        public LoggingMiddleware(RequestDelegate request, ILoggerFactory loggerFactory)
        {
            _request = request;
            _logger = loggerFactory.CreateLogger<LoggingMiddleware>();
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                _logger.LogInformation(httpContext.Request.ToString());

                await _request(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex,ex.Message.ToString());
            }
        }
    }
}
