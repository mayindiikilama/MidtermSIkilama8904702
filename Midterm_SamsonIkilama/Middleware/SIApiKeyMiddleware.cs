namespace Midterm_SamsonIkilama.Middleware
{
    public class SIApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string API_KEY = "MIDTERM_KEY_123_SI";

        public SIApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue("X-Api-Key", out var extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsJsonAsync(new
                {
                    error = "Unauthorized",
                    message = "Invalid or missing API key."
                });
                return;
            }

            if (extractedKey != API_KEY)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsJsonAsync(new
                {
                    error = "Unauthorized",
                    message = "Invalid or missing API key."
                });
                return;
            }

            await _next(context);
        }
    }
}
