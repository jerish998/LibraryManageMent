using System.Diagnostics;

namespace LibraryManagementSys.Middlewares
{
    // Middlewares/RequestLoggingMiddleware.cs
    public class RequestLoggingMiddleware
    {
       
        

        public RequestLoggingMiddleware()
        {
           
        }

        //public async Task InvokeAsync(HttpContext context)
        //{
        //    var watch = Stopwatch.StartNew();

        //    _logger.LogInformation("Handling request: {method} {url}",
        //        context.Request.Method,
        //        context.Request.Path);

        //    await _next(context);

        //    watch.Stop();
        //    _logger.LogInformation("Finished handling request. Took {time} ms", watch.ElapsedMilliseconds);
        //}
    }

}
