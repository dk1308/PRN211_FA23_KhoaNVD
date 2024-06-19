using System.Net;

namespace Demo_01.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly ILogger<ExceptionHandlerMiddleware> logger;
        private readonly RequestDelegate next;

        public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger
                        , RequestDelegate next)
        {
            this.logger = logger;
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                // Log error
                Guid errorId = Guid.NewGuid();
                logger.LogError(e, $"{errorId}: {e.Message}");

                // Return custom respone
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var error = new
                {
                    Id = errorId,
                    Message = "Something went wrong"
                };

                await context.Response.WriteAsJsonAsync(error);
            }
        }
    }
}
