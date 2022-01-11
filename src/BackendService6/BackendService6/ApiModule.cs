namespace BackendService6;

using BackendService6.Models;

public static class ApiModule
{
    public static IEndpointRouteBuilder MapApiRoutes(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("api/v1/actuator/info", () =>
        {
            return new Info
            {
                ProcessorCount = Environment.ProcessorCount
            };
        })
        .Produces<Info>();

        builder.MapGet("api/v1/leak", () =>
        {
            return "Ok";
        })
        .Produces<string>();

        return builder;
    }
}