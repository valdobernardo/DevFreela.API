using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.ExceptionHandler
{
    public class ApiExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            // Cria um objeto ProblemDetails com informações sobre o erro
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "Server Error"
            };

            // Opcional: você pode registrar o erro em logs aqui

            // Define o status da resposta HTTP como 500

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            // Retorna a resposta em formato JSON com os detalhes do erro
            await httpContext.Response.WriteAsJsonAsync(details, cancellationToken);

            // Indica que o erro foi tratado
            return true;
        }
    }
}
