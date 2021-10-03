using Backend.Models;

namespace BackendService;

public static class ApiModule
{
    public static IEndpointRouteBuilder MapApiRoutes(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("api/v2/actuator/info", () =>
        {
            return new Info
            {
                ProcessorCount = Environment.ProcessorCount
            };
        })
        .Produces<Info>();

        return builder;
    }
}