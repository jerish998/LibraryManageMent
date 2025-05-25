using System.Diagnostics;

namespace LibraryManagementSys.Middlewares
{
    // Middlewares/RequestLoggingMiddleware.cs
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();

            _logger.LogInformation("Handling request: {method} {url}",
                context.Request.Method,
                context.Request.Path);

            await _next(context);

            watch.Stop();
            _logger.LogInformation("Finished handling request. Took {time} ms", watch.ElapsedMilliseconds);
        }
    }

}
