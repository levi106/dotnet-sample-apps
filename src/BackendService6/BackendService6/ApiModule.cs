namespace BackendService6;

using BackendService6.Models;
using System.Collections.Concurrent;

public static class ApiModule
{
    private static ConcurrentQueue<byte[]> memoryQueue_ = new ();

    public static IEndpointRouteBuilder MapApiRoutes(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("api/v1/actuator/info", () =>
        {
            return new Info
            {
                ProcessorInfo = new ProcessorInfo
                {
                    ProcessorCount = Environment.ProcessorCount
                },
                MyGCMemoryInfo = new MyGCMemoryInfo(GC.GetGCMemoryInfo()),
                MemoryInfo = new MemoryInfo
                {
                    TotalAllocatedBytes = GC.GetTotalAllocatedBytes(),
                    TotalMemory = GC.GetTotalMemory(false),
                    Gen0CollectionCount = GC.CollectionCount(0),
                    Gen1CollectionCount = GC.CollectionCount(1),
                    Gen2CollectionCount = GC.CollectionCount(2)
               }
            };
        })
        .Produces<Info>();

        builder.MapPost("api/v1/leak/{size:long}", (long size) =>
        {
            var array = new byte[size * 1000000];
            array.AsSpan().Fill(42);
            memoryQueue_.Enqueue(array);
            return "Ok";
        })
        .Produces<string>();

        builder.MapPost("api/v1/gc", () =>
        {
            GC.Collect();
            return "Ok";
        })
        .Produces<string>();

        builder.MapPost("api/v1/free", () =>
        {
            memoryQueue_.Clear();
            return "Ok";
        })
        .Produces<string>();

        return builder;
    }
}